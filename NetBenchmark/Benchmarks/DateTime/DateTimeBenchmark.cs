using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using NetBenchmark.Benchmarks.DateTime.Extensions;

namespace NetBenchmark.Benchmarks.DateTime
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [HtmlExporter]
    public class DateTimeTrimDayBenchmark
    {
        private readonly System.DateTime _date = new System.DateTime(2020, 12, 29, 22, 45, 12).AddMilliseconds(99);

        [Benchmark(Description = "E1-TrimDay")]
        public System.DateTime BenchExtension1()
        {
            return _date.TrimDay();
        }

        [Benchmark(Description = "E2-TrimDay")]
        public System.DateTime BenchExtension2()
        {
            return _date.Trim2Day();
        }

        [Benchmark(Description = "E3-TrimDay")]
        public System.DateTime BenchExtension3()
        {
            return _date.Trim3Day();
        }

        [Benchmark(Description = "System-TrimDay", Baseline = true)]
        public System.DateTime BenchSystem()
        {
            return _date.Date;
        }
    }

    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [HtmlExporter]
    public class DateTimeTrimHourBenchmark
    {
        private readonly System.DateTime _date = new System.DateTime(2020, 12, 29, 22, 45, 12).AddMilliseconds(99);

        [Benchmark(Description = "E1-TrimHour")]
        public System.DateTime BenchExtension1()
        {
            return _date.TrimHour();
        }

        [Benchmark(Description = "E2-TrimHour", Baseline = true)]
        public System.DateTime BenchExtension2()
        {
            return _date.Trim2Hour();
        }
        [Benchmark(Description = "E3-TrimHour")]
        public System.DateTime BenchExtension3()
        {
            return _date.Trim3Hour();
        }
    }

    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [HtmlExporter]
    public class DateTimeTrimMinuteBenchmark
    {
        private readonly System.DateTime _date = new System.DateTime(2020, 12, 29, 22, 45, 12).AddMilliseconds(99);

        [Benchmark(Description = "E1-TrimMinute")]
        public System.DateTime BenchExtension1()
        {
            return _date.TrimMinute();
        }

        [Benchmark(Description = "E2-TrimMinute", Baseline = true)]
        public System.DateTime BenchExtension2()
        {
            return _date.Trim2Minute();
        }

        [Benchmark(Description = "E3-TrimMinute")]
        public System.DateTime BenchExtension3()
        {
            return _date.Trim3Minute();
        }
    }

    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [HtmlExporter]
    public class DateTimeTrimSecondBenchmark
    {
        private readonly System.DateTime _date = new System.DateTime(2020, 12, 29, 22, 45, 12).AddMilliseconds(99);

        [Benchmark(Description = "E1-TrimSecond")]
        public System.DateTime BenchExtension1()
        {
            return _date.TrimSecond();
        }

        [Benchmark(Description = "E2-TrimSecond", Baseline = true)]
        public System.DateTime BenchExtension2()
        {
            return _date.Trim2Second();
        }

        [Benchmark(Description = "E3-TrimSecond")]
        public System.DateTime BenchExtension3()
        {
            return _date.Trim3Second();
        }
    }
}
