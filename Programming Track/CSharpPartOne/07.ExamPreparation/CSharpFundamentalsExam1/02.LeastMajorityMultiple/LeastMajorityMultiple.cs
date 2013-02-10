using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            int j = 0;
            while (counter<3)
            {
                j++;
                counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (j % array[i] == 0)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(j);
        }
    }
}
