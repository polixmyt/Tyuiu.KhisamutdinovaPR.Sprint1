using System;
using System.Globalization;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task1.V3.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task1.V3
{
    internal class Program
    {
        static double ReadDouble(string prompt)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            if (s == null) throw new ArgumentNullException(nameof(s));

            // Принимаем как запятую, так и точку
            s = s.Replace(',', '.');
            return double.Parse(s, CultureInfo.InvariantCulture);
        }

        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Хисамутдинова Полина Руслановна | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Хисамутдинова П. Р. | ПКТб-25-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Запросить у пользователя x и y, вычислить (x - y) / (x + 3) + 3        *");
            Console.WriteLine("* и вывести результат на экран.                                           *");
            Console.WriteLine("***************************************************************************");

            var ds = new DataService();

            try
            {
                double x = ReadDouble("Введите x: ");
                double y = ReadDouble("Введите y: ");

                double res = ds.Calculate(x, y);
                Console.WriteLine("Результат: " + res.ToString(CultureInfo.InvariantCulture));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль (x не должен быть равен -3).");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
