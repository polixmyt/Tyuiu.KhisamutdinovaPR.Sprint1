using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task1.V3.Lib
{
    // Предполагаемый интерфейс: ISprint1Task1V3
    public class DataService : ISprint1Task1V3
    {
        /// <summary>
        /// Вычисляет выражение (x - y) / (x + 3) + 3
        /// </summary>
        public double Calculate(double x, double y)
        {
            return (x - y) / (x + 3) + 3;
        }
    }
}
