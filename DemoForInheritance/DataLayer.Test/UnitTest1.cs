using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Model;

namespace DataLayer.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var productDa = new ProductDa();

            productDa.Get(1);

            productDa.GetList();

            productDa.Insert(new Product());
        }
    }
}
