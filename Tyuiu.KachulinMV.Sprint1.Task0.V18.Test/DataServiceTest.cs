using System;

using Tyuiu.KachulinMV.Sprint1.Task0.V18.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
