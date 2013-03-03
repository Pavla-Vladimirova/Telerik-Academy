using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Student : Person,ICommentable
    {
        public int UniqueClassNumber { get; private set; }

        public Student(string name, int age, int uniqueClassNumber) : base(name, age)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public string Comment()
        {
            return string.Format("Comment about {0}(student)",this.Name);
        }

        public override string ToString()
        {
            return string.Format("\n  Name: {0}; \n  Age: {1}; \n  UniqueNumber: {2}; \n  Comments: {3};",this.Name,this.Age,this.UniqueClassNumber,this.Comment());
        }
    }
}
