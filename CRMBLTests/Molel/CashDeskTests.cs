using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBL.Molel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBL.Molel.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        
        [TestMethod()]
        public void CashDeskTest()
        {
            var customerIvan = new Customer()
            {
                NameCustomer = "Ivan",
                Id = 1
            };
            var customerNata = new Customer()
            {
                NameCustomer = "Nata",
                Id = 2
            };
            var sellerIra = new Seller()
            {
                NameSeller = "Ira",
                Id = 20,
            };          
            var product1 = new Product()
            {
                NameProduct = "bike",
                Count = 3,
                Id = 1,
                Price = 5,                            
            };
            var product2 = new Product()
            {
                NameProduct = "skate",
                Count = 4,
                Id = 2,
                Price=4,
            };
            var cart = new Cart(customerIvan);
            cart.AddProductInCart(product1);
            cart.AddProductInCart(product2);

            var cart2 = new Cart(customerNata);
            cart2.AddProductInCart(product1);
            cart2.AddProductInCart(product1);
            cart2.AddProductInCart(product2);

            var cashdeck = new CashDesk(sellerIra, 1);
            Assert.AreEqual(cashdeck.Seller,sellerIra);

            cashdeck.MaxLengthQueue = 10;
            cashdeck.CountOurCustomerQueue = 5;

            cashdeck.AddQueuesCustomer(cart);
            cashdeck.AddQueuesCustomer(cart2);
            Assert.AreEqual(cashdeck.Queues.Count, 2);

            var sumprise=cashdeck.DellQueuesCustomer();
            var sumprise2 = cashdeck.DellQueuesCustomer();
            Assert.AreEqual(cashdeck.Queues.Count, 0);
            Assert.AreEqual(sumprise, 31);
            Assert.AreEqual(sumprise2, 46);
        }

       
    }
}