using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Molel
{
    public class Check
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int SellerId { get; set; }

        public virtual Seller Seller { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"{Id} от {Date.ToString("dd.MM.yy hh:mm:ss")}";
        }


    }
}

