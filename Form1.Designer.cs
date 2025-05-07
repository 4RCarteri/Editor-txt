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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            toolStrip1 = new ToolStrip();
            toolBarNew = new ToolStripButton();
            toolBarOpen = new ToolStripButton();
            toolBarSave = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolBarFont = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolBarZoom = new ToolStripButton();
            toolBarZoomOut = new ToolStripButton();
            toolBarZoomIn = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            toolBarHelp = new ToolStripButton();
            toolBarExit = new ToolStripButton();
            txtContent = new RichTextBox();
            menuBar.SuspendLayout();
            statusBar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuBar.ImageScalingSize = new Size(24, 24);
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
            mFileNew.Image = Properties.Resources.new_document;
            mFileNew.Name = "mFileNew";
            mFileNew.ShortcutKeys = Keys.Control | Keys.N;
            mFileNew.Size = new Size(286, 30);
            mFileNew.Text = "New";
            mFileNew.Click += mFileNew_Click;
            // 
            // mFileNewWindow
            // 
            mFileNewWindow.Image = Properties.Resources.notes;
            mFileNewWindow.Name = "mFileNewWindow";
            mFileNewWindow.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            mFileNewWindow.Size = new Size(286, 30);
            mFileNewWindow.Text = "New window";
            mFileNewWindow.Click += mFileNewWindow_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(283, 6);
            // 
            // mFileOpen
            // 
            mFileOpen.Image = Properties.Resources.folder;
            mFileOpen.Name = "mFileOpen";
            mFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            mFileOpen.Size = new Size(286, 30);
            mFileOpen.Text = "Open";
            mFileOpen.Click += mFileOpen_Click;
            // 
            // mFileSave
            // 
            mFileSave.Image = Properties.Resources.save;
            mFileSave.Name = "mFileSave";
            mFileSave.ShortcutKeys = Keys.Control | Keys.S;
            mFileSave.Size = new Size(286, 30);
            mFileSave.Text = "Save";
            mFileSave.Click += mFileSave_Click;
            // 
            // mFileSaveAs
            // 
            mFileSaveAs.Image = Properties.Resources.save;
            mFileSaveAs.Name = "mFileSaveAs";
            mFileSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            mFileSaveAs.Size = new Size(286, 30);
            mFileSaveAs.Text = "Save as";
            mFileSaveAs.Click += mFileSaveAs_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(283, 6);
            // 
            // mFileExit
            // 
            mFileExit.Image = Properties.Resources.exit;
            mFileExit.Name = "mFileExit";
            mFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mFileExit.Size = new Size(286, 30);
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
            mEditUndo.ShortcutKeys = Keys.Control | Keys.Z;
            mEditUndo.Size = new Size(220, 26);
            mEditUndo.Text = "Undo";
            mEditUndo.Click += mEditUndo_Click;
            // 
            // mEditRedo
            // 
            mEditRedo.Name = "mEditRedo";
            mEditRedo.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            mEditRedo.Size = new Size(220, 26);
            mEditRedo.Text = "Redo";
            mEditRedo.Click += mEditRedo_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(217, 6);
            // 
            // mEditCut
            // 
            mEditCut.Name = "mEditCut";
            mEditCut.ShortcutKeys = Keys.Control | Keys.X;
            mEditCut.Size = new Size(220, 26);
            mEditCut.Text = "Cut";
            mEditCut.Click += mEditCut_Click;
            // 
            // mEditCopy
            // 
            mEditCopy.Name = "mEditCopy";
            mEditCopy.ShortcutKeys = Keys.Control | Keys.C;
            mEditCopy.Size = new Size(220, 26);
            mEditCopy.Text = "Copy";
            mEditCopy.Click += mEditCopy_Click;
            // 
            // mEditPaste
            // 
            mEditPaste.Name = "mEditPaste";
            mEditPaste.ShortcutKeys = Keys.Control | Keys.V;
            mEditPaste.Size = new Size(220, 26);
            mEditPaste.Text = "Paste";
            mEditPaste.Click += mEditPaste_Click;
            // 
            // mEditDelete
            // 
            mEditDelete.Name = "mEditDelete";
            mEditDelete.ShortcutKeys = Keys.Delete;
            mEditDelete.Size = new Size(220, 26);
            mEditDelete.Text = "Delete";
            mEditDelete.Click += mEditDelete_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(217, 6);
            // 
            // mEditDatetime
            // 
            mEditDatetime.Name = "mEditDatetime";
            mEditDatetime.ShortcutKeys = Keys.F5;
            mEditDatetime.Size = new Size(220, 26);
            mEditDatetime.Text = "Datetime";
            mEditDatetime.Click += mEditDatetime_Click;
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
            mFormatWordWrap.CheckOnClick = true;
            mFormatWordWrap.Name = "mFormatWordWrap";
            mFormatWordWrap.Size = new Size(161, 26);
            mFormatWordWrap.Text = "Word wrap";
            mFormatWordWrap.Click += mFormatWordWrap_Click;
            // 
            // mFormatFont
            // 
            mFormatFont.Name = "mFormatFont";
            mFormatFont.Size = new Size(161, 26);
            mFormatFont.Text = "Font";
            mFormatFont.Click += mFormatFont_Click;
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
            mViewZoomZoomIn.Image = Properties.Resources.zoom;
            mViewZoomZoomIn.Name = "mViewZoomZoomIn";
            mViewZoomZoomIn.ShortcutKeyDisplayString = "Ctrl +";
            mViewZoomZoomIn.ShortcutKeys = Keys.Control | Keys.Oemplus;
            mViewZoomZoomIn.Size = new Size(206, 30);
            mViewZoomZoomIn.Text = "Zoom in";
            mViewZoomZoomIn.Click += mViewZoomZoomIn_Click;
            // 
            // mViewZoomZoomOut
            // 
            mViewZoomZoomOut.Image = Properties.Resources.zoom;
            mViewZoomZoomOut.Name = "mViewZoomZoomOut";
            mViewZoomZoomOut.ShortcutKeyDisplayString = "Ctrl -";
            mViewZoomZoomOut.ShortcutKeys = Keys.Control | Keys.OemMinus;
            mViewZoomZoomOut.Size = new Size(206, 30);
            mViewZoomZoomOut.Text = "Zoom out";
            mViewZoomZoomOut.Click += mViewZoomZoomOut_Click;
            // 
            // mViewZoomRestore
            // 
            mViewZoomRestore.Name = "mViewZoomRestore";
            mViewZoomRestore.Size = new Size(206, 30);
            mViewZoomRestore.Text = "Restore";
            mViewZoomRestore.Click += mViewZoomRestore_Click;
            // 
            // mViewStatusBar
            // 
            mViewStatusBar.Checked = true;
            mViewStatusBar.CheckOnClick = true;
            mViewStatusBar.CheckState = CheckState.Checked;
            mViewStatusBar.Name = "mViewStatusBar";
            mViewStatusBar.Size = new Size(153, 26);
            mViewStatusBar.Text = "Status bar";
            mViewStatusBar.Click += mViewStatusBar_Click;
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
            mHelpShowHelp.Image = Properties.Resources.help;
            mHelpShowHelp.Name = "mHelpShowHelp";
            mHelpShowHelp.ShortcutKeys = Keys.F1;
            mHelpShowHelp.Size = new Size(188, 30);
            mHelpShowHelp.Text = "Show help";
            mHelpShowHelp.Click += mHelpShowHelp_Click;
            // 
            // mHelpAbout
            // 
            mHelpAbout.Name = "mHelpAbout";
            mHelpAbout.Size = new Size(188, 30);
            mHelpAbout.Text = "About";
            mHelpAbout.Click += mHelpAbout_Click;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(24, 24);
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBarNew, toolBarOpen, toolBarSave, toolStripSeparator5, toolBarFont, toolStripSeparator6, toolBarZoom, toolBarZoomOut, toolBarZoomIn, toolStripSeparator7, toolBarHelp, toolBarExit });
            toolStrip1.Location = new Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolBarNew
            // 
            toolBarNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarNew.Image = Properties.Resources.new_document;
            toolBarNew.ImageTransparentColor = Color.Magenta;
            toolBarNew.Name = "toolBarNew";
            toolBarNew.Size = new Size(23, 25);
            toolBarNew.Text = "New";
            toolBarNew.Click += mFileNew_Click;
            // 
            // toolBarOpen
            // 
            toolBarOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarOpen.Image = Properties.Resources.folder;
            toolBarOpen.ImageTransparentColor = Color.Magenta;
            toolBarOpen.Name = "toolBarOpen";
            toolBarOpen.Size = new Size(23, 25);
            toolBarOpen.Text = "Open";
            toolBarOpen.Click += mFileOpen_Click;
            // 
            // toolBarSave
            // 
            toolBarSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarSave.Image = Properties.Resources.save;
            toolBarSave.ImageTransparentColor = Color.Magenta;
            toolBarSave.Name = "toolBarSave";
            toolBarSave.Size = new Size(23, 25);
            toolBarSave.Text = "Save";
            toolBarSave.Click += mFileSave_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 28);
            // 
            // toolBarFont
            // 
            toolBarFont.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolBarFont.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolBarFont.ImageTransparentColor = Color.Magenta;
            toolBarFont.Name = "toolBarFont";
            toolBarFont.Size = new Size(24, 25);
            toolBarFont.Text = "A";
            toolBarFont.ToolTipText = "Font";
            toolBarFont.Click += mFormatFont_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 28);
            // 
            // toolBarZoom
            // 
            toolBarZoom.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarZoom.Image = Properties.Resources.zoom;
            toolBarZoom.ImageTransparentColor = Color.Magenta;
            toolBarZoom.Name = "toolBarZoom";
            toolBarZoom.Size = new Size(23, 25);
            toolBarZoom.Text = "Restore";
            toolBarZoom.ToolTipText = "Zoom 100%";
            toolBarZoom.Click += mViewZoomRestore_Click;
            // 
            // toolBarZoomOut
            // 
            toolBarZoomOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolBarZoomOut.Image = Properties.Resources.zoom;
            toolBarZoomOut.ImageTransparentColor = Color.Magenta;
            toolBarZoomOut.Name = "toolBarZoomOut";
            toolBarZoomOut.Size = new Size(23, 25);
            toolBarZoomOut.Text = "-";
            toolBarZoomOut.TextImageRelation = TextImageRelation.Overlay;
            toolBarZoomOut.ToolTipText = "Zoom out";
            toolBarZoomOut.Click += mViewZoomZoomOut_Click;
            // 
            // toolBarZoomIn
            // 
            toolBarZoomIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolBarZoomIn.Image = Properties.Resources.zoom;
            toolBarZoomIn.ImageTransparentColor = Color.Magenta;
            toolBarZoomIn.Name = "toolBarZoomIn";
            toolBarZoomIn.Size = new Size(25, 25);
            toolBarZoomIn.Text = "+";
            toolBarZoomIn.TextImageRelation = TextImageRelation.Overlay;
            toolBarZoomIn.ToolTipText = "Zoom in";
            toolBarZoomIn.Click += mViewZoomZoomIn_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 28);
            // 
            // toolBarHelp
            // 
            toolBarHelp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarHelp.Image = Properties.Resources.help;
            toolBarHelp.ImageTransparentColor = Color.Magenta;
            toolBarHelp.Name = "toolBarHelp";
            toolBarHelp.Size = new Size(23, 25);
            toolBarHelp.Text = "Help";
            toolBarHelp.Click += mHelpShowHelp_Click;
            // 
            // toolBarExit
            // 
            toolBarExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarExit.Image = Properties.Resources.exit;
            toolBarExit.ImageTransparentColor = Color.Magenta;
            toolBarExit.Name = "toolBarExit";
            toolBarExit.Size = new Size(23, 25);
            toolBarExit.Text = "Exit";
            toolBarExit.ToolTipText = "Exit";
            toolBarExit.Click += mFileExit_Click;
            // 
            // txtContent
            // 
            txtContent.Dock = DockStyle.Fill;
            txtContent.Location = new Point(0, 57);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(784, 482);
            txtContent.TabIndex = 3;
            txtContent.Text = "";
            txtContent.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(txtContent);
            Controls.Add(toolStrip1);
            Controls.Add(statusBar);
            Controls.Add(menuBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuBar;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor TXT";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton toolBarNew;
        private ToolStripButton toolBarOpen;
        private ToolStripButton toolBarSave;
        private ToolStripButton toolBarExit;
        private ToolStripSeparator toolStripSeparator5;
        private RichTextBox txtContent;
        private ToolStripButton toolBarFont;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolBarZoomIn;
        private ToolStripButton toolBarZoomOut;
        private ToolStripButton toolBarZoom;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolBarHelp;
    }
}
