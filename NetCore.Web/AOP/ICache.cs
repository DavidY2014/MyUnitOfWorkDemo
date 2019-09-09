using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Web.AOP
{
    public interface ICache<T>
    {
        T Getvalue(int keyId);

        void Setvalue(int keyId ,T value);
      
    }
}
