using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        //Checking the array here in the public method, no need to check in the private methods
        Debug.Assert(arr != null, "The input array does not refer to any object");
        Debug.Assert(arr.Length > 0, "The array has no elements");

        for (int index = 0; index < arr.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        //Test the indicies here if we have written wrong logic in public method SelectionSort
        Debug.Assert(startIndex >= 0, "Not a valid index!.The start index cannot be smaller than zero");
        Debug.Assert(endIndex >= 0, "Not a valid index!.The end index cannot be smaller than zero");
        Debug.Assert(startIndex <= endIndex, "The start index cannot be bigger than the end index");
        
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        Debug.Assert(arr.Min() == arr[minElementIndex], "The element" + arr[minElementIndex] + "is not the minimal element");
        return minElementIndex;
        
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        //There is no need to check something here,as the array is already checked(it is not null,or empty)
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        //Checking the array here in the public method, no need to check in the private methods
        Debug.Assert(arr != null, "The input array does not refer to any object");
        Debug.Assert(arr.Length > 0, "The array has no elements");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        //Test the indicies here if we have written wrong logic in public method BinarySearch
        Debug.Assert(startIndex >= 0, "Not a valid index!.The start index cannot be smaller than zero");
        Debug.Assert(endIndex >= 0, "Not a valid index!.The end index cannot be smaller than zero");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array
        int[] nullArray = null;
        SelectionSort(nullArray); // Test null reference

        Console.WriteLine(BinarySearch(new int[0], -1000)); //Test empty array in Binary search
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
