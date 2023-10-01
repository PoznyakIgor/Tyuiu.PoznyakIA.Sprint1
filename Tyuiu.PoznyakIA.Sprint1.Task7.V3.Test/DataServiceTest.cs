using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint1.Task7.V3.Lib;

namespace Tyuiu.PoznyakIA.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 3.964;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

            
        }
    }
}
