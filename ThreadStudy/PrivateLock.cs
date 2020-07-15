using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadStudy
{
    /// <summary>
    /// 私有锁测试
    /// </summary>
    public class PrivateLock
    {
        private static readonly object locks = new object();
       public static int count = 0;
        public void Count()
        {
            lock (locks)
            {
                count++;
                Console.WriteLine(count);
            } 
        }
    }
}
