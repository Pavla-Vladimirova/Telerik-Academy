using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _22.PrintAllDifferentWordsInText
{
    class PrintAllDifferentWordsInText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a text ");
            string inputText = Console.ReadLine();
            Dictionary<string, int> outputWords = RepetitionOfDifferentWords(inputText);
            foreach (var pair in outputWords)
            {
                Console.WriteLine("{0}, {1}",pair.Key,pair.Value);
            }
        }

        static Dictionary<string, int> RepetitionOfDifferentWords(string text)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            Match match = Regex.Match(text, @"\b\w+\b", RegexOptions.IgnoreCase);//for each whole word chek if it has not alredy been added,if it has been met for n-th time add +1;
            while (match.Success)
            {
                string currentWord = match.Value;
                if (words.ContainsKey(currentWord) == false)//if we met it for the first time
                {
                    words.Add(currentWord, 1);
                }
                else
                {
                    words[currentWord]++;
                }

                match = match.NextMatch();
            }
            return words;
        }
    }
}
