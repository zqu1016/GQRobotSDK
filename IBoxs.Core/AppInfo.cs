using System;
using System.Linq;
using IBoxs.Core.Export;

namespace IBoxs.Core
{
    /// <summary>
    /// 插件信息
    /// </summary>
    public class AppInfo
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        public string AppName { get; private set; }
        /// <summary>
        /// 应用版本号
        /// </summary>
        public string AppVersion { get; private set; }
        /// <summary>
        /// 应用作者
        /// </summary>
        public string AppAuthor{ get; private set; }
        /// <summary>
        /// 应用说明
        /// </summary>
        public string AppDesc { get; private set; }

        public AppInfo()
        {
            this.AppName = "格子吧机器人C#SDK";
            this.AppVersion = "1.0.0";
            this.AppAuthor = "SDK作者";
            this.AppDesc = "应用简介说明";
        }
    }
}