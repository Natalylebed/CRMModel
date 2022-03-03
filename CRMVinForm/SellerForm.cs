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
        public SellerForm(Seller seller):this()
        {
            AddSeller = seller;
            AddSeller.NameSeller = textBox1.Text;
        }

        private void SellerAdd_Click(object sender, System.EventArgs e)
        {
            var p = AddSeller ?? new Seller();

            p.NameSeller = textBox1.Text;

            Close();
        }
    }
}
