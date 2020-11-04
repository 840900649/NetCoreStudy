using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestTopic
{
    public class ThreadIssue
    {
        public volatile string data = "1";
        public Semaphore semaphore = new Semaphore(10,10);

    }
}
