using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.ExtractOnlyTextFromHTMLDocument
{
    class ExtractOnlyTextFromHTMLDocument
    {
        static void Main(string[] args)
        {
            string inputHTML="<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            Console.WriteLine(ExtractText(inputHTML));
        }
        static string ExtractText(string html)
        {
            StringBuilder replaced = new StringBuilder();
            replaced.Append("Title:");
            //extract title
            int startTitle = html.LastIndexOf("<title>");
            int endTitle=html.IndexOf("</title>");
            for (int i = startTitle+7; i < endTitle; i++)
			{
			    replaced.Append(html[i]);
			}
            replaced.Append("\r\n");

            //extract body
            int endTagIndex = html.IndexOf(">",endTitle);
            int startTagIndex = html.IndexOf("<",endTagIndex);
            replaced.Append("Body:\r\n");
            while (startTagIndex >= 0)
            {
                if (endTagIndex+1!=startTagIndex)//not to go throug empty tags ></
                {
                    for (int i = endTagIndex + 1; i < startTagIndex; i++)
                    {
                        replaced.Append(html[i]);
                    }
                    replaced.Append(" "); 
                }
                endTagIndex = html.IndexOf(">",endTagIndex+1);
                startTagIndex = html.IndexOf("<", endTagIndex);
            }
            return replaced.ToString();
        }
    }
}
