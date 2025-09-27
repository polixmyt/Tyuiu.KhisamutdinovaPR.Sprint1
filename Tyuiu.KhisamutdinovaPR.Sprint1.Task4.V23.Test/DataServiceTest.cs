using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_CheckExample()
        {
            var ds = new DataService();

            // Пример: x = 4 => sqrt(5) / |3 - 4| = 2.236... / 1 = 2.236
            double expected = 2.236;
            double actual = ds.Calculate(4);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}