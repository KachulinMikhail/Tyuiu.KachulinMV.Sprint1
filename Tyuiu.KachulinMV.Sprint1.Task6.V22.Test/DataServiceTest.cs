using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.KachulinMV.Sprint1.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Тест 1
            double x1 = 0.5;
            double y1 = 0.3;
            double wait1 = (1 - Math.Tan(0.5)) * 9 + Math.Cos(0.5 - 0.3);
            wait1 = Math.Round(wait1, 3);
            double result1 = ds.Calculate(x1, y1);
            Assert.AreEqual(wait1, result1);

            // Тест 2
            double x2 = 1.0;
            double y2 = 0.5;
            double wait2 = (1 - Math.Tan(1.0)) * 9 + Math.Cos(1.0 - 0.5);
            wait2 = Math.Round(wait2, 3);
            double result2 = ds.Calculate(x2, y2);
            Assert.AreEqual(wait2, result2);
        }
    }
}