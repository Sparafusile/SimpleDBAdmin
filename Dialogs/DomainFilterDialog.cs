using System;
using System.Windows.Forms;

namespace SimpleDBAdmin
{
    public partial class DomainFilterDialog : Form
    {
        public string DomainFilter { get; private set; }

        public DomainFilterDialog( string Name = null )
        {
            InitializeComponent();
            this.DomainFilter = Name;
            this.NameText.Text = Name ?? string.Empty;
        }

        private void OkButton_Click( object sender, EventArgs e )
        {
            this.DomainFilter = this.NameText.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
