using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //object or instant
            var account = new Account();
            account.AccountName = "My Checking";
            account.AccountNumber = 123456;
            account.Balance = 100000;
            account.Deposit(200.45M);
            Console.WriteLine(account.Balance);

        }
    }
}
