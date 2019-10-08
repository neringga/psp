using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public interface IGoodPerformance
    {
        int GetYesterdayLinesOfCode();
        int GetPreviousMonthCommits();
    }

    public class GoodPerformance : IGoodPerformance
    {
        public int GetYesterdayLinesOfCode()
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

        public int GetPreviousMonthCommits()
        {
            if (DateTime.Today.AddMonths(-1).Month == 1)
            {
                return 8;
            }

            return 10;

        }
    }
}
