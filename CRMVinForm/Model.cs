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
    public partial class Model : Form
    {
        ModelShop modelShop = new ModelShop(10,1000,300,10);
       
        
        public Model()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var cashBox = new List<CachBoxView>();
            for (int i = 0; i < modelShop.CashDesksInModel.Count; i++)
            {
                var cachBoxView = new CachBoxView(modelShop.CashDesksInModel[i], i, 10, 26 * i);
                cashBox.Add(cachBoxView);
                Controls.Add(cachBoxView.CashDeskName);
                Controls.Add(cachBoxView.SunChek);
                Controls.Add(cachBoxView.QueueLength);
                Controls.Add(cachBoxView.CountExitWhithoutSellCustomer);
                
            }
            modelShop.Start(800, 2, 10);


        }

        private void Model_FormClosing(object sender, FormClosingEventArgs e)
        {
            modelShop.Stop();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            modelShop.CustomerSpeed = (int)numericUpDown1.Value;
        }

        private void Model_Load(object sender, EventArgs e)
        {
            
            numericUpDown1.Value = modelShop.CustomerSpeed;
            numericUpDown2.Value = modelShop.CashDeskSpeed;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            modelShop.CashDeskSpeed = (int)numericUpDown2.Value;

        }
    }
}
