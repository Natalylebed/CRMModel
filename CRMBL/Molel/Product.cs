using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Molel
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public decimal Price { get; set; }
        
        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return NameProduct;
        }
        public override int GetHashCode()
        {
            var Hachcod = Id;
            return Hachcod;
        }
        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return Id.Equals(product.Id);
            }
            return false;
        }



    }
}
