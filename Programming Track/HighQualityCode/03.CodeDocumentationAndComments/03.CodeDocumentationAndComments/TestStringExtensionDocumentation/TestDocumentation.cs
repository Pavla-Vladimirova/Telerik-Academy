using System;
using System.Linq;
using Telerik.ILS.Common;

namespace TestStringExtensionDocumentation
{
    class TestDocumentation
    {
        static void Main(string[] args)
        {
            string example = "абвгд";
            Console.WriteLine(example.ConvertCyrillicToLatinLetters()); // hover over the method "ConvertCyrillicToLatinLetters()" to see the documentation works
        }
    }
}
