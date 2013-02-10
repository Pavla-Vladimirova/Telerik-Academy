using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace _04.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            int counter = 1;
            long oddNumber = numbers[0];
            Array.Sort(numbers);
            bool check = true;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter % 2 == 0)
                    {
                        counter = 1;
                        check = false;
                    }
                    else
                    {
                        oddNumber = numbers[i];
                        check = false;
                        break;
                    }
                }
                check = true;
            }
            if (check==true)
            {
                oddNumber = numbers[numbers.Length - 1];
            }
            Console.WriteLine(oddNumber);
        }
    }
}
