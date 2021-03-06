using CRMBL.Molel;
using Microsoft.EntityFrameworkCore;

using System.Windows.Forms;

namespace CRMVinForm
{
    public partial class Catalog<T> : Form
        where T:class
    {
        CRMContext db;
        DbSet<T> set;
        public Catalog(DbSet<T> set, CRMContext db)
        {
            InitializeComponent();
         
            dataGridView1.DataSource = set.Local.ToBindingList();
            this.set = set;
            set.Load();
            this.db = db;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCatalog_Click(object sender, System.EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            
            if (typeof(T) ==typeof(Product))
                {
                //var product=set.Find(id) as Product;
                //if(product != null)
                //{
                //    var form = new ProductForm(product);
                //}
                
                    //db.Producs.Add(set.p);
                    //db.SaveChanges();
                
                }
               else if (typeof(T) == typeof(Customer))
                {

                }
               else if (typeof(T) == typeof(Seller))
                {

                }
            }

        private void ChangeCatalog_Click(object sender, System.EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product))
            {
                var product = set.Find(id) as Product;
                if (product != null)
                {
                    var form = new ProductForm(product);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.ProductAdd;
                        db.SaveChanges();
                        dataGridView1.Update();
                    }
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                var customer = set.Find(id) as Customer;
                if (customer != null)
                {
                    var form = new CustomerForm(customer);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        customer = form.customerAdd;
                        db.SaveChanges();
                        dataGridView1.Update();
                    }
                }

            }
            else if (typeof(T) == typeof(Seller))
            {
                var seller = set.Find(id) as Seller;
                if (seller != null)
                {
                    var form = new SellerForm(seller);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        seller = form.AddSeller;
                        db.SaveChanges();
                        dataGridView1.Update();
                    }
                }

            }
        }

        

        private void DeleteCatalog_Click(object sender, System.EventArgs e)
        {

        }
    }
    
}
