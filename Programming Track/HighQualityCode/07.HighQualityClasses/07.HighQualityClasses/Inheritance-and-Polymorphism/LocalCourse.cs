using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        public LocalCourse(string name)
            : base(name)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students) : base(courseName, teacherName, students)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab) : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            string completedResult = base.ToString() + result.ToString();
            return completedResult.ToString();
        }
    }
}
