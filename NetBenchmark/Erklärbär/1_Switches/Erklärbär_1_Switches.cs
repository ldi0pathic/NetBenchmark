
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using NetBenchmark.Erklärbär._1_Switches.Methoden;
using System;

namespace NetBenchmark.Erklärbär._1_Switches
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [HtmlExporter]
    public class Erklärbär_1_Switches
    {

        private readonly IHasColor ifElse = new IfElse();
        private readonly IHasColor oldSwitch = new OldSwitch();
        private readonly IHasColor newSwitch = new NewSwitch();
        private readonly IHasColor newSwitch2 = new NewSwitch2();
        private readonly IHasColor newSwitch3 = new NewSwitch3();

        [Benchmark(Description = "ifElse")]
        public bool TestIfElse()
        {
            bool r = false;
            for(int index = 0; index < 100; index++)
                foreach (Farben farbe in Enum.GetValues(typeof(Farben)))
                    foreach (Dinge ding in Enum.GetValues(typeof(Dinge)))
                        r = ifElse.HasColor(ding, farbe);

            return r;
        }

        [Benchmark(Description = "oldSwitch")]
        public bool TestOldSwitch()
        {
            bool r = false;
            for (int index = 0; index < 100; index++)
                foreach (Farben farbe in Enum.GetValues(typeof(Farben)))
                    foreach (Dinge ding in Enum.GetValues(typeof(Dinge)))
                        r = oldSwitch.HasColor(ding, farbe);

            return r;
        }

        [Benchmark(Description = "newSwitch")]
        public bool TestNewSwitch()
        {
            bool r = false;
            for (int index = 0; index < 100; index++)
                foreach (Farben farbe in Enum.GetValues(typeof(Farben)))
                    foreach (Dinge ding in Enum.GetValues(typeof(Dinge)))
                        r = newSwitch.HasColor(ding, farbe);

            return r;
        }  
        
        [Benchmark(Description = "newSwitch2")]
        public bool TestNewSwitch2()
        {
            bool r = false;
            for (int index = 0; index < 100; index++)
                foreach (Farben farbe in Enum.GetValues(typeof(Farben)))
                    foreach (Dinge ding in Enum.GetValues(typeof(Dinge)))
                        r = newSwitch2.HasColor(ding, farbe);

            return r;
        } 
        
        [Benchmark(Description = "newSwitch3")]
        public bool TestNewSwitch3()
        {
            bool r = false;
            for (int index = 0; index < 100; index++)
                foreach (Farben farbe in Enum.GetValues(typeof(Farben)))
                    foreach (Dinge ding in Enum.GetValues(typeof(Dinge)))
                        r = newSwitch3.HasColor(ding, farbe);

            return r;
        }
    }
}
