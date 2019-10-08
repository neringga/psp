using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class PoorPerformance : PerformanceStrategy
    {
        protected override int GetYesterdayLinesOfCode()
        {
            if (DateTime.Today.AddDays(-1).DayOfWeek == DayOfWeek.Monday)
            {
                return 25;
            }
            else
            {
                return 30;
            }
        }

        protected override int GetPreviousMonthCommits()
        {
            if (DateTime.Today.AddMonths(-1).Month == 1)
            {
                return 4;
            }

            return 6;
        }
    }
}
