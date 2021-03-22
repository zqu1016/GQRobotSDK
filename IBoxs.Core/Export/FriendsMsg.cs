using HuajiTech.UnmanagedExports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBoxs.SDK.EventArgs;
using System.Runtime.InteropServices;
using System.IO;
using IBoxs.SDK.EventArgs.Core;
using IBoxs.SDK.Enum;

namespace IBoxs.Core.Export
{
    public class FriendsMsg
    {
        [DllExport]
        public static int onFriendMsg(int ptr)
        {
            IntPtr p = new IntPtr(ptr);
            GroupPrivateMessage data = new GroupPrivateMessage();
            data = (GroupPrivateMessage)Marshal.PtrToStructure(p, typeof(GroupPrivateMessage));//161群私聊，166好友
            if (data.msgType == (int)PrivateMessageTypeEnum.Temp)  //临时消息
            {
              
            }
            else if (data.msgType == (int)PrivateMessageTypeEnum.Friend)  //好友普通消息
            {
                PrivateMessageArgs e = new PrivateMessageArgs(data.RobotQQ, data.FromQQ, data.fromReq, data.fromSql, data.RecvTime, data.SendTime, data.message_content, 0);
                Task t = new Task(() => Core.Event.Event_Private.FriendMessage(e));
                t.Start();
            }
            else if (data.msgType == (int)PrivateMessageTypeEnum.Voice)  //好友语音
            {

            }
            else if (data.msgType == (int)PrivateMessageTypeEnum.File)  //临时语音/好友文件
            {

            }
            return 1;
        }
    }
}
