using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class SeniorFullStackDeveloperWithGoodPerformance: SeniorFullStackDeveloper
    {
        private readonly IGoodPerformance _goodPerformance;

        public SeniorFullStackDeveloperWithGoodPerformance(IGoodPerformance goodPerformance, float hourlyWage) : base(hourlyWage)
        {
            _goodPerformance = goodPerformance;
        }

        protected override int GetYesterdayLinesOfCode()
        {
            return _goodPerformance.GetYesterdayLinesOfCode();
        }

        protected override int GetPreviousMonthCommits()
        {
            return _goodPerformance.GetPreviousMonthCommits();
        }
    }
}
