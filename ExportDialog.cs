using System.Windows.Forms;

namespace SimpleDBAdmin
{
    public partial class ExportDialog : Form
    {
        private Main Main { get; set; }

        public ExportDialog( Main Main )
        {
            InitializeComponent();
            this.Main = Main;
            this.rowDelimiter.SelectedIndex = 0;
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
            string rowDelim, colDelim;
            switch( this.rowDelimiter.Text )
            {
                case "Unix":
                    rowDelim = "\n";
                    break;

                default:
                    rowDelim = "\r\n";
                    break;
            }

            switch( this.columnDelimiter.Text )
            {
                case "Comma":
                    colDelim = ",";
                    break;

                case "Tab":
                    colDelim = "\t";
                    break;

                case "Pipe":
                    colDelim = "|";
                    break;

                default:
                    colDelim = this.columnDelimiter.Text;
                    break;
            }

            this.Main.ExportDomain
            (
                this.targetFile.Text,
                rowDelim,
                colDelim,
                this.textQualifier.Text,
                this.escapeCharacter.Text
            );

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
