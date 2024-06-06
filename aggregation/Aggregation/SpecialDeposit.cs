using System;

namespace Aggregation
{
    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal amount, int period) : base(amount, period) { }

        public override decimal Income()
        {
            decimal totalIncome = 0;
            decimal currentAmount = Amount;

            for (int i = 1; i <= Period; i++)
            {
                decimal monthlyIncome = currentAmount * (i / 100m);
                totalIncome += monthlyIncome;
                currentAmount += monthlyIncome;
            }

            return Math.Round(totalIncome, 2);
        }
    }
}