using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public abstract class Cat : Animal
    {
        public Cat(string name,int age):base(name,age)
        {
        }

        public override string Sound()
        {
            return string.Format("Cat's saying: Myau myau!");
        }
    }
}
