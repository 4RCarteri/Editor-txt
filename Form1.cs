namespace Editor_txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Menu File
        private void mFileNew_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            mFileSave.Enabled = true;
            this.Text = Application.ProductName;
        }

        private void mFileNewWindow_Click(object sender, EventArgs e)
        {
            //Form1 newForm = new Form1();
            //newForm.Show();

            //Running with threads
            Thread newThread = new Thread(() => Application.Run(new Form1()));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void mFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open...";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.InitialDirectory = Manager.FolderPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    FileInfo file = new FileInfo(ofd.FileName);
                    this.Text = Application.ProductName + " - " + file.Name;

                    Manager.FolderPath = file.DirectoryName + "\\";
                    Manager.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Manager.FileExtension = file.Extension;

                    StreamReader stream = null;
                    try
                    {
                        stream = new StreamReader(file.FullName, true);
                        txtContent.Text = stream.ReadToEnd();
                        mFileSave.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening file: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void mFileSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(Manager.FilePath))
            {
                SaveFile(Manager.FilePath);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save...";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.CheckPathExists = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveFile(saveFileDialog.FileName);
                }
            }
        }

        private void mFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save as...";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog.FileName);
            }
        }

        private void SaveFile(string path)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(txtContent.Text);

                FileInfo fileInfo = new FileInfo(path);
                Manager.FolderPath = fileInfo.DirectoryName + "\\";
                Manager.FileName = fileInfo.Name.Remove(fileInfo.Name.LastIndexOf("."));
                Manager.FileExtension = fileInfo.Extension;

                this.Text = Application.ProductName + " - " + fileInfo.Name;

                mFileSave.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving file: \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                writer.Close();
            }
        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            mFileSave.Enabled = true;
        }
        #endregion

        #region Menu Edit
        private void mEditUndo_Click(object sender, EventArgs e)
        {
            txtContent.Undo();
        }

        private void mEditRedo_Click(object sender, EventArgs e)
        {
            txtContent.Redo();
        }

        private void mEditCut_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
        }

        private void mEditCopy_Click(object sender, EventArgs e)
        {
            txtContent.Copy();
        }

        private void mEditPaste_Click(object sender, EventArgs e)
        {
            txtContent.Paste();
        }

        private void mEditDelete_Click(object sender, EventArgs e)
        {
            txtContent.Text = txtContent.Text.Remove(txtContent.SelectionStart, txtContent.SelectionLength);
        }

        private void mEditDatetime_Click(object sender, EventArgs e)
        {
            int index = txtContent.SelectionStart;
            string dateTime = DateTime.Now.ToString();

            if (txtContent.SelectionStart == txtContent.Text.Length)
            {
                txtContent.AppendText(dateTime);
                txtContent.SelectionStart = txtContent.Text.Length + dateTime.Length;
            }
            else if (txtContent.SelectionStart == 0)
            {
                txtContent.Text = txtContent.Text.Insert(0, dateTime);
                txtContent.SelectionStart = dateTime.Length;
            }
            else
            {
                txtContent.Text = txtContent.Text.Insert(txtContent.SelectionStart, dateTime);
                txtContent.SelectionStart = index + dateTime.Length;
            }
        }
        #endregion

        #region Menu Format
        private void mFormatWordWrap_Click(object sender, EventArgs e)
        {
            txtContent.WordWrap = mFormatWordWrap.Checked;
        }

        private void mFormatFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowEffects = true;

            fontDialog.Font = txtContent.Font;
            fontDialog.Color = txtContent.ForeColor;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtContent.Font = fontDialog.Font;
                txtContent.ForeColor = fontDialog.Color;
            }
        }
        #endregion

        #region Menu View

        private void mViewZoomZoomIn_Click(object sender, EventArgs e)
        {
            txtContent.ZoomFactor += 0.2f;
            setZoomStatusBar();
        }

        private void mViewZoomZoomOut_Click(object sender, EventArgs e)
        {
            txtContent.ZoomFactor -= 0.2f;
            setZoomStatusBar();
        }

        private void mViewZoomRestore_Click(object sender, EventArgs e)
        {
            txtContent.ZoomFactor = 1.0f;
            setZoomStatusBar();
        }

        private void mViewStatusBar_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mViewStatusBar.Checked;
        }

        private void setZoomStatusBar()
        {
            statusBarLabel.Text = $"{(txtContent.ZoomFactor * 100).ToString("0")}%";
        }
        #endregion

        #region Menu Help

        private void mHelpShowHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        private void mHelpAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }
        #endregion
    }
}
