using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GrammerLearning
{
   public class TaskStudy
    {
        public void TestTaskCompletion()
        {
            var task = TaskCompletion();
            Console.WriteLine("准备执行任务,---线程：" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("执行结果："+ task.Result);
        }
        private Task<string> TaskCompletion ()
        {
            var tcs =new TaskCompletionSource<string>();
            var events = new TaskEventTest();
            events.Done+= (args) => {
                Console.WriteLine("执行Done:" + args + "---线程：" + Thread.CurrentThread.ManagedThreadId);
                tcs.SetResult(args);
            };
            events.Do("参数传入测试");

            return tcs.Task;
        }
        
    }
    public class TaskEventTest
    {
        public Action<string> Done = (msg) => {; };
        public string Do(string msg)
        {
            Console.WriteLine("执行Do:" + msg + "---线程：" + Thread.CurrentThread.ManagedThreadId);
            Done(msg);
            return "执行成功："+msg;
        }
    }
}
