using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task1.V3.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Sample_ReturnsExpected()
        {
            var ds = new DataService();
            double x = 9, y = 4;
            // (9 - 4) / (9 + 3) + 3 = 5/12 + 3 = 3.4166666667
            double expected = 3.4166666667;
            double actual = ds.Calculate(x, y);
            Assert.AreEqual(expected, actual, 1e-9);
        }
    }
}