using System;

namespace Course.Entities
{
    class SavingAccountPlus : SavingAccount
    {
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 3;
        }
    }
}