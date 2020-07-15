using System;
using System.Reflection;
using System.Reflection.Emit;

namespace EmitStudy
{
    public class EmitTest
    {
        public static void CreateType()
        { 
            var dynamicMethod = new DynamicMethod("Call",typeof(string),new[] {typeof(string) });
            var iLGenerator = dynamicMethod.GetILGenerator();
            //iLGenerator.Emit(OpCodes.);
        }
    }
}
