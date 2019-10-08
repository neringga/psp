using System;

namespace StrategyPattern
{
    public class SeniorPayment: PaymentStrategy
    {
        private float _monthSalary;
        private readonly float _bonus = 150;

        public SeniorPayment(float hourlyWage): base(hourlyWage)
        {
            _monthSalary = CalculateMonthSalary();
        }

        public override void ShowMonthlySalary(int month)
        {
            var bonusMonth = month % 3 == 0;
            var monthSalary = bonusMonth ? _monthSalary + _bonus : _monthSalary;

            Console.WriteLine($"Senior {month} month salary: {monthSalary}");
        }

        public override void ShowAnnualSalary()
        {
            var annualSalary = 12 * _monthSalary + 4 * _bonus;
            Console.WriteLine($"Senior annual salary: {annualSalary}");
        }

        public override void ShowBonus()
        {
            Console.WriteLine($"Senior bonus: {_bonus}");
        }
    }
}
