using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04RepetitionOfNumberInArray;

namespace _04.TestRepetitionOfNumberInArray
{
    [TestClass]
    public class TestRepetitionOfNumberInArray
    {
        [TestMethod]
        public void TestMethod1()
        {
           int[] array = new int[] {3,2,3,4,3,5,3,2,6};
           int res=RepetitionOfNumberInArray.FindRepetitionOfNumber(3, array);
           Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] array = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int res = RepetitionOfNumberInArray.FindRepetitionOfNumber(1, array);
            Assert.AreEqual(9, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] array = new int[] { 0 };
            int res = RepetitionOfNumberInArray.FindRepetitionOfNumber(0, array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] array = new int[] {1,2,3,4,5,6,7};
            int res = RepetitionOfNumberInArray.FindRepetitionOfNumber(25, array);
            Assert.AreEqual(0, res);
        }
    }
}
