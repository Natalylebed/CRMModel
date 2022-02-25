using CRMBL.Molel;
using Microsoft.EntityFrameworkCore;

using System.Windows.Forms;

namespace CRMVinForm
{
    public partial class Catalog<T> : Form
        where T:class
    {
        //CRMContext db;
        DbSet<T> set;
        public Catalog(DbSet<T> set/*, CRMContext db*/)
        {
            InitializeComponent();
            dataGridView1.DataSource = set.Local.ToBindingList();
            //this.set = set;
            //this.db = db;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
