using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Dog : Animal
    {
        public override string Sex { get; protected set; }

        public Dog(string name,int age,string sex):base(name,age)
        {
            this.Sex = sex;
        }

        public override string Sound()
        {
            return string.Format("Dog's saying: Bark bark!");
        }
    }
}
