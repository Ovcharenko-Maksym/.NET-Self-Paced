using System;

namespace Aggregation
{
    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal amount, int period) : base(amount, period) { }

        public override decimal Income()
        {
            decimal totalIncome = 0;
            decimal currentAmount = Amount;

            for (int i = 0; i < Period; i++)
            {
                decimal monthlyIncome = currentAmount * 0.05m;
                totalIncome += monthlyIncome;
                currentAmount += monthlyIncome;
            }

            return Math.Round(totalIncome, 2);
        }
    }
}