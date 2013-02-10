using System;


namespace N13ExchangeTwoVariables
{
    class ExchangeTwoVariables
    {
        static void Main(string[] args)
        {
            int firstNum = 5;
            int secondNum = 10;
            int swapingVar;
            swapingVar=secondNum;
            secondNum = firstNum;
            firstNum = swapingVar;
            Console.WriteLine(firstNum + " " + secondNum);
        }
    }
}
