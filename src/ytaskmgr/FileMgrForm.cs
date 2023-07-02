using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using Microsoft.VisualBasic;

namespace ytaskmgr
{
    public partial class FileMgrForm : Form
    {
        public FileMgrForm()
        {
            InitializeComponent();
            FileMgrUtils.ChangeDir(Environment.GetEnvironmentVariable("USERPROFILE"), dirTextBox, files, this);
        }

        public FileMgrForm(string path)
        {
            InitializeComponent();

            FileMgrUtils.ChangeDir(FileMgrUtils.GetPath(path), dirTextBox, files, this);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            FileMgrUtils.ChangeDir("..", dirTextBox, files, this);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            FileMgrUtils.ChangeDir(dirTextBox.Text, dirTextBox, files, this);
        }

        private void files_ItemActivate(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count < 0) return;
            string name = files.SelectedItems[0].Text;
            if (Directory.Exists(name)) FileMgrUtils.ChangeDir(name, dirTextBox, files, this);
            else FileMgrUtils.OpenFile(name);
        }

        private void dirTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "Return") FileMgrUtils.ChangeDir(dirTextBox.Text, dirTextBox, files, this);
        }

        private void newWndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath, Environment.CurrentDirectory);
        }

        private void runAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = Application.ExecutablePath;
            p.StartInfo.Arguments = Environment.CurrentDirectory;
            p.StartInfo.Verb = "RunAs";
            p.Start();
            Environment.Exit(0);
        }

        private void UpdateContextMenu(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0)
            {
                ContextMenuStrip = null;
            }
            else if (Directory.Exists(FileMgrUtils.GetPath(files.SelectedItems[0].Text)))
            {
                ContextMenuStrip = dirContentMenu;
            }
            else if (File.Exists(FileMgrUtils.GetPath(files.SelectedItems[0].Text)))
            {
                ContextMenuStrip = fileContextMenu;
            }
            else
            {
                ContextMenuStrip = null;
            }
        }

        private void newFileBtn_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Введите имя файла", "Создать файл");
            if(name == null || name.Length == 0) return;

            var f = File.Create(name);
            f.Close();

            FileMgrUtils.ShowFiles(files, dirTextBox, this, Environment.CurrentDirectory);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;
            FileMgrUtils.OpenFile(name);
        }

        private void openFileWithToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string el = FileMgrUtils.GetSelectedEl(files);
            if (el == null) return;
            FileMgrUtils.OpenWithUI(el, false);
        }

        private void editFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            Process.Start("notepad", FileMgrUtils.GetPath(name));
        }

        private void renameFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            string newName = Interaction.InputBox("Введите новое имя для файла", "Переименовать файл", name);
            if(newName == null || newName.Length == 0) return;

            try
            {
                File.Move(FileMgrUtils.GetPath(name), newName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось переименовать файл \"{name}\".{Environment.NewLine}Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            FileMgrUtils.ShowFiles(files, dirTextBox, this, Environment.CurrentDirectory);
        }

        private void copyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            string dest = Interaction.InputBox("Введите путь для копирования файла", "Копировать файл", FileMgrUtils.GetPath(name));
            if (dest == null || dest.Length == 0) return;

            try
            {
                File.Copy(FileMgrUtils.GetPath(name), dest);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось скопировать файл \"{name}\".{Environment.NewLine}Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FileMgrUtils.ShowFiles(files, dirTextBox, this, Environment.CurrentDirectory);
        }

        private void moveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            string dest = Interaction.InputBox("Введите путь для перемещения файла", "Переместить файл", FileMgrUtils.GetPath(name));
            if (dest == null || dest.Length == 0) return;

            try
            {
                File.Move(FileMgrUtils.GetPath(name), dest);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось переместить файл \"{name}\".{Environment.NewLine}Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            FileMgrUtils.ShowFiles(files, dirTextBox, this, Environment.CurrentDirectory);
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            try
            {
                File.Delete(FileMgrUtils.GetPath(name));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось удалить файл \"{name}\".{Environment.NewLine}Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            FileMgrUtils.ShowFiles(files, dirTextBox, this, Environment.CurrentDirectory);
        }

        private void filePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            if (FileMgrUtils.GetPath(name) == null) return;

            var fi = new FileInfo(FileMgrUtils.GetPath(name));
            string txt = "";

            txt += "Имя: " + fi.Name + Environment.NewLine;
            txt += "Расширение: " + fi.Extension + Environment.NewLine;
            txt += "Расположение: " + fi.DirectoryName + Environment.NewLine;
            txt += "Полный путь: " + fi.FullName + Environment.NewLine;
            txt += "Размер: " + fi.Length / 1024.0 + Environment.NewLine;
            txt += "Дата создания: " + fi.CreationTime + Environment.NewLine;
            txt += "Дата последнего изменения: " + fi.LastWriteTime + Environment.NewLine;
            txt += "Дата последнего открытия: " + fi.LastAccessTime + Environment.NewLine;

            MessageBox.Show(txt, $"Свойства: {name}");
        }

        private void openDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            FileMgrUtils.ChangeDir(name, dirTextBox, files, this);
        }

        private void openDirInNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            (new FileMgrForm(FileMgrUtils.GetPath(name))).Show();
        }

        private void renameDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            string dest = Interaction.InputBox("Введите новое имя папки", "Переменовать папку", FileMgrUtils.GetPath(name));
            if (dest == null || dest.Length == 0) return;

            try
            {
                Directory.Move(FileMgrUtils.GetPath(name), dest);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось переименовать папку \"{name}\".{Environment.NewLine}Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FileMgrUtils.ShowFiles(files, dirTextBox, this, Environment.CurrentDirectory);
        }

        private void copyDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            string dest = Interaction.InputBox("Введите путь для копирования папки", "Копировать папку", FileMgrUtils.GetPath(name));
            if (dest == null || dest.Length == 0) return;

            try
            {
                Directory.Move(FileMgrUtils.GetPath(name), dest);
                Directory.Delete(FileMgrUtils.GetPath(name), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось скопировать папку \"{name}\".{Environment.NewLine}Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FileMgrUtils.ShowFiles(files, dirTextBox, this, Environment.CurrentDirectory);
        }

        private void moveDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            string dest = Interaction.InputBox("Введите путь для перемещения папки", "Переместить папку", FileMgrUtils.GetPath(name));
            if (dest == null || dest.Length == 0) return;

            try
            {
                Directory.Move(FileMgrUtils.GetPath(name), dest);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось переместить папку \"{name}\".{Environment.NewLine}Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FileMgrUtils.ShowFiles(files, dirTextBox, this, Environment.CurrentDirectory);
        }

        private void deleteDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            try
            {
                Directory.Delete(FileMgrUtils.GetPath(name), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось удалить папку \"{name}\".{Environment.NewLine}Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FileMgrUtils.ShowFiles(files, dirTextBox, this, Environment.CurrentDirectory);
        }

        private void dirPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string name = files.SelectedItems[0].Text;

            if (FileMgrUtils.GetPath(name) == null) return;

            var di = new DirectoryInfo(FileMgrUtils.GetPath(name));
            string txt = "";

            txt += "Имя: " + di.Name + Environment.NewLine;
            txt += "Родительская папка: " + di.Parent.FullName + Environment.NewLine;
            txt += "Полный путь: " + di.FullName + Environment.NewLine;
            txt += "Дата создания: " + di.CreationTime + Environment.NewLine;
            txt += "Дата последнего изменения: " + di.LastWriteTime + Environment.NewLine;
            txt += "Дата последнего открытия: " + di.LastAccessTime + Environment.NewLine;

            MessageBox.Show(txt, "Свойства: " + name);
        }
    }
}
