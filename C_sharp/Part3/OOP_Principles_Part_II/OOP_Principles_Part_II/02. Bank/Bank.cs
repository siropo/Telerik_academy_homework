using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankScope
{
    public class Bank
    {
        private List<Account> accounts;
        public string Name { get; set; }

        public Bank(string name)
        {
            this.Name = name;
            this.accounts = new List<Account>();
        }

        public List<Account> Accounts
        {
            get
            {
                return this.accounts;
            }
        }

        public void AddAccount(Account account)
        {
            this.Accounts.Add(account);
        }
    }
}
