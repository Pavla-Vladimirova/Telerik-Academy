using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.ReplaceAllSeriesOfConsecutiveIdenticalLettersWithASingle
{
    class ReplaceAllSeriesOfConsecutiveIdenticalLettersWithASingle
    {
        static void Main(string[] args)
        {
            string inputText = "aaaaabbbbbcdddeeeedssaa hhbbbcccc";
            Console.WriteLine(ReplaceRepatingLettersWithASingle(inputText));
        }

        static string ReplaceRepatingLettersWithASingle(string text)
        {
            StringBuilder replaced = new StringBuilder();
            for (int i = 1; i <=text.Length-1; i++)
            {
                if (text[i]!=text[i-1])
                {
                    replaced.Append(text[i-1]);
                }
            }
            replaced.Append(text[text.Length-1]);
            return replaced.ToString();
        }
    }
}
