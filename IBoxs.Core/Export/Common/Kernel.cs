using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IBoxs.Core.Export.Common
{
   public class Kernel
    {
        [DllImportAttribute("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize, IntPtr lpNumberOfBytesRead);

        //从指定内存中写入字节集数据
        [DllImport("Kernel32.dll")]
        public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr addrMem, StringBuilder strBuffer, int intSize, int filewriten);

        //打开一个已存在的进程对象，并返回进程的句柄
        [DllImportAttribute("kernel32.dll", EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        //关闭一个内核对象。其中包括文件、文件映射、进程、线程、安全和同步对象等。
        [DllImport("kernel32.dll")]
        private static extern void CloseHandle(IntPtr hObject);

        /// <summary>
        /// 吧值写入内存中
        /// </summary>
        /// <param name="baseAddress">内存地址</param>
        /// <param name="processName">变量名称</param>
        /// <param name="value">值</param>
        public static void WriteMemoryValue(int baseAddress, string value)
        {
            try
            {
                StringBuilder sb = new StringBuilder(256); //当指定分配大小之后，性能就会得到提升。如果超过指定大小系统会当前大小倍增，也就是10，15，20 这样。建议指定大小
                sb.Append(value);
                IntPtr hProcess = OpenProcess(0x1F0FFF, false, Process.GetCurrentProcess().Id);
                WriteProcessMemory(hProcess, (IntPtr)baseAddress, sb, 256, 0);
            }
            catch { }
        }
    }
}
