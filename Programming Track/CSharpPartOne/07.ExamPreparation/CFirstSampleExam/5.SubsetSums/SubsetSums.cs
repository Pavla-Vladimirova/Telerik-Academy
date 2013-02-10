using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SubsetSums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            long S = long.Parse(Console.ReadLine());
            byte N = byte.Parse(Console.ReadLine());
            int mask=1;
            long[] numbers=new long[N];
            int broi=0;

            for (int i = 0; i < N; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            for (int i = 1; i <=(Math.Pow(2,N)-1) ; i++)
            {
                long sum = 0;
                for (int j = 0; j < N; j++)
                {
                    if (((mask<<j)&i)!=0)
                    {
                        sum = sum + numbers[j];
                    }
                }
                if (sum==S)
	            {
		            broi=broi+1;
	            }
            }
            Console.WriteLine(broi);
        }
    }
}
