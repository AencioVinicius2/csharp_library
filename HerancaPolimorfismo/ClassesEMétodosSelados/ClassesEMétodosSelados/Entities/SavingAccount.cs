using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Course.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void updateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override sealed void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
