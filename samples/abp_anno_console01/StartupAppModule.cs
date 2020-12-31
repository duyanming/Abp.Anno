using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace abp_anno_console01
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class StartupAppModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutofac();
            context.Services.AddTransient<HelloWorldService>();
        }
    }
}
