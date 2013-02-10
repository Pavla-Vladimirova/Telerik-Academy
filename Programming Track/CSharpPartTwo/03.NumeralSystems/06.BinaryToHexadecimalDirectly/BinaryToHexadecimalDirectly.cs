using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHexadecimalDirectly
{
    class BinaryToHexadecimalDirectly
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number in binary");
            string numberInBinary = Console.ReadLine();       
            List<char> numberInHexadecimal = new List<char>();
            int counterPos = 0;          
            if (numberInBinary.Length%4!=0)
            {
                string plusZeros=new String('0',4-numberInBinary.Length%4);
                numberInBinary = plusZeros + numberInBinary;
            }

            for (int j = 0; j < numberInBinary.Length/4; j++)
            {
                int b = counterPos;                
                int number = 0;
                int power = 0;
                for (int i = counterPos; i < b+4; i++)
                {
                    number += (((int)(numberInBinary[numberInBinary.Length-1- i]) - (int)'0') * (int)Math.Pow(2,power));
                    counterPos++;
                    power++;
                }
                switch (number)
                {
                    case 10: numberInHexadecimal.Add('A'); break;
                    case 11: numberInHexadecimal.Add('B'); break;
                    case 12: numberInHexadecimal.Add('C'); break;
                    case 13: numberInHexadecimal.Add('D'); break;
                    case 14: numberInHexadecimal.Add('E'); break;
                    case 15: numberInHexadecimal.Add('F'); break;
                    default: numberInHexadecimal.Add(Convert.ToChar(Convert.ToString(number))); break;
                }
            }
            numberInHexadecimal.Reverse();
            for (int i = 0; i < numberInHexadecimal.Count; i++)
            {
                Console.Write(numberInHexadecimal[i]);
            }
            Console.WriteLine();   
        }
    }
}
