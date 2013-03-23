using System;
using System.Linq;

namespace _02.Bank
{
    public class DepositAccount : Account,IWithDrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if ((this.Balance>0)&&(this.Balance<=1000))
            {
                return 0;
            }
            else
            {
                return this.Balance * this.InterestRate * numberOfMonths;
            }
        }

        public void WithDraw(decimal sum)
        {
            if (sum>this.Balance)
            {
                Console.WriteLine("You cannot withdraw such amount of money");
            }
            else
            {
                this.Balance -= sum;
            }
        }
    }
}
