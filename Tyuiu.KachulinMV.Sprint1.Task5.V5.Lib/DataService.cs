
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KachulinMV.Sprint1.Task5.V5.Lib
{
    public class DataService: ISprint1Task5V5
    {
        public int Calculate(double x)
        {

            if (x <= 0)
            {
                throw new ArgumentException("Число должно быть положительным");
            }

            double fractionalPart = x - Math.Truncate(x);

            if (fractionalPart == 0)
            {
                return 0;
            }

            double firstDigit = fractionalPart * 10;

            int result = (int)Math.Truncate(firstDigit);

            return Math.Abs(result);
        }
    }
}

