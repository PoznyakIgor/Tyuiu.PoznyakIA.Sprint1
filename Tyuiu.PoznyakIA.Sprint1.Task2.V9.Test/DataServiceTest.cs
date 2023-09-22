using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint1.Task2.V9.Lib;

namespace Tyuiu.PoznyakIA.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateVolumeCircle(x);
            Assert.AreEqual(33.5146666667, res);
        }
    }
}
