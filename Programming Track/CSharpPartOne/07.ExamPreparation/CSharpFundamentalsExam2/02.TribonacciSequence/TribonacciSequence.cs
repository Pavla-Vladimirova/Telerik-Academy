using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.TribonacciSequence
{
    class TribonacciSequence
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber =BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
            ushort N = ushort.Parse(Console.ReadLine());
            BigInteger currentNumber = 0;
            BigInteger firstChange = 0;
            BigInteger secondChange = 0;

            if (N==1)
            {
                currentNumber = firstNumber;
            }
            else if (N==2)
            {
                currentNumber = secondNumber;
            }
            else if (N==3)
            {
                currentNumber = thirdNumber;
            }
            else
            {
                for (int i = 1; i <=N-3; i++)
                {
                    currentNumber = firstNumber + secondNumber + thirdNumber;
                    firstChange = firstNumber;
                    firstNumber = secondNumber;
                    secondChange = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = currentNumber;              
                }
            }
            Console.WriteLine(currentNumber);
        }
    }
}
