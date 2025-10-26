using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KachulinMV.Sprint1.Task4.V9.Lib
{
    public class DataService: ISprint1Task4V9
    {
        public double Calculate(double x, double y)
        {

            if (x <= 0 || y <= 0)
            {
                throw new ArgumentException("x и y должны быть положительными числами (ln(xy) определен только для xy > 0)");
            }

            double numerator = Math.Log(x * y);  
            double denominator = x - Math.Sqrt(1 + Math.Pow(y, 2));  

            if (denominator == 0)
            {
                throw new DivideByZeroException("Деление на ноль (знаменатель равен 0)");
            }

            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}