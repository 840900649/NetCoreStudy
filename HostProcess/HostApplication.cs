using System;
using System.Collections.Generic;
using System.Text;

namespace HostProcess
{
    /// <summary>
    /// 将控制台设为宿主程序
    /// </summary>
    public class HostApplication 
    {
        /// <summary>
        /// 默认命令列表
        /// </summary>
        public static Dictionary<string, string> CMDList { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// 启动宿主程序
        /// </summary>
        /// <param name="cmdAction">命令监听-默认拥有quit 退出监听</param>
        public static void Run(Action<string> cmdAction)
        {
            bool quit = false;
            CMDList.Add("quit","退出应用程序！");
            while (!quit)
            {
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "quit":
                        Console.WriteLine("是否确认退出？(y/n)");
                       string isquit= Console.ReadLine();
                        if (isquit.Equals( "y",StringComparison.CurrentCultureIgnoreCase))
                        {
                            quit = true;
                        }  
                        break;
                    case "h":
                    case "help":
                    case "ddp -h":
                        Console.WriteLine("\n命令列表：");
                        foreach (var item in CMDList)
                        {
                            Console.WriteLine(item.Key+ "    "+item.Value);
                        }
                        break;
                    default:
                        cmdAction?.Invoke(cmd);
                        break;
                }
            }
        }
    }
}
