using HuajiTech.UnmanagedExports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBoxs.Core.Export
{
   public class Event
    {
        [DllExport]
        public static int onEventMsg(long fromMyUin, long fromGroupUin, long fromOpUin, long fromUin, long fromSeq, int fromTime, string fromGroupName, string fromOpNick, string fromNick, string fromContent, int Type, int subType)
        {
            return 0;
        }
    }
}
