
using Tyuiu.KachulinMV.Sprint1.Task1.V4.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = (2 + 3) / 2 * 3;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(res, 7.5);
        }
    }
}