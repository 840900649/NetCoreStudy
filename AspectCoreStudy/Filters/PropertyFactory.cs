using AspectCore.Configuration;
using AspectCore.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspectCoreStudy.Filters
{
    public class PropertyFactory : InterceptorFactory
    {
        public override IInterceptor CreateInstance(IServiceProvider serviceProvider)
        {
            return null;
        }
    }
}
