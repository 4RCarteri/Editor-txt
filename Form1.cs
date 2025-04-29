using System.IO;

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
            if(File.Exists(Manager.FilePath))
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
        #endregion
    }
}
