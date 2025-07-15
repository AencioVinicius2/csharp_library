using Course.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Principal;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingAccount(1001,"Alex",500.0,0.01));
            list.Add(new SavingAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new SavingAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0;

            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account account in list)
            {
                account.Withdraw(10.0);
            }

            foreach (Account account in list)
            {
                Console.WriteLine("Updated balance for each account: "
                    + account.Number
                    + ": "
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
} 