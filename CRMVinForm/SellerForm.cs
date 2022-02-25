using CRMBL.Molel;

using System.Windows.Forms;

namespace CRMVinForm
{
    public partial class SellerForm : Form
    {
        public Seller AddSeller { get; set; }
        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerAdd_Click(object sender, System.EventArgs e)
        {
            AddSeller = new Seller()
            {
                NameSeller = textBox1.Text

            };
            Close();
        }
    }
}
