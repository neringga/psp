using System;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkTests>();

            Console.ReadKey();
        }
    }

    public class BenchmarkTests
    {
        [Benchmark]
        public void test1()
        {
            var a = Task.Run(() => Thread.Sleep(500));
            var b = Task.Run(() => Thread.Sleep(500));

            Task.WaitAll(a, b);
        }

        [Benchmark]
        public async Task test2()
        {
            var a = Task.Run(() => Thread.Sleep(500));
            var b = Task.Run(() => Thread.Sleep(500));

            await a;
            await b;
        }
    }
}
