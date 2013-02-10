using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplaceTagsWithOtherTagsInHTMLdocument
{
    class ReplaceTagsWithOtherTagsInHTMLdocument
    {
        static void Main(string[] args)
        {
            string inputHTML="<p>Please visit <a href=\"http://academy.telerik.com\"> our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\"> our forum</a> to discuss the courses.</p>";
            Console.WriteLine(ReplaceTags(inputHTML)); 
        }

        static string ReplaceTags(string html)
        {
            int startIndexOfFirstTag = html.IndexOf("<a href=");
            int lastIndexOfFirstTag = 0;
            StringBuilder replaced = new StringBuilder();
            replaced.Append(html);
            while (startIndexOfFirstTag >=0)
            {
                lastIndexOfFirstTag = html.IndexOf(">", startIndexOfFirstTag);
                for (int i = lastIndexOfFirstTag; i < lastIndexOfFirstTag+1; i++)
                {
                    replaced = replaced.Replace("\">","]");
                }
                startIndexOfFirstTag = html.IndexOf("<a href=",startIndexOfFirstTag+1);
            }
            replaced = replaced.Replace("<a href=\"", "[URL=");
            replaced = replaced.Replace("</a>", "[/URL]");
           return replaced.ToString();
        }
    }
}
