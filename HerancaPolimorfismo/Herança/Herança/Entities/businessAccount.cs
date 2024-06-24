using System;

namespace Course.Entities
{
    class businessAccount : Account
    {
        public double LoanLimit { get; set; }

        public businessAccount() { 
            
        }

        public businessAccount(int number, string holder, double Balance, double loanLimit) 
            : base(number, holder, Balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
