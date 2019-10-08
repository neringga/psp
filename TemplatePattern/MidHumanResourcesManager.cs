using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class MidHumanResourcesManager: HumanResourcesManager
    {
        private readonly float _bonus = 150;

        public MidHumanResourcesManager(float hourlyWage) : base(hourlyWage)
        {
        }

        protected override void ShowMonthlySalary(int month)
        {
            var bonusMonth = month % 4 == 0;
            var monthSalary = bonusMonth ? MonthSalary + _bonus : MonthSalary;

            Console.WriteLine($"Mid {month} month salary: {monthSalary}");
        }

        protected override void ShowAnnualSalary()
        {
            var annualSalary = 12 * MonthSalary + 3 * _bonus;
            Console.WriteLine($"Mid annual salary: {annualSalary}");
        }

        protected override void ShowBonus()
        {
            Console.WriteLine($"Mid bonus: {_bonus}");
        }
    }
}
