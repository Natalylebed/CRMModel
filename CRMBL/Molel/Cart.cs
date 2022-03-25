using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRMBL.Molel
{
    public class Cart: IEnumerable
    {
        public int ID { get; set; }

        public Customer CustomerInCart { get; set; }

      
        public Dictionary< Product, int> catalogProducts { get; set; }

        public Cart(Customer customer)
        {
            CustomerInCart = customer;
            catalogProducts = new Dictionary<Product, int>();
            
        }
        public void AddProductInCart(Product product)
        {
            if (catalogProducts.TryGetValue(product, out int count))
            {
              
                catalogProducts[product] =product.Count+count;  //count+1
            }
            else
            {
                catalogProducts.Add(product,product.Count);
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var product in catalogProducts.Keys)
            {
                for (int i = 0; i < catalogProducts[product]; i++)
                {
                    yield return product;
                }
            }

        }
        public List<Product> GetAll(Cart cart)
        {
            var result = new List<Product>();

            foreach(Product product in cart)
            {
                var product1 = new Product()
                {
                    NameProduct = product.NameProduct,
                    Count = 1,
                    Id = product.Id,
                    Price = product.Price,
                    Sells = product.Sells
                };
                    result.Add(product1);
                              
            }
            return result;

        }
        public List<Product> GetAll()
        {
            var result = new List<Product>();

            foreach (Product product in catalogProducts.Keys)
            {
                var product1 = new Product()
                {
                    NameProduct = product.NameProduct,
                    Count = 1,
                    Id = product.Id,
                    Price = product.Price,
                    Sells = product.Sells
                };
                result.Add(product1);

            }
            return result;

        }
        public decimal SumPrise => GetAll().Sum(p => p.Price);




    }
}
