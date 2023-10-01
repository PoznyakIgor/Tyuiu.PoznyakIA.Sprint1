using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint1.Task6.V12.Lib; 

namespace Tyuiu.PoznyakIA.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string value = " подушка очень мягкая подушка ";
            DataService ds = new DataService();
            Boolean res = ds.CheckLastWordRepetiton(value);
            Boolean wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
