using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.Anno.Configuration
{
    public class AnnoConfiguration : IAnnoConfiguration
    {
        /// <summary>
        /// 应用程序名称
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// 注册中心
        /// </summary>
        public string RegistrationCenterAddress { get; set; }
        /// <summary>
        /// 注册中心端口
        /// </summary>
        public int RegistrationCenterPort { get; set; }
        /// <summary>
        /// 是否开启调用链追踪
        /// </summary>
        public bool TraceOnOff { get; set; }
    }
}
