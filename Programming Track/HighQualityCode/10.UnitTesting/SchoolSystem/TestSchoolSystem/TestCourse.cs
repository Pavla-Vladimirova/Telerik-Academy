using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolSystem;
using System.Collections.Generic;

namespace TestSchoolSystem
{
    [TestClass]
    public class TestCourse
    {
        #region TestEnrolCourseMethod

        [TestMethod]
        public void TestEnrolCourse()
        {
            Course maths = new Course("Maths",new List<Student>{new Student("Peter",23456)});
            Student student = new Student("Ivan", 12345);
            maths.EnrolCourse(student);
            Assert.AreEqual(maths.Students.Count, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEnrolCourseWithMaximumStudents()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 30; i++)
            {
                students.Add(new Student("Ivan" + i, 12345 + i));
            }
            Course maths = new Course("Maths", students);
            Student student = new Student("Peter", 32345);
            maths.EnrolCourse(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEnrolCourseWithZeroStudents()
        {
            List<Student> students = new List<Student>();
            Course maths = new Course("Maths", students);
            Student student = new Student("Peter", 32345);
            maths.EnrolCourse(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEnrolCourseExistingStudent()
        {
            Course maths = new Course("Maths", new List<Student> { new Student("Ivan", 12345) });
            Student student = new Student("Ivan", 12345);
            maths.EnrolCourse(student);
        }
        #endregion

        #region TestLeaveCourseMethod

        [TestMethod]
        public void TestLeaveCourse()
        {
            Course maths = new Course("Maths", new List<Student> { 
                new Student("Ivan", 12345),
                new Student("Peter", 23456),
                new Student("Iva",34567)
                
            });
            Student student = new Student("Ivan", 12345);
            maths.LeaveCourse(student);
            Assert.AreEqual(maths.Students.Count, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLeaveCourseWithZeroStudents()
        {
            Course maths = new Course("Maths", new List<Student> { new Student("Boris", 92345) });
            Student student = new Student("Boris", 92345);
            maths.LeaveCourse(student);
            maths.LeaveCourse(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLeaveCourseWithInexistingStudent()
        {
            Course maths = new Course("Maths", new List<Student> { 
                new Student("Ivan", 12345),
                new Student("Peter", 23456),
                new Student("Iva",34567)
                
            });
            Student student = new Student("Boris", 92345);
            maths.LeaveCourse(student);
        }

        #endregion

        #region TestConstructor

        [TestMethod]
        public void TestConstructor()
        {
            Course maths = new Course("Maths", new List<Student> { new Student("Peter", 23456) });
            Assert.AreEqual(maths.Name,"Maths");
            Assert.AreEqual(maths.Students.Count, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullName()
        {
            Course maths = new Course(null, new List<Student> { new Student("Peter", 23456) });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithEmptyName()
        {
            Course maths = new Course("", new List<Student> { new Student("Peter", 23456) });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullListOfStudents()
        {
            Course maths = new Course("Math",null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithEmptyListOfStudents()
        {
            Course maths = new Course("Math", new List<Student>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithMaximumNumberOfStudents()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 31; i++)
            {
                students.Add(new Student("Ivan" + i, 12345 + i));
            }
            Course maths = new Course("Maths", students);
        }

        #endregion
    }
}
