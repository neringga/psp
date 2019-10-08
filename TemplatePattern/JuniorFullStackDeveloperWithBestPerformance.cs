using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class JuniorFullStackDeveloperWithBestPerformance: JuniorFullStackDeveloper
    {
        private readonly IBestPerformance _bestPerformance;

        public JuniorFullStackDeveloperWithBestPerformance(IBestPerformance bestPerformance, float hourlyWage) : base(hourlyWage)
        {
            _bestPerformance = bestPerformance;
        }

        protected override int GetYesterdayLinesOfCode()
        {
            return _bestPerformance.GetYesterdayLinesOfCode();
        }

        protected override int GetPreviousMonthCommits()
        {
            return _bestPerformance.GetPreviousMonthCommits();

        }
    }
}
