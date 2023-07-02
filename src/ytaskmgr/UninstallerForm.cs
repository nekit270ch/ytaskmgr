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
    public partial class UninstallerForm : Form
    {
        public UninstallerForm()
        {
            InitializeComponent();

            Uninstaller.listBox = programsCheckedListBox;
            Uninstaller.uninstallButton = uninstallBtn;

            Uninstaller.UpdateProgList();
        }

        private void uninstallBtn_Click(object sender, EventArgs e)
        {
            Uninstaller.Uninstall();
        }
    }
}
