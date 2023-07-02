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

namespace ytaskmgr
{
    public partial class MainForm: Form
    {
        private void sysdmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("sysdm.cpl");
        }

        private void userPasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("control", "userpasswords");
        }

        private void userPasswords2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("control", "userpasswords2");
        }

        private void emptyConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mmc");
        }

        private void azmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("azman.msc");
        }

        private void certlmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("certlm.msc");
        }

        private void certmgrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("certmgr.msc");
        }

        private void comexpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("comexp.msc");
        }

        private void compmgmtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("compmgmt.msc");
        }

        private void devmgmtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }

        private void eventvwrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("eventvwr.msc");
        }

        private void fsmgmtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("fsmgmt.msc");
        }

        private void lusrmgrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("lusrmgr.msc");
        }

        private void perfmonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("perfmon.msc");
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
        }

        private void taskschdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("taskschd.msc");
        }

        private void tpmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("tpm.msc");
        }

        private void virtmgmtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("virtmgmt.msc");
        }

        private void WFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wf.msc");
        }

        private void wmimgmtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wmimgmt.msc");
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }

        private void windowsPowerShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("powershell");
        }

        private void wslToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wsl");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void wordPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wordpad");
        }
    }
}
