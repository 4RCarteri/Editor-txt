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

        }

        private void mFileSave_Click(object sender, EventArgs e)
        {

        }

        private void mFileSaveAs_Click(object sender, EventArgs e)
        {

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
