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
        //[TestMethod()]
        //public void ModelShopTest()
        //{
            
        //   var modelshop = new ModelShop(10, 1000);
        //   modelshop.Start(3,1,3,2);
        //    var actual1 = modelshop.CartInModel.Count;
        //    var actual2 = modelshop.CashDesksInModel[0].Queues.Count;

        //    Assert.AreEqual(0, actual1);
        //    Assert.AreEqual(3, actual2);
        //}
        [TestMethod()]
        public void ModelShopTest()
        {

            var modelshop = new ModelShop(10, 1000,10,10);
            modelshop.Start(3, 1, 3);
            var actual1 = modelshop.CartInModel.Count;
            var actual2 = modelshop.CashDesksInModel[0].Queues.Count;

            Assert.AreEqual(0, actual1);
            Assert.AreEqual(0, actual2);
        }




    }
}