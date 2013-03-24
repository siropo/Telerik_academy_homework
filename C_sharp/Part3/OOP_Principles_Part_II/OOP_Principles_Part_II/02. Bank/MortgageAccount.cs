using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankScope
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                return base.CalculateInterest(months - 6);
            }
            else
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months) / 2;
                }
                else
                {
                    return base.CalculateInterest(12) / 2 + base.CalculateInterest(months - 12);
                }
            }
        }
    }
}
