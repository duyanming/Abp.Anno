using Abp.Configuration.Startup;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.Anno.Configuration
{
    public static class AnnoConfigrationExtensions
    {
        public static IAnnoConfiguration Anno(this IModuleConfigurations configurations)
        {
            return configurations.AbpConfiguration.Get<IAnnoConfiguration>();
        }
    }
}
