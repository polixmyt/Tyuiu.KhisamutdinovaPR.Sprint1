using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        // Вычисляет значение по формуле: sqrt(x + 1) / x
        public double Calculate(double x)
        {
            double result = Math.Sqrt(x + 1) / x;
            return Math.Round(result, 3);
        }

        public double Calculate(double x, double y)
        {
            double result = Math.Sqrt(x + 1) / x;
            return Math.Round(result, 3);
        }
    }
}