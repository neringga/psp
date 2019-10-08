using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class GoodPerformance: PerformanceStrategy
    {
        protected override int GetYesterdayLinesOfCode()
        {
            if (DateTime.Today.AddDays(-1).DayOfWeek == DayOfWeek.Monday)
            {
                return 50;
            }
            else
            {
                return 55;
            }
        }

        protected override int GetPreviousMonthCommits()
        {
            if (DateTime.Today.AddMonths(-1).Month == 1)
            {
                return 8;
            }

            return 10;
        }
    }
}
