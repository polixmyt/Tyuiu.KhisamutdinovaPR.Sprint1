using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task0.V2.Lib
{
    public class DataService : ISprint1Task0V2
    {
        /// <summary>
        /// Вычисляет выражение 3/3*2 + 12/4/3 - 2
        /// </summary>
        public double Calculate()
        {
            double result = (3.0 / 3) * 2 + (12.0 / 4) / 3 - 2;
            return result;
        }
    }
}
