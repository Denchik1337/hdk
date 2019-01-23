using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pass;
using System.Windows.Forms;

namespace test10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string password = "123123+";
            string kpass = "123123";
            string expected = "Вы зарегестрированы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
    }
}
