using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class FullStackDeveloper
    {
        private readonly float _hourlyWage;
        protected float MonthSalary;

        protected FullStackDeveloper(float hourlyWage)
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

        public void Performance(int? expectedLinesOfCodePerDay = null, int? expectedCommits = null)
        {
            ShowYesterdayLinesOfCode();
            ShowPreviousMonthCommitCount();
            if (expectedLinesOfCodePerDay != null && expectedCommits != null)
            {
                ShowIfValuable(expectedLinesOfCodePerDay.Value, expectedCommits.Value);
            }
        }

        protected abstract void ShowMonthlySalary(int month);
        protected abstract void ShowAnnualSalary();
        protected abstract void ShowBonus();
        protected abstract int GetYesterdayLinesOfCode();
        protected abstract int GetPreviousMonthCommits();

        protected float CalculateMonthSalary()
        {
            return 120 * _hourlyWage;
        }

        private void ShowYesterdayLinesOfCode()
        {
            Console.WriteLine($"Yesterday's lines of code count: {GetYesterdayLinesOfCode()}");
        }

        private void ShowPreviousMonthCommitCount()
        {
            Console.WriteLine($"Previous month commit count: {GetPreviousMonthCommits()}");
        }

        private void ShowIfValuable(int expectedCodeLines, int expectedCommits)
        {
            var isValuable = expectedCodeLines <= GetYesterdayLinesOfCode() &&
                             expectedCommits <= GetPreviousMonthCommits();
            Console.WriteLine(isValuable ? "Valuable employee" : "Not valuable employee");
        }
    }
}
