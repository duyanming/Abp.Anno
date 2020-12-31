using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.Anno
{
    public interface IAnnoProxy
    {
        TInterface GetService<TInterface>() where TInterface : class;
    }
}
