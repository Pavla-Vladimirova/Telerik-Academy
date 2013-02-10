using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintAllPossible52CardsFromStandartDeck
{
    class PrintAllPossible52CardsFromStandartDeck
    {
        static void Main(string[] args)
        {
            string choice = "";
            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1: choice="Clubs";
                            break;
                    case 2: choice="Diamonds";
                            break;
                    case 3: choice="Hearts";
                            break;
                    case 4: choice="Spades";
                            break;
                }
                for (int j = 2; j <= 14; j++)
                {
                    switch (j)
                    {
                        case 2: Console.WriteLine(choice + " 2"); break;
                        case 3: Console.WriteLine(choice + " 3"); break;
                        case 4: Console.WriteLine(choice + " 4"); break;
                        case 5: Console.WriteLine(choice + " 5"); break;
                        case 6: Console.WriteLine(choice + " 6"); break;
                        case 7: Console.WriteLine(choice + " 7"); break;
                        case 8: Console.WriteLine(choice + " 8"); break;
                        case 9: Console.WriteLine(choice + " 9"); break;
                        case 10: Console.WriteLine(choice + " 10"); break;
                        case 11: Console.WriteLine(choice + " Jack"); break;
                        case 12: Console.WriteLine(choice + " Qeen"); break;
                        case 13: Console.WriteLine(choice + " King"); break;
                        case 14: Console.WriteLine(choice + " Ace"); break;
                    }
                }
            }
        }
    }
}
