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
            var sellerIra = new Seller()
            {
                NameSeller = "Ira",
                Id = 20,
            };
            //var sellerIra = new Seller()
            //{
            //    NameSeller = "Ira",
            //    Id = 20,
            //};
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
            var cashdeck = new CashDesk(sellerIra, 1);
            Assert.AreEqual(cashdeck.Seller,sellerIra);

            cashdeck.MaxLengthQueue = 10;
            cashdeck.CountOurCustomerQueue = 5;
            cashdeck.AddQueuesCustomer(cart, cashdeck);
            Assert.AreEqual(cashdeck.Queues.Count, 1);

            var sumprise=cashdeck.DellQueuesCustomer();
          Assert.AreEqual(sumprise, 31);
        }

        [TestMethod()]
        public void AddQueuesCustomerTest()
        {
           
            Assert.Fail();
        }

        [TestMethod()]
        public void DellQueuesCustomerTest()
        {
            Assert.Fail();
        }
    }
}