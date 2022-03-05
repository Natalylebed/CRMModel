using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CRMBL.Molel
{
    public class Cart
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
                catalogProducts[product] = product.Count+count;  //count+1
            }
            else
            {
                catalogProducts.Add(product,product.Count);
            }
        }
        //public IEnumerator GetEnumerator()
        //{
        //    foreach (var product in catalogProducts.Keys)
        //    {
        //        for (int i=0; i < catalogProducts[product]; i++)
        //        {
        //            yield return product;
        //        }
        //    }                  
           
        //}
        public List<Product> GetAll(Cart cart)
        {
            var result = new List<Product>();

            foreach(var product in cart.catalogProducts.Keys)
            {
                
                for (int i = 0; i < product.Count; i++)
                {
                    result.Add(product);
                }
            }
            return result;

        }

       

    }
}
