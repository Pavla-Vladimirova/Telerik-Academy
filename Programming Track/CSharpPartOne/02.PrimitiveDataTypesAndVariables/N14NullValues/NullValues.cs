using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14NullValues
{
    class NullValues
    {
        static void Main(string[] args)
        {
            int? intValue = null; 
            double? doubleValue = null;
            Console.WriteLine("At the moment the integer value is null={0} ",intValue);
            Console.WriteLine("At the moment the double value is null={0} ",doubleValue);
            intValue = 4;
            doubleValue = 5;
            Console.WriteLine("Now the integer value is={0}",intValue);
            Console.WriteLine("Now the double value is={0}", doubleValue);
        }
    }
}
