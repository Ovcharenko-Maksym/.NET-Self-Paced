using System;

namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal amount, int period) : base(amount, period) { }

        public override decimal Income()
        {
            decimal totalIncome = 0;
            decimal currentAmount = Amount;

            for (int i = 1; i <= Period; i++)
            {
                if (i > 6)
                {
                    decimal monthlyIncome = currentAmount * 0.15m;
                    totalIncome += monthlyIncome;
                    currentAmount += monthlyIncome;
                }
            }

            return Math.Round(totalIncome, 2);
        }
    }
}