using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace BenchmarkLINQ
{
    public class Benchmarks
    {

        private readonly Consumer consumer = new Consumer();
        private static readonly Samples Samples = new Samples();

        [Benchmark]
        public int AktivCountLinqWhere() => Samples.AktivCountLinqWhere();

        [Benchmark]
        public int AktivCountLinqCount() => Samples.AktivCountLinqCount();

        //[Benchmark]
        //public List<string> EmratJoAktivLinqList() => Samples.EmratJoAktivLinqList();


        //[Benchmark]
        //public void OK() => Samples.EmratJoAktivLinqAsQueryable().Consume(consumer);

    }
}
