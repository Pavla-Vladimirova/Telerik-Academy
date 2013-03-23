using System;
using System.Linq;

//04.Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value.
//Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.

namespace _02.Person
{
    class TestPerson
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Ivan", null);
            Console.WriteLine(firstPerson);
            Person secondPerson = new Person("Peter", 23);
            Console.WriteLine(secondPerson);
            
        }
    }
}
