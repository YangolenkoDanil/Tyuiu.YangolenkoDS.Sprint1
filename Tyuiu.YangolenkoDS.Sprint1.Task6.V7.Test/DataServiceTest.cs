using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint1.Task6.V7.Lib;

namespace Tyuiu.YangolenkoDS.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "привет мир";
            string res = ds.DeleteLastLetter(strTest);
            Assert.AreEqual("приве ми", res);
        }
    }
}
