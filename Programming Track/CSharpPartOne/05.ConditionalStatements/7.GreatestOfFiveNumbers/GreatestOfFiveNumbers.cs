using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.GreatestOfFiveNumbers
{
    class GreatestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("write number");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxNum = numbers[0];
            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
            }
            Console.WriteLine("The greatest number of all five numbers is " +maxNum);
        }
    }
}
