using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolSystem;
using System.Collections.Generic;

namespace TestSchoolSystem
{
    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        public void TestConstructor()
        {
            Student student = new Student("Ivan",12345);
            Course course = new Course("Maths", new List<Student> { student });
            School school = new School("NPMG", new List<Course> { course} );
            Assert.AreEqual(school.Name,"NPMG");
            Assert.AreEqual(school.Courses.Count,1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullName()
        {
            Student student = new Student("Ivan", 12345);
            Course course = new Course("Maths", new List<Student> { student });
            School school = new School(null, new List<Course> { course });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithEmptyName()
        {
            Student student = new Student("Ivan", 12345);
            Course course = new Course("Maths", new List<Student> { student });
            School school = new School("", new List<Course> { course });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullListOfCourses()
        {
            School school = new School("NPMG", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithEmptyListOfCourses()
        {
            School school = new School("NPMG", new List<Course>());
        }
    }
}
