using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KachulinMV.Sprint1.Task2.V6.Lib
{
    public class DataService: ISprint1Task2V6
    {
        public double ConvertMetersToKilometers(int meters)
        {
            // 1 километр = 1000 метров
            double kilometers = meters / 1000.0;

            // Округляем до 3 знаков после запятой
            return Math.Round(kilometers, 3);
        }

        public double ConvertMToKm(int value)
        {
            throw new NotImplementedException();
        }
    }
}