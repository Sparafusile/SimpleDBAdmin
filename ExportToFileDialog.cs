using System.Windows.Forms;

namespace SimpleDBAdmin
{
    public partial class ExportToFileDialog : Form
    {
        private Main Main { get; set; }

        public ExportToFileDialog( Main Main )
        {
            InitializeComponent();
            this.Main = Main;
            this.rowDelimiter.SelectedIndex = 0;
        }

        private void browseButton_Click( object sender, System.EventArgs e )
        {
            var d = new SaveFileDialog
            {
                DefaultExt = "csv",
                CheckPathExists = true,
                Filter = @"CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
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

            this.Main.ExportDomainToFile
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
