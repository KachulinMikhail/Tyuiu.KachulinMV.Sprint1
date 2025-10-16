using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KachulinMV.Sprint1.Task2.V19.Lib

{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            return Math.Abs(x2 - x1) == Math.Abs(y2 - y1);
        }


    }
}