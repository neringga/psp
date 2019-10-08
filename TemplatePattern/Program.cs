using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodPerformance = new GoodPerformance();
            var poorPerformance = new PoorPerformance();
            var bestPerformance = new BestPerformance();

            var juniorFullStackDevWithGoodPerformance = new JuniorFullStackDeveloperWithGoodPerformance(goodPerformance, 5);
            var juniorFullStackDevWithPoorPerformance = new JuniorFullStackDeveloperWithPoorPerformance(poorPerformance, 4);
            var midFullStackDevWithGoodPerformance = new MidFullStackDeveloperWithGoodPerformance(goodPerformance, 5);
            var midFullStackDevWithBestPerformance = new MidFullStackDeveloperWithBestPerformance(bestPerformance, 7);
            var seniorFullStackDevWithGoodPerformance = new SeniorFullStackDeveloperWithGoodPerformance(goodPerformance, 8);
            var seniorFullStackDevWithPoorPerformance = new SeniorFullStackDeveloperWithPoorPerformance(poorPerformance, 8);
            var juniorHR = new JuniorHumanResourcesManager(4);
            var seniorHR = new SeniorHumanResourcesManager(6);

            Console.WriteLine(nameof(JuniorFullStackDeveloperWithGoodPerformance));
            Console.WriteLine();
            juniorFullStackDevWithGoodPerformance.Salary();
            juniorFullStackDevWithGoodPerformance.Performance();

            Console.WriteLine(nameof(JuniorFullStackDeveloperWithPoorPerformance));
            Console.WriteLine();
            juniorFullStackDevWithPoorPerformance.Salary();
            juniorFullStackDevWithPoorPerformance.Performance();

            Console.WriteLine(nameof(MidFullStackDeveloperWithGoodPerformance));
            Console.WriteLine();
            midFullStackDevWithGoodPerformance.Salary();
            midFullStackDevWithGoodPerformance.Performance();

            Console.WriteLine(nameof(MidFullStackDeveloperWithBestPerformance));
            Console.WriteLine();
            midFullStackDevWithBestPerformance.Salary();
            midFullStackDevWithBestPerformance.Performance();

            Console.WriteLine(nameof(SeniorFullStackDeveloperWithGoodPerformance));
            Console.WriteLine();
            seniorFullStackDevWithGoodPerformance.Salary();
            seniorFullStackDevWithGoodPerformance.Performance();

            Console.WriteLine(nameof(SeniorFullStackDeveloperWithPoorPerformance));
            Console.WriteLine();
            seniorFullStackDevWithPoorPerformance.Salary();
            seniorFullStackDevWithPoorPerformance.Performance();

            Console.WriteLine(nameof(JuniorHumanResourcesManager));
            Console.WriteLine();
            juniorHR.Salary();

            Console.WriteLine(nameof(SeniorHumanResourcesManager));
            Console.WriteLine();
            juniorHR.Salary();

            Console.ReadKey();
        }
    }
}
