using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ConvertStringToSequenceOfUnicodeChar
{
    class ConvertStringToSequenceOfUnicodeChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your string");
            string sequence = Console.ReadLine();
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write("\\u{0:x4}",Convert.ToInt16(sequence[i]));
            }
            Console.WriteLine();
        }
    }
}
