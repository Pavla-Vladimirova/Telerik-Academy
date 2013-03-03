using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Generics
{
    public class GenericsTest
    {
        static void Main(string[] args)
        {
            // Declare a list of type int 
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(5);
            intList.Add(3);
            intList.Add(7);
            intList.Add(8);
            intList.Add(9);
            intList.Add(19);
            intList.Add(29);
            intList.Add(2);
            intList.Add(69);
            intList.Add(12);
            Console.WriteLine("Number of elements: {0}", intList.Counter);
            Console.WriteLine(intList);

            //Remove Element by index
            //intList.RemoveByIndex(2);
            //Console.WriteLine("Number of elements: {0}", intList.Count);
            //for (int i = 0; i < intList.Count; i++)
            //{
            //    int element = intList[i];
            //    Console.WriteLine(element);
            //}
            //Console.WriteLine();

            //Insert Element at given position
            intList.InsertAtGivenIndex(22, 2);
            Console.WriteLine("Number of elements: {0}", intList.Counter);
            Console.WriteLine(intList);

            //Clear all elements from the list
            //intList.ClearAll();
            //Console.WriteLine("Number of elements: {0}", intList.Count);

            //Get element by value
            intList.GetElementByValue(22);

            //Print ToString()
            Console.WriteLine(intList);

            //get minimum element
            Console.WriteLine("The minimum element is {0}",intList.GetMin());
            Console.WriteLine("The maximum element is {0}", intList.GetMax());
        }
    }
}
