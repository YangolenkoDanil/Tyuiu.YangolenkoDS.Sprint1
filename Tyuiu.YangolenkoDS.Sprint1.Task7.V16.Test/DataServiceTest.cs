using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint1.Task7.V16.Lib;

namespace Tyuiu.YangolenkoDS.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            var res = ds.Calculate(x);
            Assert.AreEqual(0.026, Math.Round(res,3));
        }
    }
}
