using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task2.V6.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertMetersToKm_CorrectResult()
        {
            var ds = new DataService();

            // 1234 м = 1.234 км (округляем до 3 знаков)
            double expected = 1.234;
            double actual = ds.ConvertToKm(1234);

            Assert.AreEqual(expected, actual);
        }
    }
}