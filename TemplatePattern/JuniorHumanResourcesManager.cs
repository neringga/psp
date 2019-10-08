using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class JuniorHumanResourcesManager: HumanResourcesManager
    {
        private readonly float _bonus = 100;

        public JuniorHumanResourcesManager(float hourlyWage) : base(hourlyWage)
        {
        }

        protected override void ShowMonthlySalary(int month)
        {
            var bonusMonth = month % 6 == 0;
            var monthSalary = bonusMonth ? MonthSalary + _bonus : MonthSalary;

            Console.WriteLine($"Junior {month} month salary: {monthSalary}");
        }

        protected override void ShowAnnualSalary()
        {
            var annualSalary = 12 * MonthSalary + 2 * _bonus;

            Console.WriteLine($"Junior annual salary: {annualSalary}");
        }

        protected override void ShowBonus()
        {
            Console.WriteLine($"Junior bonus: {_bonus}");
        }
    }
}
