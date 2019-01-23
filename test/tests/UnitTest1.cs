using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test;
using System.Windows.Forms;


namespace tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Sum_10and20_30result()
        {
            //Arrare - Организация
            int x = 10;
            int y = 20;
            int result1 = 30;
            //Act - Действие
            Form1 c = new Form1();
            int result2 = c.Sum_two(x, y);
            //Assert - Утверждение
            Assert.AreEqual(result1, result2, "Сумма {0} и {1} равна 30", x, y);
        }
    }
}
