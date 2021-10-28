using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace NetBenchmark.Benchmarks.Dictionarys
{
    public class TextObj
    {
        public string A { get; set; }
        public int B { get; set; }
        public object C { get; set; }
    }

    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [HtmlExporter]
    public class DirctionaryRemoveBenchmark
    {
        public List<Tuple<string, TextObj>> GetDic()
        {
            var dic = new List<Tuple<string, TextObj>>();

            for (var i = 0; i < 10000; i++)
            {
                dic.Add(new Tuple<string, TextObj>(i.ToString(),new TextObj
                {
                    A = new string('A',i),
                    B = i,
                    C = i + new string('A', i)
                }));
            }
            return dic;
        }


        [Benchmark(Description = "Remove temp")]
        public bool BenchExtension1()
        {
            var d = GetDic();

            for (int i = d.Count - 1; i >= 0; --i)
            {
                var item = d[i];
                d.Remove(item);
            }

            return true;
        }

        [Benchmark(Description = "Remove Index")]
        public bool BenchExtension2()
        {
            var d = GetDic();

            for (int i = d.Count - 1; i >= 0; --i)
            {
                d.RemoveAt(i);
            }

            return true;
        }

       


    }
}
