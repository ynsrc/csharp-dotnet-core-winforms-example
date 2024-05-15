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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            toolStripContainer = new ToolStripContainer();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            splitContainerMain = new SplitContainer();
            treeViewFolder = new TreeView();
            imageList = new ImageList(components);
            toolStripFolder = new ToolStrip();
            btnSelectFolder = new ToolStripButton();
            btnShowDrives = new ToolStripButton();
            btnGoDesktop = new ToolStripButton();
            btnGoUserHome = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnShowNetwork = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnGoToParentFolder = new ToolStripButton();
            btnRefreshFolder = new ToolStripButton();
            tabControlFiles = new TabControl();
            toolStrip1 = new ToolStrip();
            btnCloseFile = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnSaveFile = new ToolStripButton();
            menuStrip = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuOpenFile = new ToolStripMenuItem();
            menuFileOpenFolder = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuCloseFile = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            menuFileSave = new ToolStripMenuItem();
            toolStripContainer.BottomToolStripPanel.SuspendLayout();
            toolStripContainer.ContentPanel.SuspendLayout();
            toolStripContainer.TopToolStripPanel.SuspendLayout();
            toolStripContainer.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            toolStripFolder.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            toolStripContainer.ContentPanel.Controls.Add(splitContainerMain);
            toolStripContainer.ContentPanel.Size = new Size(784, 515);
            toolStripContainer.Dock = DockStyle.Fill;
            toolStripContainer.Location = new Point(0, 0);
            toolStripContainer.Name = "toolStripContainer";
            toolStripContainer.Size = new Size(784, 561);
            toolStripContainer.TabIndex = 0;
            toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            toolStripContainer.TopToolStripPanel.Controls.Add(menuStrip);
            // 
            // statusStrip
            // 
            statusStrip.Dock = DockStyle.None;
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 0);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(784, 22);
            statusStrip.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 17);
            statusLabel.Text = "Status";
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 0);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(treeViewFolder);
            splitContainerMain.Panel1.Controls.Add(toolStripFolder);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(tabControlFiles);
            splitContainerMain.Panel2.Controls.Add(toolStrip1);
            splitContainerMain.Size = new Size(784, 515);
            splitContainerMain.SplitterDistance = 216;
            splitContainerMain.TabIndex = 0;
            // 
            // treeViewFolder
            // 
            treeViewFolder.Dock = DockStyle.Fill;
            treeViewFolder.ImageIndex = 0;
            treeViewFolder.ImageList = imageList;
            treeViewFolder.Location = new Point(0, 31);
            treeViewFolder.Name = "treeViewFolder";
            treeViewFolder.SelectedImageKey = "selected";
            treeViewFolder.Size = new Size(216, 484);
            treeViewFolder.TabIndex = 3;
            treeViewFolder.AfterSelect += treeViewFolder_AfterSelect;
            treeViewFolder.DoubleClick += treeViewFolder_DoubleClick;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "folder");
            imageList.Images.SetKeyName(1, "file");
            imageList.Images.SetKeyName(2, "drive");
            imageList.Images.SetKeyName(3, "selected");
            // 
            // toolStripFolder
            // 
            toolStripFolder.GripStyle = ToolStripGripStyle.Hidden;
            toolStripFolder.ImageScalingSize = new Size(24, 24);
            toolStripFolder.Items.AddRange(new ToolStripItem[] { btnSelectFolder, btnShowDrives, btnGoDesktop, btnGoUserHome, toolStripSeparator1, btnShowNetwork, toolStripSeparator2, btnGoToParentFolder, btnRefreshFolder });
            toolStripFolder.Location = new Point(0, 0);
            toolStripFolder.Name = "toolStripFolder";
            toolStripFolder.Size = new Size(216, 31);
            toolStripFolder.TabIndex = 2;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSelectFolder.Image = (Image)resources.GetObject("btnSelectFolder.Image");
            btnSelectFolder.ImageTransparentColor = Color.Magenta;
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(28, 28);
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // btnShowDrives
            // 
            btnShowDrives.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnShowDrives.Image = (Image)resources.GetObject("btnShowDrives.Image");
            btnShowDrives.ImageTransparentColor = Color.Magenta;
            btnShowDrives.Name = "btnShowDrives";
            btnShowDrives.Size = new Size(28, 28);
            btnShowDrives.Text = "My Computer";
            btnShowDrives.Click += btnShowDrives_Click;
            // 
            // btnGoDesktop
            // 
            btnGoDesktop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGoDesktop.Image = (Image)resources.GetObject("btnGoDesktop.Image");
            btnGoDesktop.ImageTransparentColor = Color.Magenta;
            btnGoDesktop.Name = "btnGoDesktop";
            btnGoDesktop.Size = new Size(28, 28);
            btnGoDesktop.Text = "Desktop";
            btnGoDesktop.Click += btnGoDesktop_Click;
            // 
            // btnGoUserHome
            // 
            btnGoUserHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGoUserHome.Image = (Image)resources.GetObject("btnGoUserHome.Image");
            btnGoUserHome.ImageTransparentColor = Color.Magenta;
            btnGoUserHome.Name = "btnGoUserHome";
            btnGoUserHome.Size = new Size(28, 28);
            btnGoUserHome.Text = "User Home";
            btnGoUserHome.Click += btnGoUserHome_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnShowNetwork
            // 
            btnShowNetwork.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnShowNetwork.Image = (Image)resources.GetObject("btnShowNetwork.Image");
            btnShowNetwork.ImageTransparentColor = Color.Magenta;
            btnShowNetwork.Name = "btnShowNetwork";
            btnShowNetwork.Size = new Size(28, 28);
            btnShowNetwork.Text = "Network Folder";
            btnShowNetwork.Click += btnShowNetwork_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // btnGoToParentFolder
            // 
            btnGoToParentFolder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGoToParentFolder.Image = (Image)resources.GetObject("btnGoToParentFolder.Image");
            btnGoToParentFolder.ImageTransparentColor = Color.Magenta;
            btnGoToParentFolder.Name = "btnGoToParentFolder";
            btnGoToParentFolder.Size = new Size(28, 28);
            btnGoToParentFolder.Text = "Parent Folder";
            btnGoToParentFolder.Click += btnGoToParentFolder_Click;
            // 
            // btnRefreshFolder
            // 
            btnRefreshFolder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRefreshFolder.Image = (Image)resources.GetObject("btnRefreshFolder.Image");
            btnRefreshFolder.ImageTransparentColor = Color.Magenta;
            btnRefreshFolder.Name = "btnRefreshFolder";
            btnRefreshFolder.Size = new Size(28, 28);
            btnRefreshFolder.Text = "Refresh";
            btnRefreshFolder.Click += btnRefreshFolder_Click;
            // 
            // tabControlFiles
            // 
            tabControlFiles.Dock = DockStyle.Fill;
            tabControlFiles.Location = new Point(0, 25);
            tabControlFiles.Name = "tabControlFiles";
            tabControlFiles.SelectedIndex = 0;
            tabControlFiles.Size = new Size(564, 490);
            tabControlFiles.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCloseFile, toolStripSeparator3, btnSaveFile });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(564, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCloseFile
            // 
            btnCloseFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCloseFile.Image = (Image)resources.GetObject("btnCloseFile.Image");
            btnCloseFile.ImageTransparentColor = Color.Magenta;
            btnCloseFile.Name = "btnCloseFile";
            btnCloseFile.Size = new Size(23, 22);
            btnCloseFile.Text = "Close File";
            btnCloseFile.Click += btnCloseFile_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnSaveFile
            // 
            btnSaveFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveFile.Image = (Image)resources.GetObject("btnSaveFile.Image");
            btnSaveFile.ImageTransparentColor = Color.Magenta;
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(23, 22);
            btnSaveFile.Text = "Save File";
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // menuStrip
            // 
            menuStrip.Dock = DockStyle.None;
            menuStrip.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(784, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuOpenFile, menuFileOpenFolder, toolStripMenuItem1, menuCloseFile, toolStripMenuItem2, menuFileSave });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "&File";
            // 
            // menuOpenFile
            // 
            menuOpenFile.Name = "menuOpenFile";
            menuOpenFile.ShortcutKeys = Keys.Control | Keys.O;
            menuOpenFile.Size = new Size(214, 22);
            menuOpenFile.Text = "&Open File";
            menuOpenFile.Click += menuOpenFile_Click;
            // 
            // menuFileOpenFolder
            // 
            menuFileOpenFolder.Name = "menuFileOpenFolder";
            menuFileOpenFolder.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            menuFileOpenFolder.Size = new Size(214, 22);
            menuFileOpenFolder.Text = "Open &Folder";
            menuFileOpenFolder.Click += menuFileOpenFolder_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(211, 6);
            // 
            // menuCloseFile
            // 
            menuCloseFile.Name = "menuCloseFile";
            menuCloseFile.ShortcutKeys = Keys.Control | Keys.W;
            menuCloseFile.Size = new Size(214, 22);
            menuCloseFile.Text = "&Close File";
            menuCloseFile.Click += menuCloseFile_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(211, 6);
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.ShortcutKeys = Keys.Control | Keys.S;
            menuFileSave.Size = new Size(214, 22);
            menuFileSave.Text = "Save File";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(toolStripContainer);
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YNSRC - Example C# .NET Core Windows Form";
            Load += FormMain_Load;
            toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer.BottomToolStripPanel.PerformLayout();
            toolStripContainer.ContentPanel.ResumeLayout(false);
            toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer.TopToolStripPanel.PerformLayout();
            toolStripContainer.ResumeLayout(false);
            toolStripContainer.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel1.PerformLayout();
            splitContainerMain.Panel2.ResumeLayout(false);
            splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            toolStripFolder.ResumeLayout(false);
            toolStripFolder.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuFile;
        private SplitContainer splitContainerMain;
        private ToolStripMenuItem menuFileOpenFolder;
        private ToolStrip toolStripFolder;
        private ToolStripButton btnSelectFolder;
        private ToolStripButton btnGoUserHome;
        private ToolStripButton btnGoDesktop;
        private TreeView treeViewFolder;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnGoToParentFolder;
        private ToolStripButton btnShowDrives;
        private ToolStripButton btnShowNetwork;
        private ToolStripSeparator toolStripSeparator2;
        private ImageList imageList;
        private ToolStripButton btnRefreshFolder;
        private ToolStripMenuItem menuOpenFile;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuCloseFile;
        private TabControl tabControlFiles;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCloseFile;
        private ToolStripButton btnSaveFile;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem menuFileSave;
    }
}
