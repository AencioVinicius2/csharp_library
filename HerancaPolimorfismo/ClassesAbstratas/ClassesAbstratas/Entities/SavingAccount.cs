using System;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Course.Entities
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void updateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}