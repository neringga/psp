using System;

namespace StrategyPattern
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Full Stack developer with junior payment and poor performance");

            var performance1 = new PoorPerformance();
            var payment1 = new JuniorPayment(4);
            var developer1 = new FullStackDeveloper(performance1, payment1);
            developer1.Salary();
            developer1.Performance();

            Console.WriteLine("Full Stack developer with junior payment and good performance");

            var performance2 = new GoodPerformance();
            var payment2 = new JuniorPayment(4);
            var developer2 = new FullStackDeveloper(performance2, payment2);
            developer2.Salary();
            developer2.Performance(20, 10);

            Console.WriteLine("Full Stack developer with mid payment and good performance");

            var performance3 = new GoodPerformance();
            var payment3 = new MidPayment(6);
            var developer3 = new FullStackDeveloper(performance3, payment3);
            developer3.Salary();
            developer3.Performance();

            Console.WriteLine("Full Stack developer with senior payment and best performance");

            var performance4 = new BestPerformance();
            var payment4 = new SeniorPayment(8);
            var developer4 = new FullStackDeveloper(performance4, payment4);
            developer4.Salary();
            developer4.Performance();

            Console.WriteLine("HR manager with senior payment");

            var payment5 = new SeniorPayment(8);
            var hr = new HumanResourcesManager(payment5);
            hr.Salary();

            Console.ReadKey();
        }

        //public enum Month
        //{
        //    January = 1, February, March, April, May, June, July, August, September, October, November, December
        //}
    }
}
