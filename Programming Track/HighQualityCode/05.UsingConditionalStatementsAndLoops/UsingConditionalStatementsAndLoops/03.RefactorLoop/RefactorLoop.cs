using System;
using System.Linq;

namespace _03.RefactorLoop
{
    class RefactorLoop
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int expectedValue = 0;
            bool isFound = false;

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isFound = true;
                        break;
                    }
                }
                Console.WriteLine(array[i]);
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
