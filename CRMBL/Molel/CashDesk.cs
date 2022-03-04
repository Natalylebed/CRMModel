using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBL.Molel
{
    public class CashDesk
    {
        public Seller Seller { get; set; }
        public int NumberCashDesk { get; set; }
        public Queue<Cart> Queues { get; set; }

        public int MaxLengthQueue { get; set; }
        public int ExitWhithoutSellCustomer { get; set; }
        public CashDesk(Seller seller, int number)
 
        
        {
            NumberCashDesk = number;
            Seller = seller;
            Queues = new Queue<Cart>();
        }
        public void AddInQueuesCustomer()
        {

        }
    }
}
