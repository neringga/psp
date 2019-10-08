using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class SeniorFullStackDeveloper: FullStackDeveloper
    {
        private readonly float _bonus = 150;

        protected SeniorFullStackDeveloper(float hourlyWage) : base(hourlyWage)
        {
        }

        protected override void ShowMonthlySalary(int month)
        {
            var bonusMonth = month % 3 == 0;
            var monthSalary = bonusMonth ? MonthSalary + _bonus : MonthSalary;

            Console.WriteLine($"Senior {month} month salary: {monthSalary}");
        }

        protected override void ShowAnnualSalary()
        {
            var annualSalary = 12 * MonthSalary + 4 * _bonus;
            Console.WriteLine($"Senior annual salary: {annualSalary}");
        }

        protected override void ShowBonus()
        {
            Console.WriteLine($"Senior bonus: {_bonus}");
        }
    }
}
