using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint1.Task2.V2.Lib;

namespace Tyuiu.YangolenkoDS.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 60;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(1.047, Math.Round(res,3));
        }
    }
}
