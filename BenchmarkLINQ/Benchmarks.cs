using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace BenchmarkLINQ
{
    public class Benchmarks
    {
        private static readonly Samples Samples = new Samples();

        [Benchmark]
        public int AlcoholicDrinksCountLinqWhere() => Samples.AlcoholicDrinksCountLinqWhere();

        [Benchmark]
        public int AlcoholidDrinksCountLinqCount() => Samples.AlcoholidDrinksCountLinqCount();



    }
}
