using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Molel
{
    public class Customer
    {
        public int Id { get; set; }
        public string NameCustomer { get; set; }       

        public virtual ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return NameCustomer;
        }
    }
}
