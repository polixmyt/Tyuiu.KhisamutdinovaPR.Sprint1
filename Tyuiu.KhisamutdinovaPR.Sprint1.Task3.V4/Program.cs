using System;
using System.Globalization;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task3.V4.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Хисамутдинова Полина Руслановна | ПКТб-25-1";

            Console.Write("Введите количество комплектов: ");
            int count = int.Parse(Console.ReadLine() ?? "0");

            var ds = new DataService();
            double result = ds.CalculatePurchase(count);

            Console.WriteLine(result.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}