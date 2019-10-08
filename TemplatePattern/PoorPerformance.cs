using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public interface IPoorPerformance
    {
        int GetYesterdayLinesOfCode();
        int GetPreviousMonthCommits();
    }

    public class PoorPerformance : IPoorPerformance
    {
        public int GetYesterdayLinesOfCode()
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

        public int GetPreviousMonthCommits()
        {
            if (DateTime.Today.AddMonths(-1).Month == 1)
            {
                return 4;
            }

            return 6;
        }
    }
}
