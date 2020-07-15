using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspectCoreUnitTest
{
    public class BenchmarkTest
    {
        [Benchmark]
        public void Time()
        {
            var list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
        }
    }
}
