using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class JuniorFullStackDeveloperWithPoorPerformance: JuniorFullStackDeveloper
    {
        private readonly IPoorPerformance _poorPerformance;

        public JuniorFullStackDeveloperWithPoorPerformance(IPoorPerformance poorPerformance, float hourlyWage) : base(hourlyWage)
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
