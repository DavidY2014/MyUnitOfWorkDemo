using Acm.NetStandard.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netcore.ConsoleEntry
{
    public class PostSharpTest
    {
        //[MethodAspect]
        public static void CacluateMethodTime()
        {
            //method
            for (var i=1;i<10;i++)
            {
                Console.WriteLine(i);
            }
        }

    }


    public class NugetTest
    {
        public static void Test()
        {
            FileHelper.WriteJsonToFile("", "");
        }
    }
}
