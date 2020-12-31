using Anno.Rpc.Client.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.Anno
{
    public class AnnoProxy : IAnnoProxy
    {
        public TInterface GetService<TInterface>() where TInterface : class
        {
            return AnnoProxyBuilder.GetService<TInterface>();
        }
    }
}
