using CRMBL.Molel;
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
    public partial class CustomerForm : Form
    {
        public Customer customerAdd { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }
        public CustomerForm(Customer customer):this()
        {
            customerAdd = customer;
            customerAdd.NameCustomer = textBox1.Text;
        }
       
        private void ButtonAddCustomer_Clik(object sender, EventArgs e)
        {
            var p = customerAdd ?? new Customer();
            p.NameCustomer = textBox1.Text;            
            Close();

        }
    }
}
