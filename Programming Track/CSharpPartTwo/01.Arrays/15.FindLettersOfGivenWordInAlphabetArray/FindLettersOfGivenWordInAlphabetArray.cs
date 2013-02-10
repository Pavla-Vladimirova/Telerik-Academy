using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FindLettersOfGivenWordInAlphabetArray
{
    class FindLettersOfGivenWordInAlphabetArray
    {
        static void Main(string[] args)
        {
            char [] alphabet=new char[52];
            //Alphabet in array with small and capital letters
            for (int i = 0; i < 52; i++)
            {
                if (i<26)
                {
                    alphabet[i] = (char)(i + 97);
                }
                else
                {
                    alphabet[i] = (char)(i + 39);
                }   
            }

            for (int i = 0; i < 52; i++)
            {
                Console.Write(" " + alphabet[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Write a word");
            string word = Console.ReadLine();

           // with alphabet array
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        if (j >= 26) // check if it's a capital letter and calculate its real postion (+1 since the array index starts from zero(A is first not zero letter)) 
                        {
                            Console.WriteLine("{0} - {1}", word[i], j - 26 + 1);
                        }
                        else
                        {
                            Console.WriteLine("{0} - {1}", word[i], j + 1);
                        }
                    }
                }
            }
        }
    }
}
