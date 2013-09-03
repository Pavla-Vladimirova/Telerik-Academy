using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolSystem;

namespace TestSchoolSystem
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void TestConstructor()
        {
            Student student = new Student("Ivan",90100);
            Assert.AreEqual(student.Name,"Ivan");
            Assert.AreEqual(student.UniqueNumber,90100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullName()
        {
            Student student = new Student(null, 90100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithEmptyName()
        {
            Student student = new Student("", 90100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorWithBiggerNumberOutOfTheRange()
        {
            Student student = new Student("Ivan", 9930100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorWithSmallerNumberOutOfTheRange()
        {
            Student student = new Student("Ivan", 10);
        }


    }
}
