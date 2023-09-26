using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint1.Task3.V9.Lib;

namespace Tyuiu.PoznyakIA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            
 
            
            var res = ds.Calculate();
            Assert.AreEqual(2.3, res);
        }
    }
}
