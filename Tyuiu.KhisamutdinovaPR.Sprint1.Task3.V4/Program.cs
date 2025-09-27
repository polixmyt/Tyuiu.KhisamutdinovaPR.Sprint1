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
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Хисамутдинова П. Р. | ПКТб-25-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить стоимость покупки (тетради + обложки), количество задаёт      *");
            Console.WriteLine("* пользователь. Цена тетради = 2.75 руб, обложки = 0.5 руб.               *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество комплектов: ");
            int count = int.Parse(Console.ReadLine() ?? "0");

            var ds = new DataService();
            double result = ds.CalculatePurchase(count);

            Console.WriteLine("Стоимость покупки: " + result.ToString("F3", CultureInfo.InvariantCulture) + " руб.");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}