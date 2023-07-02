using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using Microsoft.Win32;

namespace ytaskmgr
{
    public partial class MainForm : Form
    {
        string pProc = "";

        public MainForm()
        {
            InitializeComponent();

            Program.UpdateProcList(ProcListBox);
        }

        private void RunNewTaskMenuItem_Click(object sender, EventArgs e)
        {
            (new RunForm()).ShowDialog();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
        }

        private void runAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new Process();
                p.StartInfo.FileName = Application.ExecutablePath;
                p.StartInfo.Verb = "RunAs";
                p.Start();
                Environment.Exit(0);
            }catch (Exception) { }
        }

        private void forceUpdateProcListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.UpdateProcList(ProcListBox);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"YTaskMgr 0.4 by nekit270 (https://github.com/nekit270ch){Environment.NewLine}{Environment.NewLine}Многофункциональный диспетчер задач со встроенным файловым менеджером и другими утилитами.{Environment.NewLine}{Environment.NewLine}Лицензия: MIT (https://github.com/nekit270ch/ytaskmgr/blob/main/LICENSE)", "О программе");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void runNewTaskAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cmd = Interaction.InputBox("Запустить процесс", pProc);
            if (cmd == null || cmd.Length == 0) return;
            pProc = cmd;

            List<string> cmdL = cmd.Split(' ').ToList<string>();
            string args = "";

            foreach (string s in cmdL.Skip(1))
            {
                if (s.Contains(" ")) args += $"\"{s}\" ";
                else args += s + " ";
            }

            Program.RunTask(cmdL[0], args, true, true);
        }

        private void fileMgrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FileMgrForm()).Show();
        }

        private void uninstallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new UninstallerForm()).Show();
        }

        private void runWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "shell:::{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}");
        }

        private void ProcListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProcListBox.SelectedItems.Count == 0)
            {
                ContextMenuStrip = null;
            }
            else
            {
                ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string p = ProcListBox.Text;
            if (MessageBox.Show($"Завершить процесс \"{p}\"?", "YTaskMgr", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Int32.Parse(p.Split('#')[1]);
                    Process.GetProcessById(id).Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Thread.Sleep(50);
                Program.UpdateProcList(ProcListBox);
            }
        }

        private void procFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ProcListBox.Text;

                int id = Int32.Parse(name.Split('#')[1]);
                var p = Process.GetProcessById(id);

                (new FileMgrForm(new FileInfo(p.MainModule.FileName).DirectoryName)).Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ProcListBox.Text;
                int id = Int32.Parse(name.Split('#')[1]);
                var p = Process.GetProcessById(id);
                string txt = "";

                txt += "ID: " + p.Id + Environment.NewLine;
                txt += "Название: " + p.ProcessName + Environment.NewLine;
                txt += "Путь к файлу: " + p.MainModule.FileName + Environment.NewLine;
                txt += "Дескриптор: " + p.Handle + Environment.NewLine;
                txt += "Занятая память: " + p.WorkingSet64 + Environment.NewLine;
                txt += "Адрес: 0x" + p.MainModule.BaseAddress.ToString("X") + Environment.NewLine;
                txt += "Адрес точки входа: 0x" + p.MainModule.EntryPointAddress.ToString("X") + Environment.NewLine;

                MessageBox.Show(txt, "Свойства: " + name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.UpdateProcList(ProcListBox);

            string p = Interaction.InputBox("Введите часть названия или ID процесса", "Найти процесс", "*");
            if (p == null || p == "" || p == "*") return;

            var proc = new string[ProcListBox.Items.Count];
            ProcListBox.Items.CopyTo(proc, 0);

            ProcListBox.Items.Clear();

            foreach(string item in proc)
            {
                if (item.Contains(p)) ProcListBox.Items.Add(item);
            }
        }

        private void runAtSystemStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string n = Environment.NewLine;

            if (MessageBox.Show(
                $"Запустить YTaskMgr во время загрузки системы?{n+n}Это полезно, если вирусы не позволяют программе работать.{n+n}ВНИМАНИЕ! Данное действие требует прав администратора!",
                "Запуск во время загрузки системы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.No) return;

            try
            {
                var skey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup", true);
                skey.SetValue("SetupType", 2);
                skey.SetValue("CmdLine", Application.ExecutablePath);
                skey.Close();

                var pkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true);
                pkey.SetValue("EnableCursorSuppression", 0);
                pkey.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
