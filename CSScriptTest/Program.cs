using CSScriptLib;
using System;

namespace CSScriptTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //注意命名空间的引用，引用后才能使用功能。
         var test=   CSScript.Evaluator.LoadCode<ITest>(@"
using System; 
using CSScriptTest;
    public class TestTextClass : ITest
    {
        public string Say()
        {
            DBHandle dBHandle = new DBHandle();
            var name= dBHandle.GetName();
            Console.WriteLine(""获取到姓名: ""+name);
            Console.WriteLine(""获取到姓名: "" + DBStatic.GetSource());
            return name;
        }
    }
");
           var name= test.Say();

            //官方测试。
            //var script = CSScript.Evaluator
            //             .LoadCode(@"using System;
            //                         public class Script
            //                         {
            //                             public string SayHello(string greeting)
            //                             {
            //                                 Console.WriteLine(""Greeting: ""+ greeting);
            //                                 return ""测试完成：""+greeting;
            //                             }
            //                         }"); 
           // var data = script.SayHello("Hello World!");

            Console.ReadLine();
        }
    }
}
