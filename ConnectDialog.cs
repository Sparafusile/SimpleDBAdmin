using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SimpleDBAdmin
{
    public partial class ConnectDialog : Form
    {
        private Main Main { get; set; }
        private List<AwsCredentials> Credentials { get; set; }

        public ConnectDialog( Main Main, List<AwsCredentials> Credentials )
        {
            this.Main = Main;
            this.Credentials = Credentials;
            
            InitializeComponent();

            if( this.Credentials == null ) return;

            this.nickname.Items.Clear();
            this.awsKey.Text = string.Empty;
            this.awsSecretKey.Text = string.Empty;
            foreach( var c in this.Credentials )
            {
                this.nickname.Items.Add( c.Name );
            }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.button1.Text = @"Please wait...";
            this.button1.Enabled = false;
            this.Main.Authorize( new AwsCredentials
            {
                Name = this.nickname.Text,
                Key = this.awsKey.Text,
                Secret = this.awsSecretKey.Text,
                ServiceUrl = this.serviceUrl.Text
            } );
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void nickname_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( this.Credentials == null ) return;
            var c = this.Credentials.FirstOrDefault( m => m.Name.Equals( this.nickname.Text, StringComparison.OrdinalIgnoreCase ) );
            if( c == null ) return;

            this.awsKey.Text = c.Key;
            this.awsSecretKey.Text = c.Secret;
            this.serviceUrl.Text = c.ServiceUrl;
        }
    }
}
