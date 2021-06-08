using System;
using BenchmarkDotNet.Running;
using NetBenchmark.Benchmarks.DateTime;
using NetBenchmark.Benchmarks.Switch;

namespace NetBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<DateTimeTrimDayBenchmark>();
            //BenchmarkRunner.Run<DateTimeTrimHourBenchmark>();
            //BenchmarkRunner.Run<DateTimeTrimMinuteBenchmark>();
            //BenchmarkRunner.Run<DateTimeTrimSecondBenchmark>();
            BenchmarkRunner.Run<SwitchBenchmark>();
        }
    }
}
