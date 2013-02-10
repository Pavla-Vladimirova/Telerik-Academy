using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _19.ExtractDatesFromText
{
    class ExtractDatesFromText
    {
        static void Main(string[] args)
        {
            string inputText = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1991 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9)";
            List<string> outputDates = ExtractDates(inputText);
            Thread.CurrentThread.CurrentCulture =CultureInfo.GetCultureInfo("en-CA");
            Console.WriteLine("The extracted dates in format DD.MM.YYYY are:");
            for (int i = 0; i < outputDates.Count; i++)
            {
                Console.WriteLine("{0:d}",DateTime.Parse(outputDates[i]));
            }
        }

        static List<string> ExtractDates(string text)
        {
            Match match = Regex.Match(text, @"(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[012])\.(19|20)\d\d", RegexOptions.IgnoreCase);
            List<string> dates = new List<string>();
            while (match.Success)
            {
                dates.Add(match.Value);
                match = match.NextMatch();
            }
            return dates;
        }
    }
}
