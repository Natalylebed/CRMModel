﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var cart = new Cart(customerIvan);
            //act
            cart.AddProductInCart(product1);

            //assert
            var actual = cart.catalogProducts.TryGetValue(product1, out int count);
            var expected = product1.Count;

            Assert.AreEqual(count, expected);
        }

        [TestMethod()]
        public void GetEnumeratorTest()
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
                Id = 1
            };
            var product2 = new Product()
            {
                NameProduct = "bike2",
                Count = 4,
                Id = 2
            };
            var cart = new Cart(customerIvan);
            //act
            cart.AddProductInCart(product1);
            cart.AddProductInCart(product2);

            var actual = cart.GetAll(cart);
            var expected = new List<Product>();
            for (int i = 0; i < product2.Count; i++)
            {
                expected.Add(product2);
             }
            for (int i = 0; i < product1.Count; i++)
            {
                expected.Add(product1);
            }
          
           

            Assert.AreEqual(actual.Count, expected.Count);
        }


    }
}