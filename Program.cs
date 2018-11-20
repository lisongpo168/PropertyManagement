//文件名：Program.cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace MyCommunity
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        private static EventWaitHandle ProgramStarted;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (RunExistingInstanceIfExist())
            {
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static bool RunExistingInstanceIfExist()
        {
            bool createdNew = false;
            ProgramStarted = new EventWaitHandle(false, EventResetMode.AutoReset, "MyCommunity.OneInstance", out createdNew);

            if (!createdNew)
            {
                Thread.Sleep(200);

                string processName = Process.GetCurrentProcess().ProcessName;
                Process current = Process.GetCurrentProcess();

                #region 将焦点转移到前一个实例
                foreach (Process p in Process.GetProcessesByName(processName))
                {
                    if (p.Id != current.Id && p.MainWindowHandle != IntPtr.Zero)
                    {
                        //使窗口恢复
                        ShowWindowAsync(p.MainWindowHandle, 9);
                        SetForegroundWindow(p.MainWindowHandle);

                        break;
                    }
                }
                #endregion
            }
            return !createdNew;
        }
    }
}