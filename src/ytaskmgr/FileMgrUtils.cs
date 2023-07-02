using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using Microsoft.VisualBasic;

namespace ytaskmgr
{
    static class FileMgrUtils
    {
        public static void AddItemsToLV(ListView lw, string[] names)
        {
            if (names.Length == 0) throw new ArgumentException("Массивы names и images должны не быть пустыми и иметь одинаковое число элементов");

            lw.Items.Clear();

            for (int i = 0; i < names.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = " " + names[i];
                lw.Items.Add(item);
            }
        }

        public static void AddItemsToLV(ListView lw, string[] names, string[] images)
        {
            if (names.Length == 0 || images.Length == 0 || names.Length != images.Length) throw new ArgumentException("Массивы names и images должны не быть пустыми и иметь одинаковое число элементов");

            lw.Items.Clear();

            var imgList = new ImageList();

            for (int i = 0; i < names.Length; i++)
            {
                imgList.Images.Add(Image.FromFile(images[0]));

                ListViewItem item = new ListViewItem();
                item.Text = " " + names[i];
                item.ImageIndex = i;
                lw.Items.Add(item);
            }

            lw.SmallImageList = imgList;
        }

        public static void ShowFiles(ListView lw, TextBox tb, Form fr, string d)
        {
            lw.ContextMenuStrip = null;

            string[] f;
            try
            {
                f = ListDirsAndFiles(d);
            }catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть папку \"{d}\".{Environment.NewLine}Причина: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeDir(GetPath(".."), tb, lw, fr);
                return;
            }

            lw.Clear();

            lw.Columns.Add("name", "Имя", lw.Width / 2);
            lw.Columns.Add("type", "Тип", lw.Width / 6);
            lw.Columns.Add("size", "Размер (кБ)", lw.Width / 6);

            foreach (string s in f)
            {
                string[] arr = new string[3];

                arr[0] = s;
                if (Directory.Exists(s))
                {
                    arr[1] = "Папка";
                    arr[2] = "-";
                }
                else
                {
                    try
                    {
                        var fi = new FileInfo(s);
                        arr[1] = $"Файл \"{fi.Extension.ToUpper().Replace(".", "")}\"";
                        arr[2] = (fi.Length / 1024.0).ToString();
                    }
                    catch (Exception)
                    {
                        arr[1] = "Файл";
                        arr[2] = "Ошибка";
                    }
                }
                
                lw.Items.Add(new ListViewItem(arr));
            }
        }

        public static string GetPath(string p)
        {
            try
            {
                if (p.Length == 0) p = ".";
                string path = Path.IsPathRooted(p) ? p : Path.GetFullPath(p);
                if (File.Exists(path) || Directory.Exists(path)) return path;
            }catch(Exception) { }
            return null;
        }

        public static string[] ListDirsAndFiles(string d)
        {
            string[] dirs = Directory.GetDirectories(d);
            string[] files = Directory.GetFiles(d);
            List<string> result = new List<string>();
            result.AddRange(dirs);
            result.AddRange(files);
            for (int i = 0; i < result.Count; i++)
            {
                result[i] = Path.GetFileName(result[i]);
            }
            return result.ToArray();
        }

        public static void ChangeDir(string dir, TextBox tb, ListView lw, Form f)
        {
            string d = GetPath(dir);
            if(d == null || !Directory.Exists(d))
            {
                MessageBox.Show($"Папка \"{dir}\" не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Environment.CurrentDirectory = d;
            tb.Text = d;
            f.Text = d;
            ShowFiles(lw, tb, f, d);
        }

        public static void OpenFile(string fn)
        {
            var hkcr = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Default);
            try
            {
                var t = hkcr.OpenSubKey(new FileInfo(fn).Extension);
                if(t == null)
                {
                    OpenWithUI(fn, true);
                    return;
                }
                var tp = t.GetValue("");
                if (tp == null)
                {
                    OpenWithUI(fn, true);
                    return;
                }
                string type = tp.ToString();

                var p = hkcr.OpenSubKey(type + "\\shell\\open\\command");
                if (p == null)
                {
                    OpenWithUI(fn, true);
                    return;
                }
                var prg = p.GetValue("");
                if (prg == null)
                {
                    OpenWithUI(fn, true);
                    return;
                }
                string prog = prg.ToString();

                string[] cmd = prog.Split(new char[] { ' ' }, 2);
                if (cmd[0].Contains("%1")) Process.Start(GetPath(fn));
                else
                {
                    Process.Start(cmd[1].Replace("%1", GetPath(fn)));
                }
            }catch (Exception)
            {
                OpenWithUI(fn, true);
            }
        }

        public static void OpenWithUI(string fn, bool mode)
        {
            string prog = Interaction.InputBox((mode ? $"Программа для открытия файла \"{fn}\" не найдена.{Environment.NewLine}Укажите команду его открытия." : $"Укажите команду для открытия файла \"{fn}\""), "Открыть с помощью...", "notepad.exe %1");
            string[] cmd = prog.Split(new char[] { ' ' }, 2);
            if (cmd.Length < 2) return;
            if (cmd[0].Contains("%1")) Process.Start(GetPath(fn));
            else
            {
                Process.Start(cmd[0], cmd[1].Replace("%1", GetPath(fn)));
            }
        }

        public static string GetSelectedEl(ListView lw)
        {
            if (lw.SelectedItems.Count < 1) return null;
            return lw.SelectedItems[0].Text;
        }
    }
}
