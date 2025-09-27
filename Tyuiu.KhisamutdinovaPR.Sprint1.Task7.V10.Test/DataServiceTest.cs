using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint1.Task7.V10.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_CheckExample()
        {
            var ds = new DataService();

            // Проверим на x = 1
            double actual = ds.Calculate(1);
            // Результат проверяем с допуском
            Assert.AreEqual(-0.251, actual, 0.001);
        }
    }
}