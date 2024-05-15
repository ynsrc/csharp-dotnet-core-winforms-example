namespace YNSRC
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.Multiselect = false;
            ofd.FileOk += (s, e) =>
            {
                statusLabel.Text = "Open: " + ofd.FileName;
            };
            ofd.ShowDialog();
        }

        private void menuSaveFile_Click(object sender, EventArgs e)
        {

        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void menuEditCopy_Click(object sender, EventArgs e)
        {

        }

        private void menuEditCut_Click(object sender, EventArgs e)
        {

        }

        private void menuEditPaste_Click(object sender, EventArgs e)
        {

        }

        private void menuEditSelectAll_Click(object sender, EventArgs e)
        {

        }
    }
}
