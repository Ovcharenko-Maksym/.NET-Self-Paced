using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class LongDeposit : Deposit, IProlongable
    {
        public LongDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public bool CanToProlong()
        {
            return period <= 36; // considering 3 years as 36 months
        }

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
