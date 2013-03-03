using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ExtensionsOfIEnumerable
{
    public static class IEnumerableExtensions
    {
        public static dynamic Sum<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum=0;
            foreach (var item in enumeration)
            {
                sum += item;
            }
            return sum;
        }

        public static dynamic Product<T>(this IEnumerable<T> enumeration)
        {
            dynamic product=1;
            foreach (var item in enumeration)
            {
                product *= item;
            }
            return product;
        }

        public static dynamic Average<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum = 0;
            foreach (var item in enumeration)
            {
                sum += item;
            }
            return sum/2.0;
        }

        public static T Max<T>(this IEnumerable<T> enumeration)
            where T:IComparable
        {
            T maximum = enumeration.ElementAtOrDefault(0);
            foreach (var item in enumeration)
            {
                if (maximum.CompareTo(item)==-1)
                {
                    maximum = item;
                }
            }
            return maximum;
        }

        public static T Min<T>(this IEnumerable<T> enumeration)
           where T : IComparable
        {
            T minimum = enumeration.ElementAtOrDefault(0);
            foreach (var item in enumeration)
            {
                if (minimum.CompareTo(item) == 1)
                {
                    minimum = item;
                }
            }
            return minimum;
        }
    }
}
