using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SecondsToHours_Example13257_Returns3()
        {
            var ds = new DataService();
            int expected = 3;
            int actual = ds.SecondsToHours(13257);
            Assert.AreEqual(expected, actual);
        }
    }
}