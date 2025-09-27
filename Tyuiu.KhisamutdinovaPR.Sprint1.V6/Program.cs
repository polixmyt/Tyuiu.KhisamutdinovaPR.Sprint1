using System;
using System.Globalization;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task2.V6.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Хисамутдинова Полина Руслановна | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы                                          *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Хисамутдинова П. Р. | ПКТб-25-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известно расстояние в метрах. Перевести в километры, округлить до 3 знаков.");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите расстояние в метрах: ");
            int meters = int.Parse(Console.ReadLine() ?? "0");

            var ds = new DataService();
            double result = ds.ConvertToKm(meters);

            Console.WriteLine("Расстояние в километрах = " + result.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}