using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.SortListOfWordsInAnAlphabeticalOrder
{
    class SortListOfWordsInAnAlphabeticalOrder
    {
        static void Main(string[] args)
        {
            string inputText = "list of words in alphabetical order";
            string[] inAlphabeticalOrder=SortInAlphabeticalOrder(inputText);
            for (int i = 0; i < inAlphabeticalOrder.Length; i++)
            {
                Console.WriteLine(inAlphabeticalOrder[i]);
            }
        }

        static string[] SortInAlphabeticalOrder(string text)
        {
            string[] words = text.Split(new char[]{' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            return words;
        }
    }
}
