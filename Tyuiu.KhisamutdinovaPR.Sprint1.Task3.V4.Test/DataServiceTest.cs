using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task3.V4.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculatePurchase_ReturnsExpected()
        {
            var ds = new DataService();

            // Пример: 7 комплектов => (2.75 + 0.5) * 7 = 22.75
            double expected = 22.75;
            double actual = ds.CalculatePurchase(7);

            Assert.AreEqual(expected, actual);
        }
    }
}