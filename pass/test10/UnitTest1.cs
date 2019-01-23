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
        public void vsepravilno()
        {
            string password = "123123+";
            string kpass = "123123+";
            string expected = "Вы зарегестрированы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void netznakov()
        {
            string password = "123123";
            string kpass = "123123";
            string expected = "Вы не зареганы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void bolshe1znaka()
        {
            string password = "123123++";
            string kpass = "123123++";
            string expected = "Вы не зареганы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void povornie4isla()
        {
            string password = "12312333";
            string kpass = "12312333";
            string expected = "Вы не зареганы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void net4isel()
        {
            string password = "";
            string kpass = "";
            string expected = "Вы не зареганы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void vsepravilno1()
        {
            string password = "121314&";
            string kpass = "121314&";
            string expected = "Вы зарегестрированы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void vsepravilno2()
        {
            string password = "1231214155&";
            string kpass = "1231214155&";
            string expected = "Вы зарегестрированы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void vsepravilno3()
        {
            string password = "+123456";
            string kpass = "+123456";
            string expected = "Вы зарегестрированы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void vsepravilno4()
        {
            string password = "12+314";
            string kpass = "12+314";
            string expected = "Вы зарегестрированы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void nesovpadayut()
        {
            string password = "12223123";
            string kpass = "123123";
            string expected = "Вы не зареганы";

            Form1 c = new Form1();
            string res = c.reg(password, kpass);

            Assert.AreEqual(expected, res);
        }
    }
}