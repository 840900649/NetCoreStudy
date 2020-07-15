using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCStudy
{
    public class ActionFilterGloableAttribute :ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(context.Result.ToString());
            base.OnActionExecuted(context);
        }
    }
}
