using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareTwoCharArraysLetterByLetter
{
    class CompareTwoCharArraysLetterByLetter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first array length");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second array length");
            int m = int.Parse(Console.ReadLine());

            char[] firstArray = new char[n];
            char[] secondArray = new char[m];

            Console.WriteLine("Write  letters for first array");
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Write  letters for second array");
            for (int i = 0; i < m; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            //compare
            bool identical = true;
            int min= n;
            if (m<min)
            {
                min = m;
            }
            for (int i = 0; i < min; i++)
            {
                if ((Convert.ToInt32(firstArray[i]))!=(Convert.ToInt32(secondArray[i])))
                {
                    identical = false;
                    if ((Convert.ToInt32(firstArray[i]))<(Convert.ToInt32(secondArray[i])))
                    {
                        Console.WriteLine("The first array is earlier");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The second array is earlier");
                        break;
                    }
                }
            }

            if (identical==true)
            {
                if (n<m)
                {
                    Console.WriteLine("The first array is earlier");
                   
                }
                else if (m<n)
                {
                    Console.WriteLine("The second array is earlier");
                    
                }
                else if (n==m)
	            {
                     Console.WriteLine("The arrays are identical");
	            }
            }
        }
    }
}
