using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01HelloUser;

namespace _01.TestHelloUser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {           
            string res=HelloUser.HelloReader("Name");
            Assert.AreEqual("Hello Name!", res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string res = HelloUser.HelloReader(null);
            Assert.AreEqual("Hello !", res);
        }
    }
}
