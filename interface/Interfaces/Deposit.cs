using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public abstract class Deposit : IComparable<Deposit>
    {
        protected decimal amount;
        protected int period;

        public decimal Amount => amount;
        public int Period => period;

        public Deposit(decimal depositAmount, int depositPeriod)
        {
            amount = depositAmount;
            period = depositPeriod;
        }

        public abstract decimal Income();

        public decimal TotalAmount()
        {
            return amount + Income();
        }

        public int CompareTo(Deposit other)
        {
            return this.TotalAmount().CompareTo(other.TotalAmount());
        }
    }

}
