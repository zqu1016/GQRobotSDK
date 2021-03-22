using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBoxs.SDK.Enum;

namespace IBoxs.SDK.EventArgs
{
    /// <summary>
    /// 私聊消息
    /// </summary>
   public class PrivateMessageArgs
    {
        public long RobotQQ { get; private set; }
        public long FromQQ { get; private set; }
        public int MsgReq { get; private set; }
        public long MsgSeq { get; private set; }
        public DateTime RecvTime { get; private set; }

        public DateTime SendTime { get; private set; }

        public string Message { get; private set; }
        
        public RedPackTypeEnum RedPackType { get; private set; }

        public PrivateMessageArgs(long robotQQ,long fromQQ,int msgReq,long msgSeq,int reavTime,int sendTime,string message,int redPackType)
        {
            this.RobotQQ = robotQQ;
            this.FromQQ = fromQQ;
            this.MsgSeq = msgSeq;
            this.MsgReq = msgReq;
            this.RecvTime = Core.Tools.GetTime(reavTime);
            this.SendTime = Core.Tools.GetTime(sendTime);
            this.Message = message;
            this.RedPackType = (RedPackTypeEnum)redPackType;
        }
    }
}
