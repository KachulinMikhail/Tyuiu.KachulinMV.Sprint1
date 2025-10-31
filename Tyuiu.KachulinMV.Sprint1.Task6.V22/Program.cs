using System;

namespace Tyuiu.KachulinMV.Sprint1.Task6.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите значение x (в радианах):");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y (в радианах):");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
    }
}