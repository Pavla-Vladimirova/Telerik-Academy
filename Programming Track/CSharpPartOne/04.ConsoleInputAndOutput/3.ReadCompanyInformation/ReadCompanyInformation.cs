using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ReadCompanyInformation
{
    class ReadCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a company's name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Write a company's address");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Write a company's phone number");
            string companyPhoneNum = Console.ReadLine();
            Console.WriteLine("Write a company's fax number");
            string companyFaxNum = Console.ReadLine();
            Console.WriteLine("Write a company's website");
            string companyWebSite = Console.ReadLine();
            Console.WriteLine("Write manager's first name");
            string managerfirstName = Console.ReadLine();
            Console.WriteLine("Write manager's last name");
            string managerlastName = Console.ReadLine();
            Console.WriteLine("Write manager's age");
            string managerAge = Console.ReadLine();
            Console.WriteLine("Write manager's phone number");
            string mangerPhoneNum = Console.ReadLine();

            Console.WriteLine("Company's \n name: {0}\n address: {1}\n phone number: {2}\n fax number: {3}\n web site: {4}\n ", companyName, companyAddress, companyPhoneNum, companyFaxNum, companyWebSite);
            Console.WriteLine("Manager's \n first name: {0}\n last name: {1}\n age: {2} \n phone number: {3}", managerfirstName, managerlastName, managerAge, mangerPhoneNum);
        }
    }
}
