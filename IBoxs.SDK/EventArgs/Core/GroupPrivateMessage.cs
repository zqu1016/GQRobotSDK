using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IBoxs.SDK.EventArgs.Core
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class GroupPrivateMessage
    {
        public long FromQQ;
        public long RobotQQ;
        public int fromReq;
        public long fromSql;
        public int RecvTime;
        public long fromGroup;
        public int SendTime;
        public long Random;
        public int pieceIndex;
        public int pieceCount;
        public long pieceFlag;
        public string message_content;
        public int buddleId;
        public int msgType;
        public int subMsgType;
        public int subTempMsgType;
    }
}
