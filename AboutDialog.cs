using System;
using System.Windows.Forms;

namespace SimpleDBAdmin
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            this.lblVersion.Text = @"Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
