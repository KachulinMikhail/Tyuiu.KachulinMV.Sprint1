using Tyuiu.KachulinMV.Sprint1.Task0.V18.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task0.V18
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 Выполнил: Качулин М.В. ИСПб-25-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Базовые навыки в C#                                              *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнил: Качулин Михаил Владимирович. | ИСПб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 9*(6/2*3)/9/3          *");
            Console.WriteLine("* и печатает результат на экране                                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* 9*(6/2*3)/9/3                                                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine(ds.Calculate());
            Console.ReadLine();


        }
    }
}















