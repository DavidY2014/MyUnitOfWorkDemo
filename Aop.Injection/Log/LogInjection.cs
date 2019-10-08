using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Aop.Injection.Log
{
    public class LogInjection
    {
        public void InjectLoggerFromAssembly(string dllPath)
        {
            Assembly a = Assembly.LoadFile(dllPath);
            Type[] types = a.GetTypes();
            foreach(var type in types)
            {
                foreach (var prop in type.GetProperties())
                {
                    var attributes = prop.GetCustomAttributes(false);
                    

                }
            }


        }
    }
}
