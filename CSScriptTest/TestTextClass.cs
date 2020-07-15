using System; 
namespace CSScriptTest
{
    public class TestTextClass : ITest
    {
        public string Say()
        {
            DBHandle dBHandle = new DBHandle();
            var name= dBHandle.GetName();
            Console.WriteLine("获取到姓名:"+name);
            Console.WriteLine("获取到姓名:" + DBStatic.GetSource());
            return name;
        }
    }
}
