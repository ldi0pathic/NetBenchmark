
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using NetBenchmark.Benchmarks.Switch.Methodes;

namespace NetBenchmark.Benchmarks.Switch
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [HtmlExporter]
    public class SwitchBenchmark
    {
        private readonly IfSwitch _ifSwitch = new IfSwitch();
        private readonly Methodes.Switch _switch = new Methodes.Switch();
        private readonly DicSwitch _dicSwitch = new DicSwitch(); 

        [Benchmark(Description = "StaticIf")]
        public long TestStaticIf()
        {
            long t = 0;
            for (var i = 0; i < (int)SwitchEnum.NrOfE; i++)
            {
                t = IfSwitch.StaticIf((SwitchEnum) i);
            }

            return t;
        }

        [Benchmark(Description = "If")]
        public long TestIf()
        {
            long t = 0;
            for (var i = 0; i < (int)SwitchEnum.NrOfE; i++)
            {
                t = _ifSwitch.If((SwitchEnum)i);
            }

            return t;
        }

        [Benchmark(Description = "StaticIfElse")]
        public long TestStaticIfElse()
        {
            long t = 0;
            for (var i = 0; i < (int)SwitchEnum.NrOfE; i++)
            {
                t = IfSwitch.StaticIfElse((SwitchEnum)i);
            }

            return t;
        }

        [Benchmark(Description = "IfElse")]
        public long TestIfElse()
        {
            long t = 0;
            for (var i = 0; i < (int)SwitchEnum.NrOfE; i++)
            {
                t = _ifSwitch.IfElse((SwitchEnum)i);
            }

            return t;
        }

        [Benchmark(Description = "Switch")]
        public long TestSwitch()
        {
            long t = 0;
            for (var i = 0; i < (int)SwitchEnum.NrOfE; i++)
            {
                t = _switch.doSwitch((SwitchEnum)i);
            }

            return t;
        }

        [Benchmark(Description = "StaticSwitch")]
        public long TestStaticSwitch()
        {
            long t = 0;
            for (var i = 0; i < (int)SwitchEnum.NrOfE; i++)
            {
                t = Methodes.Switch.doStaticSwitch((SwitchEnum)i);
            }

            return t;
        }

        [Benchmark(Description = "Dictionary")]
        public long TestDictionary()
        {
            long t = 0;
            for (var i = 0; i < (int)SwitchEnum.NrOfE; i++)
            {
                t = _dicSwitch.Dictionary[(SwitchEnum)i];
            }

            return t;
        }

        [Benchmark(Description = "StaticDictionary")]
        public long TestStaticDictionary()
        {
            long t = 0;
            for (var i = 0; i < (int)SwitchEnum.NrOfE; i++)
            {
                t = DicSwitch.StaticDictionary[(SwitchEnum)i];
            }

            return t;
        }




    }
}
