using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class SeniorFullStackDeveloperWithPoorPerformance: SeniorFullStackDeveloper
    {
        private readonly IPoorPerformance _poorPerformance;

        public SeniorFullStackDeveloperWithPoorPerformance(IPoorPerformance poorPerformance, float hourlyWage) : base(hourlyWage)
        {
            _poorPerformance = poorPerformance;
        }

        protected override int GetYesterdayLinesOfCode()
        {
            return _poorPerformance.GetYesterdayLinesOfCode();
        }

        protected override int GetPreviousMonthCommits()
        {
            return _poorPerformance.GetPreviousMonthCommits();
        }
    }
}
