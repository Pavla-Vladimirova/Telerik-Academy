using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShipDamage
{
    class ShipDamage
    {
        static void Main(string[] args)
        {
            int Sx1 =int.Parse(Console.ReadLine());
            int Sy1 = int.Parse(Console.ReadLine());
            int Sx2 = int.Parse(Console.ReadLine());
            int Sy2 = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int Cx1 = int.Parse(Console.ReadLine());
            int Cy1 = int.Parse(Console.ReadLine());
            int Cx2 = int.Parse(Console.ReadLine());
            int Cy2 = int.Parse(Console.ReadLine());
            int Cx3 = int.Parse(Console.ReadLine());
            int Cy3 = int.Parse(Console.ReadLine());

            Sy1 -= H;
            Sy2 -= H;
            Cy1 -= H;
            Cy2 -= H;
            Cy3 -= H;

            int reflectedCy1 = -Cy1;
            int reflectedCy2 = -Cy2;
            int reflectedCy3 = -Cy3;

            int top =Math.Max(Sy1,Sy2);
            int bottom = Math.Min(Sy1, Sy2);
            int left = Math.Min(Sx1, Sx2);
            int right = Math.Max(Sx1, Sx2);

            int damage=0;

            int currentCx = Cx1;
            int currentCy =reflectedCy1;

            if ((currentCx>left)&&(currentCy<top)&&(currentCx<right)&&(currentCy>bottom))
            {
                damage+=100;
            }
            else if (((currentCx==left)&&(currentCy==bottom)||(currentCx==right)&&(currentCy==top))||
                    ((currentCx == right) && (currentCy == bottom) || (currentCx == left) && (currentCy == top)))
	        {
		        damage+=25;
	        }
            else if ( (currentCx>left)&&(currentCy==top)&&(currentCx<right)||                       // upper length
                    (currentCx > left) && (currentCy == bottom) && (currentCx <right) ||            //lower length
                    (currentCy < top) && (currentCx ==left) && (currentCy  >bottom) ||              //left height
                    (currentCy  <top) && (currentCx ==right) && (currentCy  >bottom))               //right height
	        {
		        damage+=50;
	        }
            else 
	        {
		        damage+=0;
	        }

            currentCx =Cx2;
            currentCy =reflectedCy2;

           if ((currentCx>left)&&(currentCy<top)&&(currentCx<right)&&(currentCy>bottom))
            {
                damage+=100;
            }
            else if (((currentCx==left)&&(currentCy==bottom)||(currentCx==right)&&(currentCy==top))||
                    ((currentCx == right) && (currentCy == bottom) || (currentCx == left) && (currentCy == top)))
	        {
		        damage+=25;
	        }
            else if ( (currentCx>left)&&(currentCy==top)&&(currentCx<right)||          // upper length
                    (currentCx > left) && (currentCy == bottom) && (currentCx <right) ||            //lower length
                    (currentCy < top) && (currentCx ==left) && (currentCy  >bottom) ||   //left height
                    (currentCy  <top) && (currentCx ==right) && (currentCy  >bottom))   //right height
	        {
		        damage+=50;
	        }
            else 
	        {
		        damage+=0;
	        }

            currentCx =Cx3;
            currentCy =reflectedCy3;

            if ((currentCx>left)&&(currentCy<top)&&(currentCx<right)&&(currentCy>bottom))
            {
                damage+=100;
            }
            else if (((currentCx==left)&&(currentCy==bottom)||(currentCx==right)&&(currentCy==top))||
                    ((currentCx == right) && (currentCy == bottom) || (currentCx == left) && (currentCy == top)))
	        {
		        damage+=25;
	        }
            else if ( (currentCx>left)&&(currentCy==top)&&(currentCx<right)||          // upper length
                    (currentCx > left) && (currentCy == bottom) && (currentCx <right) ||            //lower length
                    (currentCy < top) && (currentCx ==left) && (currentCy  >bottom) ||   //left height
                    (currentCy  <top) && (currentCx ==right) && (currentCy  >bottom))   //right height
	        {
		        damage+=50;
	        }
            else 
	        {
		        damage+=0;
	        }
                                
            Console.WriteLine("{0:###%}",(double)damage/100);
        }
    }
}
