using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        // ДОЛЖНО БЫТЬ ИМЕННО ТАК:
        public double ConvertMToKm(int value)
        {
            double km = value / 1000.0;
            return Math.Round(km, 3);
        }
    }
}