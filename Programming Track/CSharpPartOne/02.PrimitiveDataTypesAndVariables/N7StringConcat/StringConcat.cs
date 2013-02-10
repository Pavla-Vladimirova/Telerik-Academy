using System;


namespace N7StringConcat
{
    class StringConcat
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object concat = (hello + " " + world);
            Console.WriteLine(concat);
            string initializeWithObject = (string)concat;
            Console.WriteLine(initializeWithObject);
        }
    }
} 
