using System;
using System.Linq;


public static class Statistics
{
    public static void PrintStatisticsOfArray(double[] numbers, int numbersCounter)
    {
        Console.WriteLine("The maximum number is: {0}",FindMaximumNumber(numbers, numbersCounter));
        Console.WriteLine("The minimum number is: {0}", FindMinimumNumber(numbers, numbersCounter));
        Console.WriteLine("The average sum of all numbers is: {0}", FindtAverageSumOfNumbers(numbers, numbersCounter)); 
    }

    private static double FindMaximumNumber(double[] numbers, int numbersCounter)
    {
        double maxNumber=double.MinValue;
        for (int i = 0; i < numbersCounter; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        return maxNumber;
    }
    private static double FindMinimumNumber(double[] numbers, int numbersCounter)
    {
        double minNumber = double.MaxValue;
        for (int i = 0; i < numbersCounter; i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }
        return minNumber;
    }
    private static double FindtAverageSumOfNumbers(double[] numbers, int numbersCounter)
    {
        double averageSum = 0;
        for (int i = 0; i < numbersCounter; i++)
        {
            averageSum += numbers[i];
        }
        return averageSum;
    }
}

class TestPrintStatistics
{
    static void Main(string[] args)
    {
        double[] numbers = new double[] { 1.5, 2, 3, 4.6, 5 };
        int counter = numbers.Length;
        Statistics.PrintStatisticsOfArray(numbers, counter);
    }
}

