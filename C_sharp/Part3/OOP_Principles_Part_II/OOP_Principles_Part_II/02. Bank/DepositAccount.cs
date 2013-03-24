using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankScope
{
    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal withdraw)
        {
            if (this.Balance < withdraw)
            {
                throw new Exception("No money in the account for withdraw.");
            }
            this.Balance -= withdraw;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
