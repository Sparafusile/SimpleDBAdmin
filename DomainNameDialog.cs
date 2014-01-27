using System;
using System.Windows.Forms;

namespace SimpleDBAdmin
{
    public partial class DomainNameDialog : Form
    {
        public string DomainName { get; private set; }

        public DomainNameDialog( string Name = null )
        {
            InitializeComponent();
            this.DomainName = Name;
            this.NameText.Text = Name ?? string.Empty;
        }

        private void OkButton_Click( object sender, EventArgs e )
        {
            this.DomainName = this.NameText.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
