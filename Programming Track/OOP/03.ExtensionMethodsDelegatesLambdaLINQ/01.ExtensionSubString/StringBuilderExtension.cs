using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExtensionSubString
{
    public static class StringBuilderExtension
    {
        public static StringBuilder SubString(this StringBuilder str,int index,int length)
        {
            if ((index<0)||(index>=str.Length)||(index+length>str.Length))
            {
                throw new ArgumentOutOfRangeException("Index or length of substring are out of the given range");
            }
            StringBuilder result=new StringBuilder();
            for (int i =index; i < index+length; i++)
            {
                result.Append(str[i]);
            }
            return result;
        }
    }
}
