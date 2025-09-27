using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_WhenX5Y2_ReturnsExpected()
        {
            var ds = new DataService();

            // Пример: x = 5, y = 2 => sqrt(|5+2|) / |3-5| = sqrt(7)/2 ≈ 1.323
            double expected = 1.323;
            double actual = ds.Calculate(5, 2);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}