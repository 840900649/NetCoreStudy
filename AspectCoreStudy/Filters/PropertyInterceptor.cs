using AspectCore.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspectCoreStudy.Filters
{
    public class PropertyInterceptor : AbstractInterceptor
    {
        public async override Task Invoke(AspectContext context, AspectDelegate next)
        {
            try
            {
                Console.WriteLine("Before service call");
                await next(context);
            }
            catch (Exception)
            {
                Console.WriteLine("Service threw an exception!");
                throw;
            }
            finally
            {
                Console.WriteLine("After service call");
            }
        }
    }
}
