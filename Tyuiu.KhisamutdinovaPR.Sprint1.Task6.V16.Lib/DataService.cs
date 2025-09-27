using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            throw new NotImplementedException();
        }

        // Проверка: строка содержит и "!" и "?"
        public bool CheckSymbols(string value)
        {
            return value.Contains("!") && value.Contains("?");
        }
    }
}