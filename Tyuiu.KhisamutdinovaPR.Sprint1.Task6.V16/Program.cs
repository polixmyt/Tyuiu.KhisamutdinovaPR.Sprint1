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
            Console.WriteLine("* Пользователь вводит строку. Проверить, что в строке есть '!' и '?'.     *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст: ");
            string input = Console.ReadLine() ?? "";

            DataService ds = new DataService();
            bool result = ds.CheckSymbols(input);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (result)
                Console.WriteLine("Строка содержит и '!' и '?'.");
            else
                Console.WriteLine("Строка не содержит оба символа одновременно.");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}