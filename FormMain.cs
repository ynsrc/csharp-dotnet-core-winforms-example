namespace YNSRC
{
    public partial class FormMain : Form
    {
        string currentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        Dictionary<string, TabPage> openedFiles = new Dictionary<string, TabPage>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void recursiveAddSubFoldersAndFiles(TreeNode treeNode, string directory, int depth = 3)
        {
            if (depth == 0) return;

            try
            {
                foreach (var subDirectory in Directory.GetDirectories(directory))
                {
                    try
                    {
                        var subRoot = treeNode.Nodes.Add(Path.GetFileName(subDirectory));
                        subRoot.ImageKey = "folder";
                        subRoot.Tag = subDirectory;
                        recursiveAddSubFoldersAndFiles(subRoot, subDirectory, depth - 1);
                    }
                    catch { /* ignore */ }
                }

                foreach (var subFile in Directory.GetFiles(directory))
                {
                    try
                    {
                        var subRoot = treeNode.Nodes.Add(Path.GetFileName(subFile));
                        subRoot.ImageKey = "file";
                        subRoot.Tag = subFile;
                    }
                    catch { /* ignore */ }
                }
            }
            catch { /* ignore */ }
        }

        private void changeDirectory(string? newDirectory)
        {
            if (newDirectory == null)
            {
                treeViewFolder.Nodes.Clear();
                var root = treeViewFolder.Nodes.Add("Computer");
                root.Tag = null;
                foreach (var drive in DriveInfo.GetDrives())
                {
                    var subNode = root.Nodes.Add(drive.Name);
                    subNode.ImageKey = "drive";
                    subNode.Tag = drive.Name;
                }
                root.Expand();

                statusLabel.Text = "All Drivers";
            }
            else
            {
                currentDirectory = newDirectory;
                treeViewFolder.Nodes.Clear();
                string name = Path.GetFileName(currentDirectory);
                if (string.IsNullOrEmpty(name))
                {
                    name = Path.GetPathRoot(currentDirectory) ?? "/";
                }
                var root = treeViewFolder.Nodes.Add(name);
                root.Tag = name;
                recursiveAddSubFoldersAndFiles(root, currentDirectory);
                root.Expand();

                statusLabel.Text = currentDirectory;
            }
        }

        private void openFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                if (openedFiles.ContainsKey(filePath))
                {
                    tabControlFiles.SelectedTab = openedFiles[filePath];
                }
                else
                {
                    var fileTab = new TabPage(Path.GetFileName(filePath));
                    fileTab.Tag = filePath;
                    var textBox = new TextBox();
                    textBox.Multiline = true;
                    textBox.Dock = DockStyle.Fill;
                    textBox.Text = File.ReadAllText(filePath);
                    if (textBox.TextLength > 0)
                    {
                        textBox.SelectionStart = 0;
                        textBox.SelectionLength = 0;
                    }
                    textBox.ScrollBars = ScrollBars.Both;
                    fileTab.Controls.Add(textBox);
                    tabControlFiles.TabPages.Add(fileTab);
                    tabControlFiles.SelectedTab = fileTab;
                    openedFiles.Add(filePath, fileTab);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            changeDirectory(currentDirectory);
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.SelectedPath = currentDirectory;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                changeDirectory(fbd.SelectedPath);
            }
        }

        private void btnRefreshFolder_Click(object sender, EventArgs e)
        {
            changeDirectory(currentDirectory);
        }

        private void btnGoToParentFolder_Click(object sender, EventArgs e)
        {
            var parent = Directory.GetParent(currentDirectory);
            if (parent != null)
            {
                changeDirectory(parent.FullName);
            }
            else
            {
                changeDirectory(null);
            }
        }

        private void treeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = treeViewFolder.SelectedNode;
            if (selectedNode == null) return;

            var selectedPath = selectedNode.Tag?.ToString() ?? "";

            if (selectedNode.Nodes.Count == 0)
            {
                if (!string.IsNullOrEmpty(selectedPath) && Directory.Exists(selectedPath))
                {
                    recursiveAddSubFoldersAndFiles(selectedNode, selectedPath, 2);
                    selectedNode.Expand();
                }
            }

            statusLabel.Text = selectedPath;
        }

        private void treeViewFolder_DoubleClick(object sender, EventArgs e)
        {
            var selectedPath = treeViewFolder.SelectedNode?.Tag?.ToString() ?? "";

            if (!string.IsNullOrEmpty(selectedPath))
            {
                if (Directory.Exists(selectedPath))
                {
                    changeDirectory(selectedPath);
                }
                else if (File.Exists(selectedPath))
                {
                    openFile(selectedPath);
                }
            }
        }

        private void btnGoDesktop_Click(object sender, EventArgs e)
        {
            changeDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
        }

        private void btnGoUserHome_Click(object sender, EventArgs e)
        {
            changeDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        }

        private void btnShowDrives_Click(object sender, EventArgs e)
        {
            changeDirectory(null);
        }

        private void btnShowNetwork_Click(object sender, EventArgs e)
        {
            changeDirectory(Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts));
        }

        private void menuFileOpenFolder_Click(object sender, EventArgs e)
        {
            btnSelectFolder_Click(null, null);
        }

        private void menuOpenFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            ofd.Multiselect = true;
            ofd.FileOk += (s, e) =>
            {
                foreach (var fileName in ofd.FileNames)
                {
                    openFile(fileName);
                }
            };
            ofd.ShowDialog();
        }

        private void menuCloseFile_Click(object sender, EventArgs e)
        {
            var tabPage = tabControlFiles.SelectedTab;

            if (tabPage != null)
            {
                var fileName = tabPage.Tag?.ToString() ?? "";
                tabControlFiles.TabPages.Remove(tabPage);

                if (openedFiles.ContainsKey(fileName))
                {
                    openedFiles.Remove(fileName);
                }
            }
        }

        private void btnCloseFile_Click(object sender, EventArgs e)
        {
            menuCloseFile_Click(null, null);
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not added yet to prevent mistake file corruptions!");
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            menuFileSave_Click(null, null);
        }
    }
}
