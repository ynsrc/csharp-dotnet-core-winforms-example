namespace YNSRC
{
    partial class FormMain
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
            mainContainer = new ToolStripContainer();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            mainMenu = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuFileOpen = new ToolStripMenuItem();
            menuSeperator1 = new ToolStripSeparator();
            menuSaveFile = new ToolStripMenuItem();
            menuFileSaveAs = new ToolStripMenuItem();
            menuEdit = new ToolStripMenuItem();
            menuEditCopy = new ToolStripMenuItem();
            menuEditCut = new ToolStripMenuItem();
            menuEditPaste = new ToolStripMenuItem();
            menuSeperator2 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            mainContainer.BottomToolStripPanel.SuspendLayout();
            mainContainer.TopToolStripPanel.SuspendLayout();
            mainContainer.SuspendLayout();
            statusStrip.SuspendLayout();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            // 
            // mainContainer.BottomToolStripPanel
            // 
            mainContainer.BottomToolStripPanel.Controls.Add(statusStrip);
            // 
            // mainContainer.ContentPanel
            // 
            mainContainer.ContentPanel.Size = new Size(861, 573);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(861, 619);
            mainContainer.TabIndex = 0;
            mainContainer.Text = "toolStripContainer1";
            // 
            // mainContainer.TopToolStripPanel
            // 
            mainContainer.TopToolStripPanel.Controls.Add(mainMenu);
            // 
            // statusStrip
            // 
            statusStrip.Dock = DockStyle.None;
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 0);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(861, 22);
            statusStrip.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 17);
            statusLabel.Text = "Status";
            // 
            // mainMenu
            // 
            mainMenu.Dock = DockStyle.None;
            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, menuEdit });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(861, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileOpen, menuSeperator1, menuSaveFile, menuFileSaveAs });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "&File";
            // 
            // menuFileOpen
            // 
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            menuFileOpen.Size = new Size(207, 22);
            menuFileOpen.Text = "&Open File";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // menuSeperator1
            // 
            menuSeperator1.Name = "menuSeperator1";
            menuSeperator1.Size = new Size(204, 6);
            // 
            // menuSaveFile
            // 
            menuSaveFile.Name = "menuSaveFile";
            menuSaveFile.ShortcutKeys = Keys.Control | Keys.S;
            menuSaveFile.Size = new Size(207, 22);
            menuSaveFile.Text = "&Save File";
            menuSaveFile.Click += menuSaveFile_Click;
            // 
            // menuFileSaveAs
            // 
            menuFileSaveAs.Name = "menuFileSaveAs";
            menuFileSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            menuFileSaveAs.Size = new Size(207, 22);
            menuFileSaveAs.Text = "Save File &As";
            menuFileSaveAs.Click += menuFileSaveAs_Click;
            // 
            // menuEdit
            // 
            menuEdit.DropDownItems.AddRange(new ToolStripItem[] { menuEditCopy, menuEditCut, menuEditPaste, menuSeperator2, selectAllToolStripMenuItem });
            menuEdit.Name = "menuEdit";
            menuEdit.Size = new Size(39, 20);
            menuEdit.Text = "&Edit";
            // 
            // menuEditCopy
            // 
            menuEditCopy.Name = "menuEditCopy";
            menuEditCopy.ShortcutKeys = Keys.Control | Keys.C;
            menuEditCopy.Size = new Size(180, 22);
            menuEditCopy.Text = "&Copy";
            menuEditCopy.Click += menuEditCopy_Click;
            // 
            // menuEditCut
            // 
            menuEditCut.Name = "menuEditCut";
            menuEditCut.ShortcutKeys = Keys.Control | Keys.X;
            menuEditCut.Size = new Size(180, 22);
            menuEditCut.Text = "Cu&t";
            menuEditCut.Click += menuEditCut_Click;
            // 
            // menuEditPaste
            // 
            menuEditPaste.Name = "menuEditPaste";
            menuEditPaste.ShortcutKeys = Keys.Control | Keys.V;
            menuEditPaste.Size = new Size(180, 22);
            menuEditPaste.Text = "&Paste";
            menuEditPaste.Click += menuEditPaste_Click;
            // 
            // menuSeperator2
            // 
            menuSeperator2.Name = "menuSeperator2";
            menuSeperator2.Size = new Size(177, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(180, 22);
            selectAllToolStripMenuItem.Text = "Select &All";
            selectAllToolStripMenuItem.Click += menuEditSelectAll_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 619);
            Controls.Add(mainContainer);
            MainMenuStrip = mainMenu;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C# Example .NET Core Windows Form";
            Load += FormMain_Load;
            mainContainer.BottomToolStripPanel.ResumeLayout(false);
            mainContainer.BottomToolStripPanel.PerformLayout();
            mainContainer.TopToolStripPanel.ResumeLayout(false);
            mainContainer.TopToolStripPanel.PerformLayout();
            mainContainer.ResumeLayout(false);
            mainContainer.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer mainContainer;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private MenuStrip mainMenu;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripSeparator menuSeperator1;
        private ToolStripMenuItem menuSaveFile;
        private ToolStripMenuItem menuFileSaveAs;
        private ToolStripMenuItem menuEdit;
        private ToolStripMenuItem menuEditCopy;
        private ToolStripMenuItem menuEditCut;
        private ToolStripMenuItem menuEditPaste;
        private ToolStripSeparator menuSeperator2;
        private ToolStripMenuItem selectAllToolStripMenuItem;
    }
}
