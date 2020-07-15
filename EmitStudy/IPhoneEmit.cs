using System;
using System.Collections.Generic;
using System.Text;

namespace EmitStudy
{
    public interface IPhoneEmit
    {
        string Name { get; set; }

        string Call();
    }
}
