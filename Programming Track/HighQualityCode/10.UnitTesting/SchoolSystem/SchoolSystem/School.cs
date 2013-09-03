using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem
{
    public class School
    {
       
        private string name;
        private List<Course> courses;

        public School(string name, List<Course> courses)
        {
            this.Name = name;
            this.Courses = courses;
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
                    throw new ArgumentNullException("The name of a school cannot be null");
                }
                if (value == string.Empty)
                {
                    throw new ArgumentException("The name of a school cannot be empty");
                }
                this.name = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The list of courses of a school does not refer to any object");
                }
                if (value.Count == 0)
                {
                    throw new ArgumentException("The list of courses of a school cannot be empty");
                }
                this.courses = value;
            }
        }
    }
}
