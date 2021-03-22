using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBoxs.SDK.Enum
{
    /// <summary>
    /// 临时会话类型
    /// </summary>
    public enum TempMsgEnum
    {
        /// <summary>
        /// 来自群
        /// </summary>
        Group=0,
        /// <summary>
        /// 来自讨论组
        /// </summary>
        Discuss=1,
        /// <summary>
        /// 来自公众号
        /// </summary>
        Official=129,
        /// <summary>
        /// 来自QQ咨询
        /// </summary>
        Consulting=201
    }
}
