using BenchmarkDotNet.Running;
using System;
using Bogus;

namespace BenchmarkLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer.Seed = new Random(420);
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}
