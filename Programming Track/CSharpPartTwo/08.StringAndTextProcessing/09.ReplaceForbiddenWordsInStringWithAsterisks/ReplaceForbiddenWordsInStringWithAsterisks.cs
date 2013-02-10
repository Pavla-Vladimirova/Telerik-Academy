using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReplaceForbiddenWordsInStringWithAsterisks
{
    class ReplaceForbiddenWordsInStringWithAsterisks
    {
        static void Main(string[] args)
        {
            string forbiddenWords = "PHP,CLR,Microsoft";
            string inputText = "Microsoft announced its next generation PHP compiler today. PHP It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            Console.WriteLine(inputText);
            Console.WriteLine( ReplaceForbiddenWords(forbiddenWords, inputText));
        }

        static string ReplaceForbiddenWords(string words, string text)
        {
            string[] forbiddenList = words.Split(',');
            StringBuilder replaced = new StringBuilder();
            replaced.Append(text);
            for (int i = 0; i < forbiddenList.Length; i++)
            {
                string replacement = new String('*', forbiddenList[i].Length);
                int startIndex = 0;
                while (text.IndexOf(forbiddenList[i], startIndex) >= 0)
                {
                    if (text.IndexOf(forbiddenList[i], startIndex) == 0) 
                    {
                        if (Char.IsWhiteSpace(text, text.IndexOf(forbiddenList[i], startIndex) + forbiddenList[i].Length))
                        {
                            replaced = replaced.Replace(forbiddenList[i], replacement);
                        }
                    }
                    else
                    {
                        if ((Char.IsWhiteSpace(text,text.IndexOf(forbiddenList[i], startIndex) - 1)) && (Char.IsWhiteSpace(text, text.IndexOf(forbiddenList[i], startIndex) +forbiddenList[i].Length))
                            || (Char.IsPunctuation(text, text.IndexOf(forbiddenList[i], startIndex) + forbiddenList[i].Length)))
                        {
                            replaced = replaced.Replace(forbiddenList[i],replacement);
                        }
                    }
                    startIndex = text.IndexOf(forbiddenList[i], startIndex) + 1;
                }
            }
            return replaced.ToString();
        }
    }
}
