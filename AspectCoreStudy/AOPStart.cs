using AspectCore.Configuration;
using AspectCore.Extensions.DependencyInjection;
using AspectCoreStudy.Filters;
using AspectCoreStudy.Interfaces;
using AspectCoreStudy.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspectCoreStudy
{
   public class AOPStart
    { 
        public void TryUse()
        {
           var   services =new  ServiceCollection();
            services.AddTransient<IPhone,XiaoMi>();
            services.ConfigureDynamicProxy(config=> { 
                config.Interceptors.AddDelegate((ctx,next)=> {
                    
                    return next(ctx);
                });
            });
          
           var provider= services.BuildServiceProvider();
          
            var phone= provider.GetService<IPhone>();
            phone.Call();
        }
    }
}
