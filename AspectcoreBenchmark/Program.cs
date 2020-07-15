using AspectCoreUnitTest;
using BenchmarkDotNet.Running;
using System;

namespace AspectcoreBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Md5VsSha256>();
        }
    }
}
 