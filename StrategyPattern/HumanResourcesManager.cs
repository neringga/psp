using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class HumanResourcesManager
    {
        private IPaymentStrategy _paymentStrategy;

        public HumanResourcesManager(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Salary()
        {
            _paymentStrategy.ShowMonthlySalary(1);
            _paymentStrategy.ShowMonthlySalary(12);
            _paymentStrategy.ShowAnnualSalary();
            _paymentStrategy.ShowBonus();
        }
    }
}
