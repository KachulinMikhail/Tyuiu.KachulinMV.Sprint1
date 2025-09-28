using Tyuiu.KachulinMV.Sprint1.Task2.V6.Lib;

namespace Tyuiu.KachulinMV.Sprint1.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title =  ("* Спринт #1 | Выполнил: Качулин М. В. | ИСПб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Качулин Михаил Владимирович | ИСПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя расстояние       *");
            Console.WriteLine("* в метрах и переводит его в километры. Ответ округлить до 3 знаков       *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Запрос данных у пользователя
            Console.Write("Введите расстояние в метрах: ");
            int meters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создание экземпляра класса DataService и вызов метода
            DataService ds = new DataService();
            double kilometers = ds.ConvertMetersToKilometers(meters);

            // Вывод результата
            Console.WriteLine($"Расстояние в километрах: {kilometers} км");

            Console.ReadLine();
        }
    }
}



