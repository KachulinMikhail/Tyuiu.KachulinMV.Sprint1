using Tyuiu.KachulinMV.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = 7.89;
            int wait = 8;
            int result = ds.Calculate(x);
            Assert.AreEqual(wait, result);
        }
    }
}