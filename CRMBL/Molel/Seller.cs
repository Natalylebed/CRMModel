using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Molel
{
    public class Seller
    {
        public string NameSeller { get; set; }

        public int Id { get; set; }

        public virtual ICollection<Check> ChecksInSeller { get; set; }

        public override string ToString()
        {
            return NameSeller;
        }
    }
}
