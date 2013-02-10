using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MaxReapeatingNumberInArray
{
    class MaxReapeatingNumberInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write length of the array");
            int n = int.Parse(Console.ReadLine());

            int[] numberArray = new int[n];
            Console.WriteLine("Write the elements of the array");
            for (int i = 0; i < n; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array is");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + numberArray[i]);
            }
            Console.WriteLine();

            int maxCounter = Int32.MinValue;
            int maxRepeating = numberArray[0];
            for (int i = 0; i < numberArray.Length; i++)
            {
                int counter = 0;
                int Repeating = numberArray[i];
                for (int j = 0; j < numberArray.Length; j++)
                {
                    if (numberArray[i]==numberArray[j])
                    {
                        counter++;
                        Repeating=numberArray[j];
                    }
                }
                if (counter>maxCounter)
                {
                    maxCounter = counter;
                    maxRepeating=Repeating;
                }
            }
            Console.WriteLine("The most repeating number is {0} and it repeats {1}",maxRepeating,maxCounter);
        }
    }
}
