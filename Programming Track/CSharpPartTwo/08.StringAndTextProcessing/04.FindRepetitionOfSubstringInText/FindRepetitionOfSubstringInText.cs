using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindRepetitionOfSubstringInText
{
    class FindRepetitionOfSubstringInText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the text:\n");
            string inputText="We are living in an yellow submarine.We don't have anything else. Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            Console.WriteLine(inputText);
            Console.WriteLine("Wrtie the substring you want to check how many times it repeats");
            string inputWord = Console.ReadLine(); //"in";
            Console.WriteLine("The repetition of substring \"{0}\" is {1}",inputWord,GetRepetitionOfSubstring(inputWord, inputText));
        }
        static int GetRepetitionOfSubstring(string word, string text)
        {
            text = text.ToLower();
            int counter = 0;
            int startIndex = 0;
            while (text.IndexOf(word, startIndex) >= 0)
            {
                counter++;
                startIndex = text.IndexOf(word, startIndex) + 1;
            }
            return counter;
        }   
    }
}
