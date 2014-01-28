using System.Windows.Forms;

namespace SimpleDBAdmin
{
    public partial class ExportDialog : Form
    {
        private string Domain { get; set; }

        public ExportDialog( string Domain )
        {
            InitializeComponent();
            this.Domain = Domain;
        }

        private void browseButton_Click( object sender, System.EventArgs e )
        {
            var d = new SaveFileDialog
            {
                CheckPathExists = true,
                DefaultExt = "csv",
            };

            if( d.ShowDialog() != System.Windows.Forms.DialogResult.OK ) return;
            this.targetFile.Text = d.FileName;
        }

        private void exportButton_Click( object sender, System.EventArgs e )
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click( object sender, System.EventArgs e )
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
