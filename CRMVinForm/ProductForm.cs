using CRMBL.Molel;
using System;

using System.Windows.Forms;

namespace CRMVinForm
{
    public partial class ProductForm : Form
    {
        public Product ProductAdd { get; set; }
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ProductAdd = new Product()
            {
                NameProduct = textBox1.Text,
                Price =numericUpDown1.Value,
                Count=(int)numericUpDown2.Value
            };
            Close();

        }
    }
}
