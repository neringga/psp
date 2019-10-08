using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class BestPerformance : PerformanceStrategy
    {
        protected override int GetYesterdayLinesOfCode()
        {
            if (DateTime.Today.AddDays(-1).DayOfWeek == DayOfWeek.Monday)
            {
                return 40;
            }
            else
            {
                return 45;
            }
        }

        protected override int GetPreviousMonthCommits()
        {
            if (DateTime.Today.AddMonths(-1).Month == 1)
            {
                return 6;
            }

            return 8;

        }
    }
}
