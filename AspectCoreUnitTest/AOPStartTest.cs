using AspectCoreStudy;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AspectCoreUnitTest
{
   public class AOPStartTest
    {
        [Fact]
        public void TryUse()
        {
            AOPStart start = new AOPStart();
            start.TryUse();
        }
       
    }
}
