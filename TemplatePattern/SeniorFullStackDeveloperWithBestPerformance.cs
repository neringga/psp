using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class SeniorFullStackDeveloperWithBestPerformance: SeniorFullStackDeveloper
    {
        private readonly IBestPerformance _bestPerformance;

        public SeniorFullStackDeveloperWithBestPerformance(IBestPerformance bestPerformance, float hourlyWage) : base(hourlyWage)
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
