using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IfTwoArraysAreIdentical
{
    class IfTwoArraysAreIdentical
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first array length ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Write second array length ");
            int m = int.Parse(Console.ReadLine());

            //Compare their lenght
            if (n != m)
            {
                Console.WriteLine("The arrays are not identical");
                return;
            }
         
            //INITIALIZE the arrays
            int[] firstArray = new int[n];
            int[] secondArray = new int[m];

            Console.WriteLine("Write the elements of the first array:");
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Write the elements of the second array:");
            for (int i = 0; i < m; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            //Compare their elements

            bool compare = true;
            for (int i = 0; i < n; i++)
            {
                if (firstArray[i]!=secondArray[i])
                {
                    compare = false;
                    break;
                }
            }

            Console.WriteLine("Are the two arrays identical? - {0} ",compare);
        }
    }
}
