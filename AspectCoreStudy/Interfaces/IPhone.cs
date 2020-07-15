using System;
using System.Collections.Generic;
using System.Text;

namespace AspectCoreStudy.Interfaces
{
   public interface IPhone
    {
        string Name { get; set; }
        string Call();
    }
}
