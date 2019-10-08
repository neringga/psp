using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IPerformanceStrategy
    {
        void ShowYesterdayLinesOfCode();
        void ShowPreviousMonthCommitCount();
        void ShowIfValuable(int expectedCodeLines, int expectedCommits);
    }
}
