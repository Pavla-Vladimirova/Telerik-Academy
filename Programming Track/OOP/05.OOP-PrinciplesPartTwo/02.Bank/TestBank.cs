using System;
using System.Linq;

//02.A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces,
//base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
//I chose Simple Interest = number_months * interest_rate * balance
namespace _02.Bank
{
    class TestBank
    {
        static void Main(string[] args)
        {
            Individual person = new Individual("Ivan","Georgiev","ulica Car Boris","099 999 999");
            Console.WriteLine(person);
            Company company = new Company("Peter Industries","Peter","Draganov","ulica Pirotska","088 888 888");
            Console.WriteLine(company);
            //Test Calculation of Interest
            Account[] accounts = new Account[]
            {
                new LoanAccount(person,100m,6), 
                new LoanAccount(company,40000m,7),
                new DepositAccount(person,800m,6),
            };

            foreach (Account item in accounts)
            {
               Console.WriteLine("Account = {0} Interest = {1:F2}",
               item.GetType().Name.PadRight(9, ' '),
               item.CalculateInterest(8));
            }

            //Test Withdraw and Deposit
            DepositAccount depositAcc = new DepositAccount(person, 800, 5);
            depositAcc.WithDraw(200);
            Console.WriteLine(depositAcc.Balance);
            depositAcc.Deposit(900);
            Console.WriteLine(depositAcc.Balance);
        }
    }
}
