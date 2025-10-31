using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KachulinMV.Sprint1.Task6.V22
{
    public class DataService: ISprint1Task7V22
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