using System;

namespace StrategyPattern
{
    public class JuniorPayment: PaymentStrategy
    {
        private float _monthSalary;
        private readonly float _bonus = 100;

        public JuniorPayment(float hourlyWage): base(hourlyWage)
        {
            _monthSalary = CalculateMonthSalary();
        }

        public override void ShowMonthlySalary(int month)
        {
            var bonusMonth = month % 6 == 0;
            var monthSalary = bonusMonth ? _monthSalary + _bonus : _monthSalary;

            Console.WriteLine($"Junior {month} month salary: {monthSalary}");
        }

        public override void ShowAnnualSalary()
        {
            var annualSalary = 12 * _monthSalary + 2 * _bonus;

            Console.WriteLine($"Junior annual salary: {annualSalary}");
        }

        public override void ShowBonus()
        {
            Console.WriteLine($"Junior bonus: {_bonus}");
        }
    }
}
