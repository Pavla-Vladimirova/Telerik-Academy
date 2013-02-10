using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MakeTheWordsInTagsUpperCase
{
    class MakeTheWordsInTagsUpperCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the text:\n");
            string inputText = "We are living in a <upcase>yellow submarine</upcase>. \nWe don't have <upcase>anything</upcase> else.\n";
            Console.WriteLine(inputText);
            Console.WriteLine("The Replaced text:\n");
            Console.WriteLine(MakeToUpperCase(inputText)); 
        }
        static string MakeToUpperCase(string text)
        {
            StringBuilder replaced = new StringBuilder();
            replaced.Append(text);
            //<..>
            int firstIndexOfStartTag = text.IndexOf("<");
            int lastIndexOfStartTag = text.IndexOf(">");
            //</..>
            int firstIndexOfEndTag = 0; 
            int lastIndexOfEndTag = 0;
            while (firstIndexOfStartTag>=0)
            {
                StringBuilder toReplace= new StringBuilder();// tha start tag+words+end tag
                StringBuilder upperCase = new StringBuilder();//the words between the tags that are goign to be upper
                //find START tag
                for (int i = firstIndexOfStartTag; i <=lastIndexOfStartTag; i++)
                {
                    toReplace.Append(text[i]); 
                }
                //find the WORDS in tag
                firstIndexOfEndTag = text.IndexOf("</", lastIndexOfStartTag);
                lastIndexOfEndTag = text.IndexOf(">", lastIndexOfStartTag+1);
                for (int i = lastIndexOfStartTag+1; i <firstIndexOfEndTag; i++)
                {
                    upperCase.Append(text[i]); 
                }
                toReplace.Append(upperCase);
                //find the END tag
                for (int i = firstIndexOfEndTag; i <=lastIndexOfEndTag; i++)
                {
                    toReplace.Append(text[i]);
                }
                replaced = replaced.Replace(toReplace.ToString(), (upperCase.ToString()).ToUpper());
                //get the next tags
                firstIndexOfStartTag = text.IndexOf("<",firstIndexOfEndTag+1);
                lastIndexOfStartTag = text.IndexOf(">",lastIndexOfEndTag+1);
            }
            return replaced.ToString();
        }
    }
}
