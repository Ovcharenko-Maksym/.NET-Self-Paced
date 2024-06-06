using System;

namespace Aggregation
{
    public class Client
    {
        private readonly Deposit[] deposits;

        public Client()
        {
            deposits = new Deposit[10];
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
    }
}