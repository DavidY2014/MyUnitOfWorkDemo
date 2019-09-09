using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Web.PostSharp
{
    public class ExceptionAspect: OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        { 
            
        }
    }
}
