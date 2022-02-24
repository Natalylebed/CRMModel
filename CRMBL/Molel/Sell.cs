using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Molel
{
    public class Sell
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public int CheckId { get; set; }

        public virtual Check Chek { get; set; }

        public override string ToString()
        {
            return $"{Id} породажа";
        }
    }
}
