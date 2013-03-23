using System;
using System.Linq;

namespace _02.Person
{
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Person's Name: {0}, Age: {1}",this.Name, this.Age==null? "You did not enter person's age!":this.Age.ToString());
        }
    }
}
