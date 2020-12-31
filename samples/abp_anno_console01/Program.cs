using System;
using Volo.Abp;

namespace abp_anno_console01
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = AbpApplicationFactory.Create<StartupAppModule>(option=> {
                option.UseAutofac();
            });
            application.Initialize();

            HelloWorldService helloWorldService = (HelloWorldService)application.ServiceProvider.GetService(typeof(HelloWorldService));
            helloWorldService.SayHello();
        }
    }
}
