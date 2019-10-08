using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class PerformanceStrategy: IPerformanceStrategy
    {
        protected abstract int GetYesterdayLinesOfCode();
        protected abstract int GetPreviousMonthCommits();

        public void ShowYesterdayLinesOfCode()
        {
            Console.WriteLine($"Yesterday's lines of code count: {GetYesterdayLinesOfCode()}");
        }

        public void ShowPreviousMonthCommitCount()
        {
            Console.WriteLine($"Previous month commit count: {GetPreviousMonthCommits()}");
        }

        public void ShowIfValuable(int expectedCodeLines, int expectedCommits)
        {
            var isValuable = expectedCodeLines <= GetYesterdayLinesOfCode() &&
                             expectedCommits <= GetPreviousMonthCommits();
            Console.WriteLine(isValuable ? "Valuable employee" : "Not valuable employee");
        }
    }
}
