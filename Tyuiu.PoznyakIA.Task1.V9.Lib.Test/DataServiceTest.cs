using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PoznyakIA.Sprint1.Task1.V9.Lib;

namespace Tyuiu.PoznyakIA.Sprint1.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Double x = 1.0;
            Double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);

        }
    }
}
