using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task3.V4.Lib
{
    // Предполагаемый интерфейс: ISprint1Task3V4
    public class DataService : ISprint1Task3V4
    {
        /// <summary>
        /// Вычисляет стоимость покупки: (цена тетради + цена обложки) * количество
        /// </summary>
        public double CalculatePurchase(int count)
        {
            double priceNotebook = 2.75;
            double priceCover = 0.5;

            double total = (priceNotebook + priceCover) * count;
            return Math.Round(total, 3);
        }

        public double PurchaseAmount(double priceNotebook, double priceCover, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}