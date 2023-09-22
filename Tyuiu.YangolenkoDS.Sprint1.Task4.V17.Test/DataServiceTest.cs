using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint1.Task4.V17.Lib;

namespace Tyuiu.YangolenkoDS.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 110;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.1, res);
        }
    }
}
