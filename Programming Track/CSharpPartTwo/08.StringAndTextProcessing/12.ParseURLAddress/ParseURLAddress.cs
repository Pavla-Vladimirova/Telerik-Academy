using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURLAddress
{
    class ParseURLAddress
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the URL");
            string inputURL = Console.ReadLine();
            Console.WriteLine(inputURL);
            string[] output=ExtractProtocolSereverAndResource(inputURL);
            Console.WriteLine("[protocol] = \"{0}\"",output[0]);
            Console.WriteLine("[server] = \"{0}\"", output[1]);
            Console.WriteLine("[resource] = \"{0}\"", output[2]);
        }

        static string[] ExtractProtocolSereverAndResource(string url)
        {
            int startIndex = 0;
            int lastIndex = 0;
            string[] extracted=new string[3];
            startIndex = url.IndexOf(":", startIndex);
            //the protocol and server
            for (int i = 0; i < 2; i++)
            {
                for (int index = lastIndex+i; index < startIndex; index++)
                {
                    extracted[i] += url[index];
                }
                lastIndex = url.LastIndexOf("/", startIndex + 3);
                startIndex = url.IndexOf("/", startIndex+3);
            }
            //the rest of the url is the resource
            for (int index = lastIndex; index < url.Length; index++)
            {
                extracted[2] += url[index];
            }
            return extracted;
        }
    }
}
