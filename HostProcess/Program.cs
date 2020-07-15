using System;

namespace HostProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("分布式消息处理系统已启动! \n 输入ddp -h 获取命令指南");

            Init();
        }
        private static void Init()
        {
            HostApplication.Run(cmd => {

            });
            // HostApplication.CMDList.Add("","");
        }
    }
}
