using System;
using System.Threading;

namespace BenStudy
{
    class Program
    {
        static int constNumber = 0x1d19_0000;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CpuUsed();
            Console.ReadLine();
        }
        // CPU使用率测试
        static void CpuUsed()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread;
                thread = new Thread(CpuThread)
                {
                    IsBackground = true
                };
                thread.Start();
            } 
        }
        static void CpuThread()
        {
            int number = 0;
            //  while (true) ;
            while (number < 100000000)
            {
                Console.WriteLine(number);
                number++;
            }
        }
        //运算符测试
        static void Operators()
        {
            var number = 0x00011;
            var number2 = 0x00101;
            var number3 = number >> 1;
            var number4 = number & number2;
            var number5 = number | number2;
            var number6 = number ^ number2;
            var number7 = ~number;
            Console.WriteLine(get(0x1d20_0000));
            Console.WriteLine(get(0x1d21_0000));
        }
        static int get(int value)
        {  
            return value;
        }
    }
}
