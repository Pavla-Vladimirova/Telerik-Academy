using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AttributeVersion
{
    [Version(2,11)]
    class TestAttribute
    {
        static void Main(string[] args)
        {
            Type type = typeof(TestAttribute);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine(
                  "This class is Version: {0} ", attr.MajorMinor);
            }
        }
    }
}
