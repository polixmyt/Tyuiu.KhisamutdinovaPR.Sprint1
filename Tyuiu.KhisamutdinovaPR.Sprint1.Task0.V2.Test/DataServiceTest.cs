using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task0.V2.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Expression_ReturnsOne()
        {
            var ds = new DataService();
            double actual = ds.Calculate();
            Assert.AreEqual(1.0, actual, 1e-10, "Ожидается результат 1.0");
        }
    }
}
