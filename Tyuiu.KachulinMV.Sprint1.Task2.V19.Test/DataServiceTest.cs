using System;
using Tyuiu.KachulinMV.Sprint1.Task2.V19.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double x2 = 3;
            double y1 = 2;
            double y2 = 4;
            bool wait = true;
            bool res = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.AreEqual(wait, res);
        }
    }
}
