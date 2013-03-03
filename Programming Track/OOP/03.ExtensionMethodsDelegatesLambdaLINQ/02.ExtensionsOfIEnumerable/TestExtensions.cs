using System;
using System.Collections.Generic;
using System.Linq;

//02.Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace _02.ExtensionsOfIEnumerable
{
    class TestExtensions
    {
        static void Main(string[] args)
        {
            List<int> intNumbers = new List<int> { 9, 2, -3, 7, 4, 5 };
            //Sum
            Console.WriteLine("The sum is: {0}",intNumbers.Sum<int>());
            //Product
            Console.WriteLine("The profuct is: {0}", intNumbers.Product<int>());
            //Average
            Console.WriteLine("The average sum is: {0}", intNumbers.Average<int>());
            //Max
            Console.WriteLine("The maximum element is: {0}", intNumbers.Max<int>());
            //Min 
            Console.WriteLine("The minimum element is: {0}", intNumbers.Min<int>());
        }
    }
}
