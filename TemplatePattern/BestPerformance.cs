using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public interface IBestPerformance
    {
        int GetYesterdayLinesOfCode();
        int GetPreviousMonthCommits();
    }

    public class BestPerformance : IBestPerformance
    {
        public int GetYesterdayLinesOfCode()
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

        public int GetPreviousMonthCommits()
        {
            if (DateTime.Today.AddMonths(-1).Month == 1)
            {
                return 6;
            }

            return 8;

        }
    }
}
