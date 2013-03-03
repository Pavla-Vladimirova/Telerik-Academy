using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age)
        {
        }

        public override string Sex
        {
            get
            {
                return "female";
            }
            protected set
            {
            }
        }
    }
}
