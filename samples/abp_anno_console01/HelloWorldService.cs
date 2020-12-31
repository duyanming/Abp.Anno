using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace abp_anno_console01
{
    public class HelloWorldService:ITransientDependency
    {
        public void SayHello() {
            Console.WriteLine("Hello World!");
        }
    }
}
