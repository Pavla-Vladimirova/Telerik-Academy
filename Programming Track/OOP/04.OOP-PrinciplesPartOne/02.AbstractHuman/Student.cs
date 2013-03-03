using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AbstractHuman
{
    public class Student : Human, IComparable<Student>
    {
        private int grade;

        public Student(string firstName,string lastName,int grade):base(firstName,lastName)
        {
            this.grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        public int CompareTo(Student other)
        {
            return this.Grade.CompareTo(other.Grade);
        }

        public override string ToPrint()
        {
            return string.Format("{0} {1} Grade: {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
