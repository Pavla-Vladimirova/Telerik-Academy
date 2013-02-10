using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HelloUser
{
   public class HelloUser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name");
            string yourName = Console.ReadLine();
            Console.WriteLine(HelloReader(yourName));
        }

        public static string HelloReader(string name)
        {
            string result = "Hello " + name + "!";
            return result;
        }
    }
}
