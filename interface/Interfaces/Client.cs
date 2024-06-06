using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Client : IEnumerable<Deposit>
    {
        private readonly Deposit[] deposits;

        public Client()
        {
            deposits = new Deposit[10]; // default size
        }

        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            }
            return false;
        }

        public decimal TotalIncome()
        {
            decimal totalIncome = 0;
            foreach (Deposit deposit in deposits)
            {
                if (deposit != null)
                {
                    totalIncome += deposit.Income();
                }
            }
            return totalIncome;
        }


        public decimal MaxIncome()
        {
            decimal maxIncome = 0;
            foreach (Deposit deposit in deposits)
            {
                if (deposit != null)
                {
                    decimal income = deposit.Income();
                    if (income > maxIncome)
                    {
                        maxIncome = income;
                    }
                }
            }
            return maxIncome;
        }

        public decimal GetIncomeByNumber(int number)
        {
            if (number >= 1 && number <= 10 && deposits[number - 1] != null)
            {
                return deposits[number - 1].Income();
            }
            return 0;
        }

        public int CountPossibleToProlongDeposit()
        {
            int count = 0;
            foreach (Deposit deposit in deposits)
            {
                if (deposit is IProlongable && ((IProlongable)deposit).CanToProlong())
                    count++;
            }
            return count;
        }

        public void SortDeposits()
        {
            Array.Sort(deposits);
            Array.Reverse(deposits);
        }

        public IEnumerator<Deposit> GetEnumerator()
        {
            foreach (Deposit deposit in deposits)
            {
                yield return deposit;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
