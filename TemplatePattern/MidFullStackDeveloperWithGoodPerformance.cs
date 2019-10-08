using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class MidFullStackDeveloperWithGoodPerformance: MidFullStackDeveloper
    {
        private readonly IGoodPerformance _goodPerformance;

        public MidFullStackDeveloperWithGoodPerformance(IGoodPerformance goodPerformance, float hourlyWage) : base(hourlyWage)
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
