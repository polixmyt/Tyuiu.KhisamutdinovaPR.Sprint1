using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        // Метод возвращает количество полных часов по номеру секунды суток
        public int SecondsToHours(int k)
        {
            return k / 3600;
        }
    }
}