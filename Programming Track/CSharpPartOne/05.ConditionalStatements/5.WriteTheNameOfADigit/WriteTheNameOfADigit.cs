﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WriteTheNameOfADigit
{
    class WriteTheNameOfADigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a digit (0-9)");
            byte digit = byte.Parse(Console.ReadLine());
            switch (digit)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: Console.WriteLine("zero");
                    break;
            }
        }
    }
}
