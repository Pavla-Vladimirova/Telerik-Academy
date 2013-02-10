using System;

namespace N9QuotedString
{
    class QuotedString
    {
        static void Main(string[] args)
        {
            string withEscapingSymbol;
            string quotedString;
            withEscapingSymbol="The \"use\" of quotations causes difficulties.";
            Console.WriteLine(withEscapingSymbol);
            quotedString= @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quotedString);
        }
    }
}
 