using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FullStackDeveloper
    {
        private IPerformanceStrategy _performanceStrategy;
        private IPaymentStrategy _paymentStrategy;

        public FullStackDeveloper(IPerformanceStrategy performance, IPaymentStrategy payment)
        {
            _performanceStrategy = performance;
            _paymentStrategy = payment;
        }

        public void Salary()
        {
            _paymentStrategy.ShowMonthlySalary(1);
            _paymentStrategy.ShowMonthlySalary(12);
            _paymentStrategy.ShowAnnualSalary();
            _paymentStrategy.ShowBonus();
        }

        public void Performance(int? expectedLinesOfCodePerDay = null, int? expectedCommits = null)
        {
            _performanceStrategy.ShowYesterdayLinesOfCode();
            _performanceStrategy.ShowPreviousMonthCommitCount();
            if (expectedLinesOfCodePerDay != null && expectedCommits != null)
            {
                _performanceStrategy.ShowIfValuable(expectedLinesOfCodePerDay.Value, expectedCommits.Value);
            }
        }
    }
}
