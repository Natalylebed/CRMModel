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
        public ProductForm(Product product) : this()
        {
            ProductAdd=product;
            textBox1.Text = ProductAdd.NameProduct;
            numericUpDown1.Value = ProductAdd.Price;
            numericUpDown2.Value = ProductAdd.Count;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var p = ProductAdd ?? new Product();

            p.NameProduct = textBox1.Text;
            p.Price = numericUpDown1.Value;
            p.Count = (int)numericUpDown2.Value;
           
            Close();

        }
    }
}
