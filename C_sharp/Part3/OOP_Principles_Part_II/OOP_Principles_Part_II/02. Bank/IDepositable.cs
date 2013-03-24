using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankScope
{
    public interface IDepositable
    {
        void Deposit(decimal deposit);
    }
}
