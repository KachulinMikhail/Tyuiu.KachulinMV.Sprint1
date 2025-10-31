using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.KachulinMV.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckNumber()
        {
            var ds = new Tyuiu.KachulinMV.Sprint1.Task6.V18.Lib.DataService();

            Assert.IsTrue(ds.CheckNumber("1"));
            Assert.IsTrue(ds.CheckNumber("9"));
            Assert.IsTrue(ds.CheckNumber("10"));
            Assert.IsTrue(ds.CheckNumber("123"));
            Assert.IsTrue(ds.CheckNumber("9999"));
        }

        [TestMethod]
        public void InvalidCheckNumber()
        {
            var ds = new Tyuiu.KachulinMV.Sprint1.Task6.V18.Lib.DataService();

            Assert.IsFalse(ds.CheckNumber(""));
            Assert.IsFalse(ds.CheckNumber("0"));
            Assert.IsFalse(ds.CheckNumber("01"));
            Assert.IsFalse(ds.CheckNumber("12a"));
            Assert.IsFalse(ds.CheckNumber("12.5"));
            Assert.IsFalse(ds.CheckNumber("-5"));
        }
    }
}