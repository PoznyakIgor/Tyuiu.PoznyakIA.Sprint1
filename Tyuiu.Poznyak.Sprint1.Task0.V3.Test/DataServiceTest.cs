using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint1.Task0.V3.Lib;

namespace Tyuiu.PoznyakIA.Sprint1.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServiceTest ds = new DataServiceTest();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}
