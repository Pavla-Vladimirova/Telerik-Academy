using System;


namespace _4.NumbersSequence2
{
    class NumberSequence2
    {
        static void Main()
        {
            int s=1;
            for (int i = 2; i <=10; i++ )
            { 
                Console.WriteLine(i*s);
                s = s * (-1);
            }  
        }
    }
}
