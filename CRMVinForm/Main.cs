using System;
using System.Windows.Forms;
using CRMBL.Molel;

namespace CRMVinForm
{
    public partial class Main : Form
    {
        CRMContext db;
      // Customer customer;
        public Main()
        {
            InitializeComponent();
            db = new CRMContext();
        }       
       
        private void SellerStripMenuItem1_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers,db);
            catalogSeller.Show();
        }
        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }       
        private void CkeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(db.Checks, db);
            catalogCheck.Show();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Producs, db);
            catalogProduct.Show();

        }

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
          
            if (form.ShowDialog()== DialogResult.OK)
            {
                db.Customers.Add(form.customerAdd);
                db.SaveChanges();
            }
          
        }
        private void AddSellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
           
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.AddSeller);
                db.SaveChanges();
            }
        }

        private void AddProductToolStripMene_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                db.Producs.Add(form.ProductAdd);
                db.SaveChanges();
            }
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void StartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var model = new Model();
            model.Show();

        }
    }

       
    }
