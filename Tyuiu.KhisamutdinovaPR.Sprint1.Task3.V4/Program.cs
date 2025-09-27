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
            Console.WriteLine("* Вычислить стоимость покупки, состоящей из нескольких тетрадей и такого  *");
            Console.WriteLine("* же количества обложек. Цена тетради = 3.5 руб, обложки = 0.5 руб.       *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.Write("Введите количество комплектов (шт): ");
            int count = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var ds = new DataService();
            double result = ds.CalculatePurchase(count);

            Console.WriteLine("Стоимость покупки: " + result.ToString("F3", CultureInfo.InvariantCulture) + " руб.");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}