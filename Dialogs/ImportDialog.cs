using System.Windows.Forms;

namespace SimpleDBAdmin
{
    public partial class ImportDialog : Form
    {
        public ImportDialog( SimpleDBContext db, string Domain, bool File = true )
        {
            InitializeComponent();
        }
    }
}
