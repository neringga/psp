using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class JuniorFullStackDeveloperWithGoodPerformance: JuniorFullStackDeveloper
    {
        private readonly IGoodPerformance _goodPerformance;

        public JuniorFullStackDeveloperWithGoodPerformance(IGoodPerformance goodPerformance, float hourlyWage) : base(hourlyWage)
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
