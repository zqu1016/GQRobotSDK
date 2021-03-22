using HuajiTech.UnmanagedExports;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBoxs.Core.Export
{
    public class Create
    {
        [DllExport]
        public static void Init(int pName, int pVer, int pAuthor, int pDesc, string AddrInfo) => CreateMain(pName, pVer, pAuthor, pDesc, AddrInfo);

        public static void CreateMain(int pName, int pVer, int pAuthor, int pDesc, string AddrInfo)
        {
            AppInfo app = new AppInfo();
            Common.Kernel.WriteMemoryValue(pName, app.AppName);
            Common.Kernel.WriteMemoryValue(pAuthor, app.AppAuthor);
            Common.Kernel.WriteMemoryValue(pVer, app.AppVersion);
            Common.Kernel.WriteMemoryValue(pDesc, app.AppDesc);
            SDK.Core.GQCore rb= JsonConvert.DeserializeObject<SDK.Core.GQCore>(AddrInfo);
        }

        [DllExport]
        public static void Setting()
        {

        }

        [DllExport]
        public void Uninit()
        {

        }
    }
}
