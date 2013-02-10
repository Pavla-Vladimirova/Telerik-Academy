using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ReadANumber
{
    class ReadANumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number in decimal,hexadecimal number,percentage and in scientific notation:");
            Console.WriteLine("{0,15:D}",number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:E}", number);
        }
    }
}
