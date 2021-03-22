using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBoxs.SDK;

namespace IBoxs.Core
{
   public class Common
    {
        public static CqApi CqApi = new CqApi();

        public static string AppDirectory
        {
            get {
                return "";
            }
        }
        /// <summary>
        /// 控制台是否打开
        /// </summary>
        public static bool FrmBool { get; set; }
    }
}
