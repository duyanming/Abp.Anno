using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.Anno.Configuration
{
    public interface IAnnoConfiguration
    {
        /// <summary>
        /// 应用程序名称
        /// </summary>
        string AppName { get; set; }
        /// <summary>
        /// 注册中心
        /// </summary>
        string RegistrationCenterAddress { get; set; }
        /// <summary>
        /// 注册中心端口
        /// </summary>
        int RegistrationCenterPort { get; set; }
        /// <summary>
        /// 是否开启调用链追踪
        /// </summary>
        bool TraceOnOff { get; set; }
    }
}
