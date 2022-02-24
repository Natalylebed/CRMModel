﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Molel
{
    public class Product
    {
        public string NameProduct { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }
        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return NameProduct;
        }
    }
}
