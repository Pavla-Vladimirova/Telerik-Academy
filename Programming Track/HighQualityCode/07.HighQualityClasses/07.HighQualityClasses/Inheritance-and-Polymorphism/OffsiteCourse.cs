using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string name)
            : base(name)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students) : base(courseName, teacherName, students)
        {
        }
        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town) : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            base.ToString();
            StringBuilder result = new StringBuilder();
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            string completedResult = base.ToString() + result.ToString();
            return completedResult.ToString();
        }
    }
}
