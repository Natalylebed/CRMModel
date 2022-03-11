using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBL.Molel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBL.Molel.Tests
{
    [TestClass()]
    public class ModelShopTests
    {
        [TestMethod()]
        public void ModelShopTest()
        {
            
           var modelshop = new ModelShop(10, 1000);
           modelshop.Start(3,1,3,2);


            Assert.Fail();
        }

        [TestMethod()]
        public void StartTest()
        {
            Assert.Fail();
        }

       
    }
}