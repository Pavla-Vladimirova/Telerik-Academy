using System;
using System.Linq;

//03.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female 
//and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of 
//animals and calculate the average age of each kind of animal using a static method (you may use LINQ).


namespace _03.Animals
{
    public class TestAnmials
    {
        static void Main(string[] args)
        {
            //Kittens
            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Mili", 2),
                new Kitten("Lili", 3),
                new Kitten("Ana", 5)
            };
            Console.WriteLine("Kittens:");
            foreach (var kitty in kittens)
            {
                Console.WriteLine(kitty);
            }
            Console.WriteLine("The average age of Kittens is: {0}\n", Kitten.AverageOfAge(kittens));

            //Tomcats
            Tomcat[] tomcats = new Tomcat[]
            { 
                new Tomcat("Bili",6),
                new Tomcat("Joe",2),
            };
            Console.WriteLine("Tomcats:");
            foreach (var tcat in tomcats)
            {
                Console.WriteLine(tcat);
            }
            Console.WriteLine("The average age of Tomcats is: {0}\n", Tomcat.AverageOfAge(tomcats));

            //Dogs
            Dog[] dogs = new Dog[] 
            {
                new Dog("Josh",3,"male"),
                new Dog("Brad",7,"male")
            };
            Console.WriteLine("Dogs:");
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }
            Console.WriteLine("The average age of Dogs is: {0}\n",Dog.AverageOfAge(dogs));

            //Frogs
            Frog frog = new Frog("Froggy", 2, "female");
            Console.WriteLine("Frogs:");
            Console.WriteLine(frog);
        }
    }
}
