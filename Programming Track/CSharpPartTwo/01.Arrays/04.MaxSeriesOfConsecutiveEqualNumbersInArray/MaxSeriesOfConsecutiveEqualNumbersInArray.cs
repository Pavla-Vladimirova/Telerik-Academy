using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaxSeriesOfConsecutiveEqualNumbersInArray
{
    class MaxSeriesOfConsecutiveEqualNumbersInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the length of the array");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Write elements of the array");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int counter = 1;
            int maxCounter=0;
            int repeatingElement=array[0];
            int maxRepeatingElement = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    repeatingElement = array[i];
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxRepeatingElement = repeatingElement;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int i = 0; i <maxCounter; i++)
            {
                Console.Write(" {0} ",repeatingElement);
            }

            Console.WriteLine("the length is {0}",maxCounter);
            
        }
    }
}
