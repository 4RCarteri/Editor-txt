namespace Editor_txt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuBar = new MenuStrip();
            mFile = new ToolStripMenuItem();
            mFileNew = new ToolStripMenuItem();
            mFileNewWindow = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mFileOpen = new ToolStripMenuItem();
            mFileSave = new ToolStripMenuItem();
            mFileSaveAs = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mFileExit = new ToolStripMenuItem();
            mEdit = new ToolStripMenuItem();
            mEditUndo = new ToolStripMenuItem();
            mEditRedo = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mEditCut = new ToolStripMenuItem();
            mEditCopy = new ToolStripMenuItem();
            mEditPaste = new ToolStripMenuItem();
            mEditDelete = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mEditDatetime = new ToolStripMenuItem();
            mFormat = new ToolStripMenuItem();
            mFormatWordWrap = new ToolStripMenuItem();
            mFormatFont = new ToolStripMenuItem();
            mView = new ToolStripMenuItem();
            mViewZoom = new ToolStripMenuItem();
            mViewZoomZoomIn = new ToolStripMenuItem();
            mViewZoomZoomOut = new ToolStripMenuItem();
            mViewZoomRestore = new ToolStripMenuItem();
            mViewStatusBar = new ToolStripMenuItem();
            mHelp = new ToolStripMenuItem();
            mHelpShowHelp = new ToolStripMenuItem();
            mHelpAbout = new ToolStripMenuItem();
            statusBar = new StatusStrip();
            statusBarLabel = new ToolStripStatusLabel();
            txtContent = new RichTextBox();
            menuBar.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuBar.Items.AddRange(new ToolStripItem[] { mFile, mEdit, mFormat, mView, mHelp });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(784, 29);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // mFile
            // 
            mFile.DropDownItems.AddRange(new ToolStripItem[] { mFileNew, mFileNewWindow, toolStripSeparator1, mFileOpen, mFileSave, mFileSaveAs, toolStripSeparator2, mFileExit });
            mFile.Name = "mFile";
            mFile.Size = new Size(47, 25);
            mFile.Text = "File";
            // 
            // mFileNew
            // 
            mFileNew.Name = "mFileNew";
            mFileNew.Size = new Size(180, 26);
            mFileNew.Text = "New";
            mFileNew.Click += mFileNew_Click;
            // 
            // mFileNewWindow
            // 
            mFileNewWindow.Name = "mFileNewWindow";
            mFileNewWindow.Size = new Size(180, 26);
            mFileNewWindow.Text = "New window";
            mFileNewWindow.Click += mFileNewWindow_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // mFileOpen
            // 
            mFileOpen.Name = "mFileOpen";
            mFileOpen.Size = new Size(180, 26);
            mFileOpen.Text = "Open";
            mFileOpen.Click += mFileOpen_Click;
            // 
            // mFileSave
            // 
            mFileSave.Name = "mFileSave";
            mFileSave.Size = new Size(180, 26);
            mFileSave.Text = "Save";
            mFileSave.Click += mFileSave_Click;
            // 
            // mFileSaveAs
            // 
            mFileSaveAs.Name = "mFileSaveAs";
            mFileSaveAs.Size = new Size(180, 26);
            mFileSaveAs.Text = "Save as";
            mFileSaveAs.Click += mFileSaveAs_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // mFileExit
            // 
            mFileExit.Name = "mFileExit";
            mFileExit.Size = new Size(180, 26);
            mFileExit.Text = "Exit";
            mFileExit.Click += mFileExit_Click;
            // 
            // mEdit
            // 
            mEdit.DropDownItems.AddRange(new ToolStripItem[] { mEditUndo, mEditRedo, toolStripSeparator3, mEditCut, mEditCopy, mEditPaste, mEditDelete, toolStripSeparator4, mEditDatetime });
            mEdit.Name = "mEdit";
            mEdit.Size = new Size(50, 25);
            mEdit.Text = "Edit";
            // 
            // mEditUndo
            // 
            mEditUndo.Name = "mEditUndo";
            mEditUndo.Size = new Size(147, 26);
            mEditUndo.Text = "Undo";
            // 
            // mEditRedo
            // 
            mEditRedo.Name = "mEditRedo";
            mEditRedo.Size = new Size(147, 26);
            mEditRedo.Text = "Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(144, 6);
            // 
            // mEditCut
            // 
            mEditCut.Name = "mEditCut";
            mEditCut.Size = new Size(147, 26);
            mEditCut.Text = "Cut";
            // 
            // mEditCopy
            // 
            mEditCopy.Name = "mEditCopy";
            mEditCopy.Size = new Size(147, 26);
            mEditCopy.Text = "Copy";
            // 
            // mEditPaste
            // 
            mEditPaste.Name = "mEditPaste";
            mEditPaste.Size = new Size(147, 26);
            mEditPaste.Text = "Paste";
            // 
            // mEditDelete
            // 
            mEditDelete.Name = "mEditDelete";
            mEditDelete.Size = new Size(147, 26);
            mEditDelete.Text = "Delete";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(144, 6);
            // 
            // mEditDatetime
            // 
            mEditDatetime.Name = "mEditDatetime";
            mEditDatetime.Size = new Size(147, 26);
            mEditDatetime.Text = "Datetime";
            // 
            // mFormat
            // 
            mFormat.DropDownItems.AddRange(new ToolStripItem[] { mFormatWordWrap, mFormatFont });
            mFormat.Name = "mFormat";
            mFormat.Size = new Size(74, 25);
            mFormat.Text = "Format";
            // 
            // mFormatWordWrap
            // 
            mFormatWordWrap.Name = "mFormatWordWrap";
            mFormatWordWrap.Size = new Size(161, 26);
            mFormatWordWrap.Text = "Word wrap";
            // 
            // mFormatFont
            // 
            mFormatFont.Name = "mFormatFont";
            mFormatFont.Size = new Size(161, 26);
            mFormatFont.Text = "Font";
            // 
            // mView
            // 
            mView.DropDownItems.AddRange(new ToolStripItem[] { mViewZoom, mViewStatusBar });
            mView.Name = "mView";
            mView.Size = new Size(57, 25);
            mView.Text = "View";
            // 
            // mViewZoom
            // 
            mViewZoom.DropDownItems.AddRange(new ToolStripItem[] { mViewZoomZoomIn, mViewZoomZoomOut, mViewZoomRestore });
            mViewZoom.Name = "mViewZoom";
            mViewZoom.Size = new Size(153, 26);
            mViewZoom.Text = "Zoom";
            // 
            // mViewZoomZoomIn
            // 
            mViewZoomZoomIn.Name = "mViewZoomZoomIn";
            mViewZoomZoomIn.Size = new Size(152, 26);
            mViewZoomZoomIn.Text = "Zoom in";
            // 
            // mViewZoomZoomOut
            // 
            mViewZoomZoomOut.Name = "mViewZoomZoomOut";
            mViewZoomZoomOut.Size = new Size(152, 26);
            mViewZoomZoomOut.Text = "Zoom out";
            // 
            // mViewZoomRestore
            // 
            mViewZoomRestore.Name = "mViewZoomRestore";
            mViewZoomRestore.Size = new Size(152, 26);
            mViewZoomRestore.Text = "Restore";
            // 
            // mViewStatusBar
            // 
            mViewStatusBar.Checked = true;
            mViewStatusBar.CheckOnClick = true;
            mViewStatusBar.CheckState = CheckState.Checked;
            mViewStatusBar.Name = "mViewStatusBar";
            mViewStatusBar.Size = new Size(153, 26);
            mViewStatusBar.Text = "Status bar";
            // 
            // mHelp
            // 
            mHelp.DropDownItems.AddRange(new ToolStripItem[] { mHelpShowHelp, mHelpAbout });
            mHelp.Name = "mHelp";
            mHelp.Size = new Size(57, 25);
            mHelp.Text = "Help";
            // 
            // mHelpShowHelp
            // 
            mHelpShowHelp.Name = "mHelpShowHelp";
            mHelpShowHelp.Size = new Size(156, 26);
            mHelpShowHelp.Text = "Show help";
            // 
            // mHelpAbout
            // 
            mHelpAbout.Name = "mHelpAbout";
            mHelpAbout.Size = new Size(156, 26);
            mHelpAbout.Text = "About";
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarLabel });
            statusBar.Location = new Point(0, 539);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(784, 22);
            statusBar.TabIndex = 1;
            statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            statusBarLabel.Name = "statusBarLabel";
            statusBarLabel.Size = new Size(35, 17);
            statusBarLabel.Text = "100%";
            // 
            // txtContent
            // 
            txtContent.Dock = DockStyle.Fill;
            txtContent.Location = new Point(0, 29);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(784, 510);
            txtContent.TabIndex = 2;
            txtContent.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(txtContent);
            Controls.Add(statusBar);
            Controls.Add(menuBar);
            MainMenuStrip = menuBar;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor TXT";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem mFile;
        private ToolStripMenuItem mFileNew;
        private ToolStripMenuItem mFileNewWindow;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mFileOpen;
        private ToolStripMenuItem mFileSave;
        private ToolStripMenuItem mFileSaveAs;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mFileExit;
        private ToolStripMenuItem mEdit;
        private ToolStripMenuItem mEditUndo;
        private ToolStripMenuItem mEditRedo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mEditCut;
        private ToolStripMenuItem mEditCopy;
        private ToolStripMenuItem mEditPaste;
        private ToolStripMenuItem mEditDelete;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mEditDatetime;
        private ToolStripMenuItem mFormat;
        private ToolStripMenuItem mView;
        private ToolStripMenuItem mHelp;
        private ToolStripMenuItem mFormatWordWrap;
        private ToolStripMenuItem mFormatFont;
        private ToolStripMenuItem mViewZoom;
        private ToolStripMenuItem mViewZoomZoomIn;
        private ToolStripMenuItem mViewZoomZoomOut;
        private ToolStripMenuItem mViewZoomRestore;
        private ToolStripMenuItem mViewStatusBar;
        private ToolStripMenuItem mHelpShowHelp;
        private ToolStripMenuItem mHelpAbout;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusBarLabel;
        private RichTextBox txtContent;
    }
}
