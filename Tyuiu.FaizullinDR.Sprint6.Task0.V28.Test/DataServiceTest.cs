using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FaizullinDR.Sprint6.Task0.V28.Lib;

namespace Tyuiu.FaizullinDR.Sprint6.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            Assert.AreEqual(169.89,res);
        }
    }
}
