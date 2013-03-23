using System;
using System.Linq;

namespace _02.Bank
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Customer is Individual)
            {
                if (numberOfMonths <= 3)
                {
                    return 0;
                }
                else
                {
                    return this.Balance * this.InterestRate * (numberOfMonths - 3);
                }
            }
            else
            {
                if (numberOfMonths <= 2)
                {
                    return 0;
                }
                else
                {
                    return this.Balance * this.InterestRate * (numberOfMonths - 2);
                }
            }
           
        }
    }
}
