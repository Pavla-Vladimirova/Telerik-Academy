using System;
using System.Linq;

class Converter
{
    const int MAX_COUNT = 6;

    class StringConverter
    {
        public void BoolToString(bool objectToConvert)
        {
            string objectAsString = objectToConvert.ToString();
            Console.WriteLine(objectAsString);
        }
    }

    public static void Input()
    {
        Converter.StringConverter objectToConvert = new Converter.StringConverter();
        objectToConvert.BoolToString(true);
    }
}

