using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class MidPayment: PaymentStrategy
    {
        private float _monthSalary;
        private readonly float _bonus = 150;

        public MidPayment(float hourlyWage): base(hourlyWage)
        {
            _monthSalary = CalculateMonthSalary();
        }

        public override void ShowMonthlySalary(int month)
        {
            var bonusMonth = month % 4 == 0;
            var monthSalary = bonusMonth ? _monthSalary + _bonus : _monthSalary;

            Console.WriteLine($"Mid {month} month salary: {monthSalary}");
        }

        public override void ShowAnnualSalary()
        {
            var annualSalary = 12 * _monthSalary + 3 * _bonus;
            Console.WriteLine($"Mid annual salary: {annualSalary}");
        }

        public override void ShowBonus()
        {
            Console.WriteLine($"Mid bonus: {_bonus}");
        }
    }
}
