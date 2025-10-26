using Tyuiu.KachulinMV.Sprint1.Task4.V9.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 0.195;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 2.5;
            double wait = 0.386;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidX_ShouldThrowException()
        {
            DataService ds = new DataService();
            ds.Calculate(-1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidY_ShouldThrowException()
        {
            DataService ds = new DataService();
            ds.Calculate(2, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionByZero_ShouldThrowException()
        {
            DataService ds = new DataService();
            ds.Calculate(3.16227766, 3);
        }
    }
}