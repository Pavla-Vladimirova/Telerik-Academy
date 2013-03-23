using System;
using System.Linq;

//05.Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace _03.BitArray
{
    class TestBitArray
    {
        static void Main(string[] args)
        {
            BitArray64 firstNumber = new BitArray64(67);
            BitArray64 secondNumber = new BitArray64(876);

            //ToString
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine();

            //== !=
            Console.WriteLine("== {0}",firstNumber==secondNumber);
            Console.WriteLine("!= {0}",firstNumber!=secondNumber);
            Console.WriteLine();

            //Equals
            Console.WriteLine(firstNumber.Equals(secondNumber) ? "Numbers are equal" : "numbers are not equal");
            Console.WriteLine();

            //GetHashCode
            Console.WriteLine(firstNumber.GetHashCode());
            Console.WriteLine();

            //indexer[]
            for (int i = 0; i < BitArray64.BitsCount; i++)
            {
                Console.Write(firstNumber[BitArray64.BitsCount-1-i]);
            }
            Console.WriteLine();

            //IEnumarable<int>
            foreach (var item in secondNumber)
            {
                Console.Write(item);
            }
        }
    }
}
