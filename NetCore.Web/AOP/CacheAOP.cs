using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Web.AOP
{
    /// <summary>
    /// 拦截器，类似装饰器模式，在其中添加多余的代码
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CacheAOP<T> : IInterceptor
    {
        private ICache<T> _cache;
        public CacheAOP(ICache<T> cache)
        {
            _cache = cache;
        }

        public void Intercept(IInvocation invocation)
        {
        }
    }
}
