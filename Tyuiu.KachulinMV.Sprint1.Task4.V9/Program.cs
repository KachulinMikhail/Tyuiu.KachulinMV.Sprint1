using System;
using Tyuiu.KachulinMV.Sprint1.Task4.V9.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            try
            {
                Console.Write("Введите значение x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значение y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                Console.WriteLine("***************************************************************************");

                double result = ds.Calculate(x, y);
                Console.WriteLine($"Результат: {result:F3}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное число");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}