using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netcore.Services.PostSharp
{
    public class ExceptionAspect: OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine(args.Exception.Message);
            Console.WriteLine("aspect message");
            base.OnException(args);
        }
    }
}
