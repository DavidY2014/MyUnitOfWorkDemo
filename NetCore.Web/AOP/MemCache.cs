using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Web.AOP
{
    public class MemCache<T> : ICache<T>
    {
        Dictionary<int, T> _cache = new Dictionary<int, T>();
        public T Getvalue(int keyId)
        {
            return _cache[keyId];
        }

        public void Setvalue(int keyId ,T value)
        {
            _cache.Add(keyId,value);
        }
    }
}
