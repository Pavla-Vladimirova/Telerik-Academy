using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20.ExtractAllPalindromeWords
{
    class ExtractAllPalindromeWords
    {
        static void Main(string[] args)
        {
            string inputText = "sjajda ABBA skakj lamal dsajkaj exe";
            List<string> outputPalindromes = ExtractPalindromes(inputText);
            for (int i = 0; i < outputPalindromes.Count; i++)
            {
                Console.WriteLine(outputPalindromes[i]);
            }
        }

        static List<string> ExtractPalindromes(string text)
        {
            Match match = Regex.Match(text, @"\b\w+\b", RegexOptions.IgnoreCase);
            List<string> palindromes = new List<string>();
            while (match.Success)
            {
                string currentWord=match.Value;
                bool isPalindorme = false;
                for (int i = 0; i < currentWord.Length; i++)
                {
                    if (currentWord[i]==currentWord[currentWord.Length-1-i])
                    {
                        isPalindorme = true;
                    }
                    else
                    {
                        isPalindorme = false;
                        break;
                    }
                }
                if (isPalindorme==true)
                {
                    palindromes.Add(match.Value);
                }
                match = match.NextMatch();
            }
            return palindromes;
        }
    }
}
