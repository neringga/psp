using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class PaymentStrategy: IPaymentStrategy
    {
        private float _hourlyWage;

        protected PaymentStrategy(float hourlyWage)
        {
            _hourlyWage = hourlyWage;
        }

        public abstract void ShowMonthlySalary(int month);
        public abstract void ShowAnnualSalary();
        public abstract void ShowBonus();

        protected float CalculateMonthSalary()
        {
            return 120 * _hourlyWage;
        }
    }
}
