using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public abstract class Animal : ISound
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public abstract string Sex { get; protected set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public abstract string Sound();

        public override string ToString()
        {
            return string.Format("Name: {0}, Age {1}, Sex: {2}, Sound: {3}",this.Name,this.Age,this.Sex,this.Sound());
        }

        public static double AverageOfAge(Animal[] animals)
        {
            double averageOfAnimalsAge = animals.Average(animal => animal.Age);
            return averageOfAnimalsAge;
        }
    }
}
