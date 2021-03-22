using HuajiTech.UnmanagedExports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBoxs.Core.Export
{
    public class GroupMsg
    {
        [DllExport]
        public static int onGroupMsg(int ptr)
        {
            return 1;
        }
    }
}
