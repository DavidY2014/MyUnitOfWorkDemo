using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netcore.Services.PostSharp
{
    public class MethodAspect: OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Entry time: "+DateTime.Now);

            base.OnEntry(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Exit time: "+DateTime.Now);
            base.OnExit(args);
        }

    }
}
