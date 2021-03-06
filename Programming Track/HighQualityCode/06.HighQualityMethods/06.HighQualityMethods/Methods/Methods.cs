﻿using System;

class Methods
{
    static double CalcTriangleArea(double a, double b, double c)
    {
        if (((a<(b+c))||(b<(a+c))||(c<(a+b))))
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
        else if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Input parameters should be bigger than zero!");
        }
        else
        {
            throw new ArgumentException("Input parameters do not form a triangle!");
        }
            
    }

    static string NumberToDigit(int number)
    {
        switch (number)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default : throw new ArgumentException("The input parameter is not a digit!");
        }
    }

    static int FindMaxNumber(params int[] elements)
    {
        if (elements == null || elements.Length == 0)
        {
            throw new ArgumentException("The input array is either null or it has no elements!");
        }
        int maxNumber = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] > maxNumber)
            {
                maxNumber = elements[i];
            }
        }
        return maxNumber;
    }

    static void PrintNumberWithFormattedDecimalDigits(object number) 
    {
        Console.WriteLine("{0:f2}", number);
    }

    static void PrintNumberAsPercentage(object number) 
    {
        Console.WriteLine("{0:p0}", number);
    }

    static void PrintNumberWithAlignment(object number)
    {
        Console.WriteLine("{0,8}", number);
    }


    static double CalcDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        return distance;
    }

    static bool IsHorizontal(double y1, double y2) 
    {
        if (y1==y2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool IsVertical(double x1, double x2)
    {
        if (x1 == x2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
        Console.WriteLine(NumberToDigit(5));
            
        Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

        PrintNumberWithFormattedDecimalDigits(1.3);
        PrintNumberAsPercentage(0.75);
        PrintNumberWithAlignment(2.30);

        Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
        Console.WriteLine("Horizontal? " + IsHorizontal(-1, 2.5));
        Console.WriteLine("Vertical? " + IsVertical(3, 3));

        Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
        peter.OtherInfo = "From Sofia, born at 17.03.1992";

        Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
        stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

        Console.WriteLine("{0} older than {1} -> {2}",
            peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
    }
}
