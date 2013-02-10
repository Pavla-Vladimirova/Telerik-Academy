using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array20elementsIndexMultipliedBy5
{
    class Array20elementsIndexMultipliedBy5
    {
        static void Main(string[] args)
        {
            int [] array=new int[20];

            //Initialize the array elements
            for (int i = 0; i < array.Length; i++)
			{
                array[i] = i * 5;
			}

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0}",array[i]);
            }
            Console.WriteLine();
        }
    }
}
