using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FindSumOfInetgersWrittenIntoString
{
    class FindSumOfInetgersWrittenIntoString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write sequence of integers separated with spaces ");
            string numbers= Console.ReadLine();
            Console.WriteLine("The sum is {0} ",SumOfInetegrsInString(numbers));
        }

        static long SumOfInetegrsInString(string sequence)
        {
            string[] split = sequence.Split(' ');
            List<int> numbersSequence = new List<int>();
            for (int i = 0; i < split.Length; i++)
            {
                numbersSequence.Add(Convert.ToInt32(split[i]));
            }
            long sum = 0;
            for (int i = 0; i < numbersSequence.Count; i++)
            {
                sum += numbersSequence[i];
            }
            return sum;
        }
    }
}
