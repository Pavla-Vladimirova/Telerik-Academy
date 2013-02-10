using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IfNumberInArrayIsBiggerThanItsNeighbours
{
    class IfNumberInArrayIsBiggerThanItsNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the length of the array");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Write elements of the array");
            int[] numbers = new int[N];
            InputNumbersInArray(numbers);
            Console.WriteLine("Write the index of whose elemnt you want to check if its bigger");
            int elementIndex = int.Parse(Console.ReadLine());
            
            PrintArray(numbers);
            IsBiggerThanItsNeighbours(elementIndex,numbers);
        }

        static void IsBiggerThanItsNeighbours(int index,int[] array)
        {
            if (array.Length==1)
            {
                Console.WriteLine("This is the only element");
                return;
            }
            if (index==0)
            {
                if (array[index]>array[1])
                {
                    Console.WriteLine("The element is first and it's bigger than the second element");
                }
                else
                {
                    Console.WriteLine("The element is first but it's not bigger than the second element");
                }
            }
            else if (index==array.Length-1)
            {
                if (array[index]>array[array.Length-2])
                {
                    Console.WriteLine("The element is last and it's bigger than the previous element");
                }
                else
                {
                    Console.WriteLine("The element is last but it's not bigger than the previous element");
                }
            }
            else 
            {
                if ((array[index]>array[index-1])&&(array[index]>array[index+1]))
                {
                    Console.WriteLine("The element is bigger than its two neighbours");
                }
                else
                {
                    Console.WriteLine("The element it's not bigger than any of its neighbours");
                }
            }
            return;
        }

        static void InputNumbersInArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
            return;
        }
    }
}
