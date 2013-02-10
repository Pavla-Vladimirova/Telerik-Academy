using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.PrintAllDifferentLettersInText
{
    class PrintAllDifferentLettersInText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a text");
            string inputText = Console.ReadLine();
           int[] outputLetters = FindDifferentLetters(inputText);
            for (int i = 0; i < outputLetters.Length; i++)
            {
                if (i<outputLetters.Length/2)
                {
                    Console.WriteLine("{0} - {1}",outputLetters[i],Convert.ToChar(i + 65));
                }
                else
                {
                    Console.WriteLine("{0} - {1}", outputLetters[i], Convert.ToChar(i - outputLetters.Length / 2 + 97));
                }
            }
        }

        static int[] FindDifferentLetters(string text)
        {
            int[] letters = new int[52]; //form 0-25=A-Z and from 26-51=a-z
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    if (char.IsUpper(text[i]))
                    {
                        letters[text[i]-'A']++; //if we find 'B' 66-65=2 so on index 1 we add +1(we have found 1 'B')
                    }
                    else
                    {
                        letters[text[i] - 'a' + 26]++;  //if we find 'b' 98-97=1 so on index 26+1=27 we add +1(we have found 1 'b')
                    }
                }
            }
            return letters;
        }
    }
}
