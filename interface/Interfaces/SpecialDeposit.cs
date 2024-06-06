using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class SpecialDeposit : Deposit, IProlongable
    {
        public SpecialDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public bool CanToProlong()
        {
            return amount > 1000;
        }

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
