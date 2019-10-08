using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class HumanResourcesManager
    {
        private readonly float _hourlyWage;
        protected float MonthSalary;

        protected HumanResourcesManager(float hourlyWage)
        {
            _hourlyWage = hourlyWage;
            MonthSalary = CalculateMonthSalary();
        }

        public void Salary()
        {
            ShowMonthlySalary(1);
            ShowMonthlySalary(12);
            ShowAnnualSalary();
            ShowBonus();
        }

        protected abstract void ShowMonthlySalary(int month);
        protected abstract void ShowAnnualSalary();
        protected abstract void ShowBonus();

        protected float CalculateMonthSalary()
        {
            return 120 * _hourlyWage;
        }
    }
}
