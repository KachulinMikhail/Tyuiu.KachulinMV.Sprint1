using System;
using Tyuiu.KachulinMV.Sprint1.Task6.V18.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Качулин М.В. | ИИПБ-23-3                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка   *");
            Console.WriteLine("* является символьным представлением натурального числа.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст для проверки:");
            string input = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool isNaturalNumber = ds.CheckNumber(input);

            if (isNaturalNumber)
            {
                Console.WriteLine($"Строка \"{input}\" является натуральным числом.");
            }
            else
            {
                Console.WriteLine($"Строка \"{input}\" НЕ является натуральным числом.");
            }

            Console.ReadKey();
        }
    }
}