using Tyuiu.KachulinMV.Sprint1.Task2.V19.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.KachulinMV.Sprint1.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                          *");
            Console.WriteLine("*********************************************************************************************");

            double x1;
            double x2;
            double y1;
            double y2;

            Console.WriteLine("Введите значение X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
 

            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                 *");
            Console.WriteLine("**********************************************************************************************");

            bool result = ds.ElephCanMove(x1, y1, x2, y2);
            Console.WriteLine($"Слон может переместиться с ({x1},{y1}) на ({x2},{y2}): {result}");

            Console.ReadKey();

        }
    }
}















