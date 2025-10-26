using System;
using Tyuiu.KachulinMV.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task5.V5
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
                // Запрос числа у пользователя
                Console.Write("Введите положительное вещественное число x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                Console.WriteLine("***************************************************************************");

                int result = ds.Calculate(x);
                Console.WriteLine($"Первая цифра дробной части числа {x} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное число");
            }
            catch (ArgumentException ex)
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