using System;
using System.Reflection;
using System.Reflection.Emit;

namespace EmitStudy
{
    public class MyDynamicType
    {
        private int m_number;

        public MyDynamicType() : this(42)
        {
        }
        public MyDynamicType(int initNumber)
        {
            m_number = initNumber;
        }

        public int Number
        {
            get { return m_number; }
            set { m_number = value; }
        }

        public int MyMethod(int multiplier)
        {
            return m_number * multiplier;
        }
    }
    public class AOPEmit
    {
       
        /// <summary>
        /// 创建动态代理方法
        /// </summary>
        /// <param name="typeBuilder">类型构造器</param>
        /// <param name="method">方法元数据</param>
        /// <param name="realObjectField">实际对象</param>
        /// <param name="aspectFields">切面</param>
        private static void EmitMethod()
        {
            AssemblyBuilder ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("test"),
                AssemblyBuilderAccess.Run);
             
        }
    }
}
