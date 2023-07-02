using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;

namespace ytaskmgr
{
    static class Uninstaller
    {
        public static string regPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        public static CheckedListBox listBox;
        public static Button uninstallButton;
        public static RegistryKey key;
        public static Dictionary<string, string> programs = new Dictionary<string, string>();

        public static void UpdateProgList()
        {
            programs.Clear();

            key = Registry.LocalMachine.OpenSubKey(regPath);

            foreach (string k in key.GetSubKeyNames())
            {
                var sk = key.OpenSubKey(k);
                if (sk.GetValue("UninstallString") == null) continue;

                string name;
                if (sk.GetValue("DisplayName") == null) name = k;
                else name = sk.GetValue("DisplayName").ToString();

                listBox.Items.Add(name);
                programs.Add(name, sk.GetValue("UninstallString").ToString());

                sk.Close();
            }

            key.Close();
        }

        public static void Uninstall()
        {
            if (listBox.CheckedItems.Count == 0) return;

            string selectedProgs = "";
            foreach(string k in listBox.CheckedItems)
            {
                selectedProgs += k + Environment.NewLine;
            }

            if (MessageBox.Show(
                $"Вы точно хотите удалить эти программы?{Environment.NewLine}{selectedProgs}",
                "Деинсталлятор",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.No) return;

            foreach(string prog in listBox.CheckedItems)
            {
                var p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/c " + programs[prog];
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.WaitForExit();
            }
        }
    }
}
