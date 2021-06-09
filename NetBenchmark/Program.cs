
using BenchmarkDotNet.Running;
using NetBenchmark.Benchmarks.SwitchVersions;

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
            //BenchmarkRunner.Run<SwitchBenchmark>();
            BenchmarkRunner.Run<SwitchVersionsBenchmark>();
        }
    }
}
