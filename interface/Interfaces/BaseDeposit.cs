using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

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
