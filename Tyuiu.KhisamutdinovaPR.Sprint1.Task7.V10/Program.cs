using System;
using System.Globalization;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task7.V10.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Хисамутдинова Полина Руслановна | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Математические вычисления                                         *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Хисамутдинова П. Р. | ПКТб-25-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить выражение: z = 2*ctg(3x) - ln(cos(x)) / ln(1 + x^2)           *");
            Console.WriteLine("* Округлить результат до 3 знаков после запятой.                          *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            var ds = new DataService();
            double result = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("z = " + result.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}