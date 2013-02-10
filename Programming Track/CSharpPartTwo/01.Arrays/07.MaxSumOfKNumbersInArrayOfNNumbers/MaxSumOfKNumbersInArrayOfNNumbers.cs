using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSumOfKNumbersInArrayOfNNumbers
{
    class MaxSumOfKNumbersInArrayOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write elements of the array N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Write K");
            int K = int.Parse(Console.ReadLine());


            int [] numberArray=new int[N];
            Console.WriteLine("Write the elemnts of the array");
            for (int i = 0; i < N; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is");
            for (int i = 0; i < N; i++)
            {
                Console.Write(" " +numberArray[i]);
            }
            Console.WriteLine();

            int maxSum = int.MinValue;
            for (int i = 0; i < (numberArray.Length-(K-1)); i++)
            {
                int sum = 0;
                //Example If K=3 first we check the sum from 0 to K-1,next from 1 to K,next from 2 to K+1,next from 3 to K+2 ... and compare them
                for (int j = i; j <= (K-1+i); j++) //finds the sum of every K following
                {
                    sum = sum + numberArray[j];
                }
                if (sum>maxSum)
	            {
		            maxSum=sum;
	            }
            }

            Console.WriteLine("The maximum sum of K elements In array of N elements is {0} ",maxSum);
        }
    }
}
