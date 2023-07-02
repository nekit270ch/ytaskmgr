using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ytaskmgr
{
    internal static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(args.Length < 1)
            {
                Application.Run(new MainForm());
            }
            else if(args[0] == "/filemgr")
            {
                if(args.Length > 1)
                {
                    Application.Run(new FileMgrForm(FileMgrUtils.GetPath(args[1])));
                }
                else
                {
                    Application.Run(new FileMgrForm());
                }
            }
            else if(args[0] == "/uninstaller")
            {
                Application.Run(new UninstallerForm());
            }
        }

        public static void UpdateProcList(ListBox box)
        {
            box.Items.Clear();
            var procList = Process.GetProcesses();
            foreach (var proc in procList)
            {
                box.Items.Add(proc.ProcessName + "#" + proc.Id);
            }
        }

        public static void UpdateProcListLoop(ListBox box, int delay)
        {
            while (true)
            {
                UpdateProcList(box);
                Thread.Sleep(delay);
            }
        }

        public static void RunTask(string name, bool asAdmin)
        {
            var p = new Process();
            p.StartInfo.FileName = name;
            if (asAdmin) p.StartInfo.Verb = "RunAs";
            p.Start();
        }

        public static void RunTask(string name, string args, bool asAdmin)
        {
            var p = new Process();
            p.StartInfo.FileName = name;
            p.StartInfo.Arguments = args;
            if (asAdmin) p.StartInfo.Verb = "RunAs";
            p.Start();
        }

        public static void RunTask(string name, string args, bool shellEx, bool asAdmin)
        {
            var p = new Process();
            p.StartInfo.FileName = name;
            p.StartInfo.Arguments = args;
            p.StartInfo.UseShellExecute = shellEx;
            if (asAdmin) p.StartInfo.Verb = "RunAs";
            p.Start();
        }

        public static void MoveToTop(Form f, bool setFocus)
        {
            f.WindowState = FormWindowState.Normal;
            if(setFocus) SetForegroundWindow(f.Handle);
        }
    }
}
