using System;
using System.Linq;
using System.Text;

//01.Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
//and has the same functionality as Substring in the class String.

namespace _01.ExtensionSubString
{
    class TestSubString
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("Testing SubString");
            StringBuilder result = str.SubString(8,3);
            Console.WriteLine(result);
        }
    }
}
