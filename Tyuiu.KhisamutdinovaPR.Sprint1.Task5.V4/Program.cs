using System;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Хисамутдинова Полина Руслановна | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Хисамутдинова П. Р. | ПКТб-25-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Идёт k-я секунда суток. Определить, сколько полных часов прошло         *");
            Console.WriteLine("* к этому моменту.                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите k (номер секунды суток): ");
            int k = Convert.ToInt32(Console.ReadLine());

            var ds = new DataService();
            int h = ds.SecondsToHours(k);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Полных часов прошло: " + h);
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}