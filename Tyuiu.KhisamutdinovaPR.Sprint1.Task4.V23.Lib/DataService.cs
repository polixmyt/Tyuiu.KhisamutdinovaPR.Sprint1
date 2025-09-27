using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        // Формула: y = sqrt(|x + y|) / |3 - x|
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sqrt(Math.Abs(x + y));
            double denominator = Math.Abs(3 - x);

            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}