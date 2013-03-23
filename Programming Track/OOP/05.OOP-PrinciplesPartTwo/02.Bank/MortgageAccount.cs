using System;
using System.Linq;

namespace _02.Bank
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance,  decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Customer is Individual)
            {
                if (numberOfMonths<=6)
                {
                    return 0;
                }
                else
                {
                    return this.Balance * this.InterestRate * (numberOfMonths - 6);
                }
            }
            else
            {
                if (numberOfMonths<=12)
                {
                    return this.Balance * this.InterestRate * numberOfMonths / 2;
                }
                else
                {
                    int x = numberOfMonths - 12;
                    return this.Balance * (this.InterestRate * (numberOfMonths-x) / 2+ this.InterestRate * x);
                }
            }
        }
    }
}
