using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankScope
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                return base.CalculateInterest(months - 2);
            }
            else
            {
                return base.CalculateInterest(months - 3);
            }
        }
    }
}
