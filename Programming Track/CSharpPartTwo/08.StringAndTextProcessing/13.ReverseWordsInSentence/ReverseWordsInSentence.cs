using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.ReverseWordsInSentence
{
    class ReverseWordsInSentence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence");
            string inputSentence = Console.ReadLine();
            Console.WriteLine(ReverseWords(inputSentence));
        }

        static string ReverseWords(string sentence)
        {
           //get the words
            string[] wordsSplitted = sentence.Split(new char[] {' ',',','.','!','?'},StringSplitOptions.RemoveEmptyEntries);
            StringBuilder reversed = new StringBuilder();
            //get the separators
            List<char> separators = new List<char>();
            for (int i = 0; i < sentence.Length; i++)
            {
                if ((sentence[i] == ' ') || (sentence[i] == ',') || (sentence[i] == '.') || (sentence[i] == '!') || (sentence[i] == '?'))
                {
                    if (((sentence[i] == ' ')&&(sentence[i-1] == ','))==false)
                    {
                        separators.Add(sentence[i]);
                    }
                }
            }
            //reverse
            for (int i = 0,j=0; i < separators.Count; i++,j++)
            {
                if (j<wordsSplitted.Length)
                {
                    reversed.Append(wordsSplitted[wordsSplitted.Length - j - 1]);  
                }
                reversed.Append(separators[i]);
                if (separators[i] == ',') //put a space after a comma
                {
                    reversed.Append(' ');
                }
            }
            return reversed.ToString();
        }
    }
}
