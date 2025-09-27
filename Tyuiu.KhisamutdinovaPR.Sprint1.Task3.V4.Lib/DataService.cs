using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task3.V4.Lib
{
    public class DataService : ISprint1Task3V4
    {
        // 1 комплект = тетрадь (3.5 руб) + обложка (0.5 руб) = 4.0 руб
        public double CalculatePurchase(int count)
        {
            double total = 4.0 * count;
            return Math.Round(total, 3);
        }

        public double PurchaseAmount(double priceNotebook, double priceCover, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}