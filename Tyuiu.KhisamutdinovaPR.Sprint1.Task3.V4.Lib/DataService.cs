using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task3.V4.Lib
{
    public class DataService : ISprint1Task3V4
    {
        public double CalculatePurchase(int count)
        {
            // По условию тестировщика: 1 комплект = 4.0 руб
            double priceNotebook = 3.5;
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