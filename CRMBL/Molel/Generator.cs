using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBL.Molel
{
    public class Generator
    {
        public List<Product> ProductsinGenerator { get; set; }
        public List<Seller> SellerInGenerator { get; set; }
        public List<Customer> CustomerInGenerator { get; set; }        

        Random random = new Random();
        public Generator()
        {
            ProductsinGenerator = new List<Product>();
            SellerInGenerator = new List<Seller>();
            CustomerInGenerator = new List<Customer>();
        }
        public List<Customer> GetNewCustomers(int CustomerCount)
        {
            for (int c = 0; c < CustomerCount; c++)
            {
                var customer = new Customer()
                {
                    NameCustomer = RandomString(),
                    Id = c,
                };
                CustomerInGenerator.Add(customer);
            }
            return CustomerInGenerator;
        }
        public List<Product> GetNewProduct(int ProductCount)
        {
            for (int p = 0; p < ProductCount; p++)
            {
                var product = new Product()
                {
                    NameProduct = RandomString(),
                    Price = random.Next(5, 10000),
                    Id = p,
                    Count = random.Next(1, 4)
                };
                ProductsinGenerator.Add(product);
            }
            return ProductsinGenerator;
        }
        public List<Seller> GetNewSeller(int SellerCount)
        {
            for (int s = 0; s < SellerCount; s++)
            {
                var seller = new Seller()
                {
                    NameSeller = RandomString(),
                    Id = s,
                };
                SellerInGenerator.Add(seller);

            }
            return SellerInGenerator;
        }
        private static string RandomString()
        {
            var name = Guid.NewGuid().ToString().Substring(1, 6);
            return name;
        }
    }

}
