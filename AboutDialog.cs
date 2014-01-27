using System;
using System.Windows.Forms;

namespace SimpleDBAdmin
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
