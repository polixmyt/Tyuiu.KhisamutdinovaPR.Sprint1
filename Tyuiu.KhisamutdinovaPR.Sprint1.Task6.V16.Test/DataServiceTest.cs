using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task6.V16.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSymbols_InputHasBoth_ReturnsTrue()
        {
            DataService ds = new DataService();
            string input = "Ты идешь?!";
            Assert.IsTrue(ds.CheckSymbols(input));
        }

        [TestMethod]
        public void CheckSymbols_InputHasOnlyOne_ReturnsFalse()
        {
            DataService ds = new DataService();
            string input = "Привет!";
            Assert.IsFalse(ds.CheckSymbols(input));
        }
    }
}