using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankScope
{
    public abstract class Account
    {
        public Customer customer;
        public decimal balance;
        public decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public void Deposit(decimal deposit)
        {
            this.Balance += deposit;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * this.InterestRate * months;
        }

        public override string ToString()
        {
            StringBuilder accountInfo = new StringBuilder();
            accountInfo.AppendFormat("Account Typ1e: {0}\n{1}Balance: {2}\nInterest Rate: {3:P2}",
                this.GetType().Name, this.Customer, this.Balance, this.InterestRate);
            return accountInfo.ToString();
        }
    }
}
