using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxSequenceOfAscendingNumbersInArray
{
    class MaxSequenceOfAscendingNumbersInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write array's length");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Write elements of the array");
            for (int i = 0; i < n; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }

            int counter = 1;
            int maxCounter = 0;
            int firstElement = array[0];
            int realFirstElement = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    counter++;   
                    if (counter > maxCounter) // pyrviq maxC. se pomni za 1-vata,dokato countera na tekushtat proverqvana redica ne stane po golqm ot predishniq maxC.,ne se vliza v tozi IF,sled tova veshe realEL=zapomneniq posleden RAZLICHEN
                    {
                        realFirstElement=firstElement;
                        maxCounter = counter;
                    }  
                }
                else // vliza chak kogato elementa e razlichen,kolkoto pyti e razlichen tolkova pyti se proverqva tova uslovie i posledniqt proveren RAZLICHEN element stava firstElement,counter-a se nulira
                {
                    firstElement = array[i];
                    counter = 1;
                }
            }

            Console.WriteLine("The length of the sequence is {0} from elment {1} ",maxCounter,realFirstElement);

        }
    }
}
