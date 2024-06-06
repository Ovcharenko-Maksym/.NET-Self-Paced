using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceTask
{
    public class Company
    {
        private readonly Employee[] employees;

        public Company(Employee[] employees)
        {
            this.employees = employees;
        }

        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee emp in employees)
            {
                emp.SetBonus(companyBonus);
            }
        }

        public decimal TotalToPay()
        {
            decimal total = 0;
            foreach (Employee emp in employees)
            {
                total += emp.ToPay();
            }
            return total;
        }

        public string NameMaxSalary()
        {
            decimal maxSalary = decimal.MinValue;
            string maxName = "";

            foreach (Employee emp in employees)
            {
                decimal salary = emp.ToPay();
                if (salary > maxSalary)
                {
                    maxSalary = salary;
                    maxName = emp.Name;
                }
            }
            return maxName;
        }
    }
}
