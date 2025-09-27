using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_WhenX60_Returns0166()
        {
            var ds = new DataService();
            double expected = 0.166;  // sqrt(61) / 60 ≈ 0.166
            double actual = ds.Calculate(60);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}