using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task2.V6.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertMToKm_ReturnsRounded()
        {
            var ds = new DataService();
            Assert.AreEqual(1.234, ds.ConvertMToKm(1234));
        }
    }
}