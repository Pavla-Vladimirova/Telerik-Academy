using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.FibonacciSequence
{
    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;
            BigInteger nextNumber = 0;
            Console.WriteLine("The Fibonacci Sequence is \n{0}\n{1}",firstNumber,secondNumber);
            for (int i = 1; i <=n; i++)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                Console.WriteLine(nextNumber);
            }
        }
    }
}
