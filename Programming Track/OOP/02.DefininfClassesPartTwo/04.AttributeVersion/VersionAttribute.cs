using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AttributeVersion
{
    [AttributeUsage(AttributeTargets.Struct |  AttributeTargets.Class | AttributeTargets.Interface,AllowMultiple = true)]
    public class VersionAttribute: System.Attribute
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public string MajorMinor { get; set; }

        public VersionAttribute(int major,int minor)
        {
            this.Major = major;
            this.Minor = minor;
            this.MajorMinor = Major +"."+ Minor;
        }
    }
}
