using CRMBL.Molel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.set = set;
            //this.db = db;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
