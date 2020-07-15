using System;
using System.Threading.Tasks;

namespace ThreadStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("线程测试!");
            for (int i = 0; i < 100; i++)
            {
               var plock= new PrivateLock();
                Task.Run(()=> {
                    for (int i = 0; i < 20; i++)
                    {
                        plock.Count();
                    } 
                });
            }
            Console.WriteLine("线程测试结果："+ PrivateLock.count);
            Console.ReadLine();
        }
    }
}
