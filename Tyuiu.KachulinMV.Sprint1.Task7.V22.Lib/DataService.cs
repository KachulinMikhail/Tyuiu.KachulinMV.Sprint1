using System;

namespace Tyuiu.KachulinMV.Sprint1.Task6.V22
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            double tanX = Math.Tan(x);
            double cosDiff = Math.Cos(x - y);
            double result = (1 - tanX) * 9 + cosDiff;

            return Math.Round(result, 3);
        }
    }
}