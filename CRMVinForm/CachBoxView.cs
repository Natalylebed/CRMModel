using CRMBL.Molel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMVinForm
{
    class CachBoxView
    {
        public CashDesk cashDesk;
        public Label CashDeskName { get; set; }
        public NumericUpDown SunChek { get; set; }
        public ProgressBar QueueLength { get; set; }

        public Label CountExitWhithoutSellCustomer { get; set; }
        public CachBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;
           CashDeskName = new Label();
            QueueLength =new ProgressBar();
            CountExitWhithoutSellCustomer = new Label();

           CashDeskName.AutoSize = true;
           CashDeskName.Location = new Point(x, y);
           CashDeskName.Name = "label" + number; 
           CashDeskName.Size = new Size(100, 20);
           CashDeskName.TabIndex = number;
           CashDeskName.Text = $" касса номер {number}";

           CountExitWhithoutSellCustomer.AutoSize = true;
           CountExitWhithoutSellCustomer.Location = new Point(x+420, y);
           CountExitWhithoutSellCustomer.Name = "label2" + number;
           CountExitWhithoutSellCustomer.Size = new Size(100, 20);
           CountExitWhithoutSellCustomer.TabIndex = number;
           CountExitWhithoutSellCustomer.Text = "1 ";

            SunChek = new NumericUpDown();
            SunChek.Location = new Point(x + 150, y);
            SunChek.Name = $"NumericUpDown {number}";
            SunChek.Size = new Size(120, 20);
            SunChek.TabIndex = number;
            SunChek.Maximum = 1000000000000000000;

           QueueLength.Location = new Point(x+310, y);
           QueueLength.Maximum = cashDesk.MaxLengthQueue;
           QueueLength.Name = "progressBar"+number;
           QueueLength.Size = new Size(100, 23);
           QueueLength.TabIndex = number;
           QueueLength.Value = 1;

            cashDesk.CheckClose += CashDesk_CheckClose;
           
        }

        private void CashDesk_CheckClose(object sender, Check e)
        {
            //пробрасываем из асинхронного потока в основной
            SunChek.Invoke((Action)delegate
            {
                SunChek.Value += e.SumChek;
                QueueLength.Value = cashDesk.Count;
                CountExitWhithoutSellCustomer.Text = cashDesk.ExitWhithoutSellCustomer.ToString();
            });
        }
    }
}
