using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace NetCore.Web.AOP
{
    /// <summary>
    /// 静态注入
    /// </summary>
    public class LogAttribute:Attribute
    {
    }

    public class LogAction : LogAttribute
    {
        public static void OnActionBefore(MethodBase methodBase)
        {
            var paras = methodBase.GetParameters();
            
        } 
    }
}
