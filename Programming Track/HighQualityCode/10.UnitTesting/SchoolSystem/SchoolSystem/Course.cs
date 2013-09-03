using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem
{
    public class Course
    {
        private const int MAX_STUDENTS = 30;
        private string name;
        private List<Student> students;

        public Course(string name, List<Student> students)
        {
            this.Name = name;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name of a course cannot be null");
                }
                if (value == string.Empty)
                {
                    throw new ArgumentException("The name of a course cannot be empty");
                }
                this.name = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The list of students of a course does not refer to any object");
                }
                if (value.Count == 0)
                {
                    throw new ArgumentException("The list of students of a course cannot be empty");
                }
                if (value.Count > MAX_STUDENTS)
                {
                    throw new ArgumentException("The list of students of a course cannot have more than 30 students");
                }
                this.students = value;
            }
        }

        public void EnrolCourse(Student student)
        {
            if (this.Students.Count >= MAX_STUDENTS)
            {
                throw new ArgumentException("The list of students of a course has already 30 students enrolled");
            }

            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].UniqueNumber == student.UniqueNumber)
                {
                    throw new ArgumentException("There is already a student with unique number=" + student.UniqueNumber + " in this course");
                }
            }
           
            this.Students.Add(student);
        }

        public void LeaveCourse(Student student)
        {
            if (this.Students.Count == 0)
            {
                throw new ArgumentException("The list of students of a course is empty");
            }

            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].UniqueNumber == student.UniqueNumber)
                {
                    this.Students.RemoveAt(i);
                    return;
                }
            }

            throw new ArgumentException("There is no student with unique number=" + student.UniqueNumber + " in this course");
        }
    }
}
