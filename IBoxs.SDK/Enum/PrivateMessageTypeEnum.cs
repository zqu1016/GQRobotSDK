using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBoxs.SDK.Enum
{
    /// <summary>
    /// 私聊消息类型
    /// </summary>
    public enum PrivateMessageTypeEnum
    {
        /// <summary>
        /// 临时消息
        /// </summary>
        Temp=141,
        /// <summary>
        /// 好友消息
        /// </summary>
        Friend=166,
        /// <summary>
        /// 好友语音
        /// </summary>
        Voice=208,
        /// <summary>
        /// 好友文件
        /// </summary>
        File=529
    }
}
