using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word");
            string input = Console.ReadLine(); //"sample";
            Console.WriteLine("The reversed word is {0}",ReverseWord(input));
        }

        static string ReverseWord(string word)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = word.Length - 1; i >=0; i--)
            {
                reversed.Append(word[i]);
            }
            return reversed.ToString();
        }
    }
}
