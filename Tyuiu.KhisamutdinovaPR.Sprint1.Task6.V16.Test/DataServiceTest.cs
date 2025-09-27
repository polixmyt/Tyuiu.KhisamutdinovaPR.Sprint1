using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task6.V16.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSymbols_HasBothSymbols_ReturnsTrue()
        {
            var ds = new DataService();
            string input = "Привет! Как дела?";
            bool result = ds.CheckSymbols(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckSymbols_MissingOneSymbol_ReturnsFalse()
        {
            var ds = new DataService();
            string input = "Привет!";
            bool result = ds.CheckSymbols(input);
            Assert.IsFalse(result);
        }
    }
}