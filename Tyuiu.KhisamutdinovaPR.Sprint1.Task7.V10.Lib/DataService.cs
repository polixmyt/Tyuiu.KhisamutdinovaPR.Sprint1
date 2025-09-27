using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        // Вычисляет z по формуле
        public double Calculate(double x)
        {
            double ctg = Math.Cos(3 * x) / Math.Sin(3 * x);
            double numerator = Math.Log(Math.Cos(x));
            double denominator = Math.Log(1 + x * x);

            double z = 2 * ctg - (numerator / denominator);
            return Math.Round(z, 3);
        }
    }
}