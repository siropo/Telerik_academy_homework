using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankScope;

namespace _02.BankDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer pesho = new IndividualCustomer("Pesho");
            IndividualCustomer goshko = new IndividualCustomer("Goshko");
            CompanyCustomer troshko = new CompanyCustomer("Troshko");

            DepositAccount depositA = new DepositAccount(pesho, 2020m, 2m);
            LoanAccount LoanA = new LoanAccount(goshko, 2200m, 3m);
            MortgageAccount MortgageA = new MortgageAccount(troshko, 2000m, 0.5m);

            Bank dsk = new Bank("---- POSTBANK -----");
            dsk.Accounts.Add(depositA);
            dsk.Accounts.Add(LoanA);
            dsk.Accounts.Add(MortgageA);

            Console.WriteLine(depositA);
            Console.WriteLine("Balance: " + depositA.Balance);
            Console.WriteLine("---- Deposite ----");
            depositA.Deposit(1000m);
            Console.WriteLine("Balance: " + depositA.Balance);
            Console.WriteLine("---- Withdraw ----");
            depositA.Withdraw(1200m);
            Console.WriteLine("Balance: " + depositA.Balance);

            Console.WriteLine();

            Console.WriteLine(LoanA);
            Console.WriteLine("Balance: " + LoanA.Balance);
            Console.WriteLine("---- Deposite ----");
            LoanA.Deposit(8000m);
            Console.WriteLine("Balance: " + LoanA.Balance);

            Console.WriteLine();

            Console.WriteLine(MortgageA);
            Console.WriteLine("Balance: " + MortgageA.Balance);
            Console.WriteLine("---- Deposite ----");
            MortgageA.Deposit(200m);
            Console.WriteLine("Balance: " + MortgageA.Balance);

            Console.WriteLine();

            Console.WriteLine(depositA.CalculateInterest(24));
            Console.WriteLine(LoanA.CalculateInterest(24));
            Console.WriteLine(MortgageA.CalculateInterest(24));
        }
    }
}
