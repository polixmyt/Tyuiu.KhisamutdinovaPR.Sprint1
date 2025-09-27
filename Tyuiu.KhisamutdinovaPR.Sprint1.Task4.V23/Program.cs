using System;
using System.Globalization;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Хисамутдинова Полина Руслановна | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Класс Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Хисамутдинова П. Р. | ПКТб-25-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить по формуле: y = sqrt(x + 1) / x                               *");
            Console.WriteLine("* Округлить результат до 3 знаков после запятой.                          *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            var ds = new DataService();
            double result = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("y = " + result.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}