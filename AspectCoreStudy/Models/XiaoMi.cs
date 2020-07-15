using AspectCoreStudy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspectCoreStudy.Models
{
    public class XiaoMi : IPhone
    {
        public string Name { get; set; }
        public string Call()
        {
            Console.WriteLine("我是小米手机!");
            return Name;
        }
    }
}
