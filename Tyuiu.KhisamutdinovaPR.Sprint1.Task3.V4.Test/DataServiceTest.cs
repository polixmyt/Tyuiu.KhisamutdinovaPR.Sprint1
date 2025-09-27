using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task3.V4.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void OneSet_ShouldBeFourRubles()
        {
            var ds = new DataService();
            Assert.AreEqual(4.0, ds.CalculatePurchase(1));
        }
    }
}