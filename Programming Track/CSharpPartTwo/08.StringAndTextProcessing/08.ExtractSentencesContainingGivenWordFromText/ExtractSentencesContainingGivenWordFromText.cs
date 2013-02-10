using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentencesContainingGivenWordFromText
{
    class ExtractSentencesContainingGivenWordFromText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the text:\n");
            string inputText = "We are living in an yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            Console.WriteLine(inputText);
            Console.WriteLine("Wrtie a word to search the sentence who conatin it");
            string inputWord = Console.ReadLine();
            List<string> output = ExtractSentences(inputWord, inputText);
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
        static List<string> ExtractSentences(string word, string text)
        {
            string[] sentences = text.Split('.');
            List<string> extractedSentences = new List<string>();
            for (int i = 0; i < sentences.Length; i++)
            {
                string toLower = sentences[i].ToLower(); //check if the searched word is met with UpperLetter
                sentences[i].ToLower();
                int startIndex = 0;
                while (toLower.IndexOf(word, startIndex) >= 0)
                {
                    if (toLower.IndexOf(word, startIndex) == 0) //if the sentence starts with the searched word
                    {
                        if (Char.IsWhiteSpace(toLower, toLower.IndexOf(word, startIndex) + word.Length))
                        {
                            extractedSentences.Add(sentences[i]);
                        }
                    }
                    else
                    {
                        if ((Char.IsWhiteSpace(toLower, toLower.IndexOf(word, startIndex) - 1)) && (Char.IsWhiteSpace(toLower, toLower.IndexOf(word, startIndex) + word.Length))
                            || Char.IsPunctuation(toLower, toLower.IndexOf(word, startIndex) + word.Length))
                        {
                            extractedSentences.Add(sentences[i]);
                        }
                    }
                    startIndex = toLower.IndexOf(word, startIndex) + 1;
                }
            }
            return extractedSentences;
        }
    }
}
