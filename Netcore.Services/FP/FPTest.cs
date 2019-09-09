using System;
using System.Collections.Generic;
using System.Text;

namespace Netcore.Services.FP
{
    public class FPTest
    {
        public static void AddLogger(Action action)
        {
            Console.WriteLine("logger start" + DateTime.Now);
            if (action != null)
            {
                action();
            }
        }

        
    }
}
