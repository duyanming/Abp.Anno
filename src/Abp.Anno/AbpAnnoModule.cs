using Abp.Anno.Configuration;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Anno.Rpc.Client;
using System;

namespace Abp.Anno
{
    [DependsOn(typeof(AbpKernelModule))]
    public class AbpAnnoModule : AbpModule
    {
        public override void PreInitialize()
        {          
            IocManager.Register<IAnnoConfiguration, AnnoConfiguration>();
            IocManager.Register<IAnnoProxy, AnnoProxy>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpAnnoModule).GetAssembly());
            IAnnoConfiguration annoConfiguration = Configuration.Modules.Anno();
            /*
          * 配置注册中心地址
          * 客户端名称：AbpAnnoModule
          * 注册中心IP：127.0.0.1
          * 注册中心端口：7010
          * 调用链追踪：false（true开启，false关闭）
          */
            DefaultConfigManager.SetDefaultConfiguration(annoConfiguration.AppName, annoConfiguration.RegistrationCenterAddress, annoConfiguration.RegistrationCenterPort, annoConfiguration.TraceOnOff);
        }
    }
}
