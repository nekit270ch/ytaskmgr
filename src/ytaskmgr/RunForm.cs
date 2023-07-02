using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ytaskmgr
{
    public partial class RunForm : Form
    {
        public RunForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Программы|*.exe;*.bat;*.cmd|Все файлы|*.*";
            ofd.Title = "Обзор";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                cmdTextBox.Text = ofd.FileName;
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            string cmd = cmdTextBox.Text;

            if (cmd.Trim().Length == 0) return;

            List<string> cmdL = cmd.Split(' ').ToList<string>();
            string args = "";

            foreach (string s in cmdL.Skip(1))
            {
                if (s.Contains(" ")) args += $"\"{s}\" ";
                else args += s + " ";
            }

            try
            {
                Program.RunTask(cmdL[0], args, true, asAdminCheckBox.Checked);
                Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RunForm_Load(object sender, EventArgs e)
        {
            cmdTextBox.Focus();
        }
    }
}
