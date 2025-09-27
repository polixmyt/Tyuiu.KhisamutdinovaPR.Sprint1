using System;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task6.V16.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Хисамутдинова Полина Руслановна | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Хисамутдинова П. Р. | ПКТб-25-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Проверить, содержит ли введённый текст '!' и '?'.                       *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст: ");
            string input = Console.ReadLine() ?? "";

            var ds = new DataService();
            bool result = ds.CheckSymbols(input);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(result ? "Строка содержит и '!' и '?'." : "Не все символы найдены.");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}