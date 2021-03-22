using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using IBoxs.SDK.Core;

namespace IBoxs.SDK
{
    public class CqApi
    {

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        delegate IntPtr SendGroupMsg(string pkey, long thisQQ, long groupQQ, [MarshalAs(UnmanagedType.LPStr)] string msgcontent, bool anonymous);

        public string SendGroupMessage(long thisQQ, long groupQQ, string msgcontent, bool anonymous = false)
        {
            string ret = string.Empty;
            int MsgAddress = int.Parse(JObject.Parse(jsonstr).SelectToken("发送群消息").ToString());
            IntPtr intPtr = new IntPtr(MsgAddress);
            SendGroupMsg sendmsg = (SendGroupMsg)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(SendGroupMsg));
            ret = Marshal.PtrToStringAnsi(sendmsg(pluginkey, thisQQ, groupQQ, msgcontent, anonymous));
            sendmsg = null;
            return ret;
        }
    }
}