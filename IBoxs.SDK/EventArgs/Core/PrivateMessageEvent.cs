using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IBoxs.SDK.EventArgs.Core
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 256)]
    public struct PrivateMessageEvent  //128个字节0x80
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
        public int red_packet_type;
        public byte[] chatToken;
        public long fromEventUin;
        public string fromEventNick;
        public string fildId;
        public byte[] fileMd5;
        public string fileName;
        public long fileSize;
    }
}
