using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18.ExtractAllEmailAddressesFromText
{
    class ExtractAllEmailAddressesFromText
    {
        static void Main(string[] args)
        {
            string inputText = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            List<string> outputEmails=ExtractEmails(inputText);
            for (int i = 0; i < outputEmails.Count; i++)
            {
                Console.WriteLine(outputEmails[i]);
            }
        }

        static List<string> ExtractEmails(string text)
        {
            Match match = Regex.Match(text, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", RegexOptions.IgnoreCase);
            List<string> emails = new List<string>();
            while (match.Success)
            {
                emails.Add(match.Value);
                match =match.NextMatch();
            }
            return emails;
        }
    }
}
