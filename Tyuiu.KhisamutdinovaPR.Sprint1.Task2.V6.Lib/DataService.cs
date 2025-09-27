using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task2.V6.Lib
{
    // Предполагаемый интерфейс: ISprint1Task2V6
    public class DataService : ISprint1Task2V6
    {
        /// <summary>
        /// Переводит метры в километры с округлением до 3 знаков
        /// </summary>
        public double ConvertToKm(int meters)
        {
            double km = meters / 1000.0;
            return Math.Round(km, 3);
        }
    }
}