using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CheckWordInDictionary
{
    class CheckWordInDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            string currentWord = "";
            do
            {
                Console.WriteLine("Write a word");
                currentWord = Console.ReadLine();
                if (dictionary.ContainsKey(currentWord) == true)
                {
                    string explanation = dictionary[currentWord];
                    Console.WriteLine("{0} - {1}",currentWord,explanation);
                }
                else
                {
                    Console.WriteLine("The word is not in the dictionary");
                }
            } while (dictionary.ContainsKey(currentWord) == false);
        }
    }
}
