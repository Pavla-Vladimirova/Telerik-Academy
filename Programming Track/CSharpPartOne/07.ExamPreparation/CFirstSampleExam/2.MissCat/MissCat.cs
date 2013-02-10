using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            int cat1 = 0;
            int cat2 = 0;
            int cat3 = 0;
            int cat4 = 0;
            int cat5 = 0;
            int cat6 = 0;
            int cat7 = 0;
            int cat8 = 0;
            int cat9 = 0;
            int cat10 = 0;

            for (int i = 1; i <= N; i++)
            {
                int cat = int.Parse(Console.ReadLine());
                if (cat == 1)
                {
                    cat1++;
                }
                else if (cat == 2)
                {
                    cat2++;
                }
                else if (cat == 3)
                {
                    cat3++;
                }
                else if (cat == 4)
                {
                    cat4++;
                }
                else if (cat == 5)
                {
                    cat5++;
                }
                else if (cat == 6)
                {
                    cat6++;
                }
                else if (cat == 7)
                {
                    cat7++;
                }
                else if (cat == 8)
                {
                    cat8++;
                }
                else if (cat == 9)
                {
                    cat9++;
                }
                else
                {
                    cat10++;
                }
            }

            int max = cat1;
            int catNumber = 1;
            if (cat2 > max)
            {
                max = cat2;
                catNumber = 2;
            }
            if (cat3 > max)
            {
                max = cat3;
                catNumber = 3;
            }
            if (cat4 > max)
            {
                max = cat4;
                catNumber = 4;
            }
            if (cat5 > max)
            {
                max = cat5;
                catNumber = 5;
            }
            if (cat6 > max)
            {
                max = cat6;
                catNumber = 6;
            }
            if (cat7 > max)
            {
                max = cat7;
                catNumber = 7;
            }
            if (cat8 > max)
            {
                max = cat8;
                catNumber = 8;
            }
            if (cat9 > max)
            {
                max = cat9;
                catNumber = 9;
            }
            if (cat10 > max)
            {
                max = cat10;
                catNumber = 10;
            }
            Console.WriteLine(catNumber);
        }
    }
}
