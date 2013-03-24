using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankScope
{
    public abstract class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("Customer Type: {0}\nCustomer: {1}\n", this.Name, this.Name);
        }
    }
}
