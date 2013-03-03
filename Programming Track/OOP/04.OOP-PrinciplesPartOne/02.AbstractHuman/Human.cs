using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AbstractHuman
{
    public abstract class Human 
    {
        public string FirstName { get; protected set; }
        public string LastName  { get; protected set; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public abstract string ToPrint();

        public override string ToString()
        {
            return string.Format("{0}",this.ToPrint());
        }
    }
}
