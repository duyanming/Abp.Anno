using Abp.Anno.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using System;

namespace Abp.Anno
{
    [DependsOn(typeof(AbpKernelModule))]
    public class AbpAnnoModule : AbpModule
    {
        public override void PreInitialize()
        {
            IocManager.Register<IAnnoConfiguration, AnnoConfiguration>();

            //IocManager.Register<IElasticsearch, AbpElasticSearch>(DependencyLifeStyle.Transient);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpAnnoModule).GetAssembly());
        }
    }
}
