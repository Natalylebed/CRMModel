using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBL.Molel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBL.Molel.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void AddProductInCartTest()
        {
            //arrange
            var customerIvan = new Customer()
            {
                NameCustomer = "Ivan",
                Id = 1
            };
            var product1 = new Product()
            {
                NameProduct = "bike",
                Count = 3,
                Id = 1
            };
            var product2 = new Product()
            {
                NameProduct = "bike",
                Count = 3,
                Id = 1
            };
            var cart = new Cart(customerIvan);
            //act
            cart.AddProductInCart(product1);
            cart.AddProductInCart(product2);

            //assert
            var actual = cart.catalogProducts.TryGetValue(product1, out int count);
            var expected = product1.Count+product2.Count;

            Assert.AreEqual(count, expected);
        }

        [TestMethod()]
        public void GetAll()
        {//arrange
            var customerIvan = new Customer()
            {
                NameCustomer = "Ivan",
                Id = 1
            };
            var product1 = new Product()
            {
                NameProduct = "bike",
                Count = 3,
                Id = 1,
                Price=2
            };
            var product2 = new Product()
            {
                NameProduct = "skate",
                Count = 4,
                Id = 2,
                Price=3
            };
            var cart = new Cart(customerIvan);
            //act
            cart.AddProductInCart(product2);
            cart.AddProductInCart(product1);

            var actual = cart.GetAll(cart);
            var expected =7;

            //var actual2 = cart.GetEnumerator();
            //var expected2 = 7;
            
          
           

            //Assert.AreEqual(actual.Count, expected);
            //Assert.AreEqual(actual2, expected2);
        }


    }
}