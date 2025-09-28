
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KachulinMV.Sprint1.Task1.V4.Lib
{
    public class DataService : ISprint1Task1V4
    {
        public double Calculate(double x, double y)
        {
            return (x + y) / x * y;
        }
    }
}

