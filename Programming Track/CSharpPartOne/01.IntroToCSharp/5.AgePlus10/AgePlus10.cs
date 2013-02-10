using System;


namespace _5.AgePlus10
{
    class AgePlus10
    {
        static void Main()
        {
            Console.WriteLine("Your age now is:");
            string AgeNow = Console.ReadLine();
            int num = int.Parse(AgeNow);
            DateTime AgeInTenYears = new DateTime(num,1,1);
            AgeInTenYears = AgeInTenYears.AddYears(10);
            Console.WriteLine(AgeInTenYears.Year);
        }
    }
}
