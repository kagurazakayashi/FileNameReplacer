using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FileNameReplacer
{
    static class UIAction
    {
        public static string NormalizePath(string path)
        {
            string normalizedPath = Regex.Replace(path, @"[\\/]+", Path.DirectorySeparatorChar.ToString());
            return Path.GetFullPath(normalizedPath).TrimEnd(Path.DirectorySeparatorChar);
        }

        static public void ListBoxDelItem(ListBox box)
        {
            if (box.SelectedItems.Count > 0)
            {
                for (int i = box.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    box.Items.RemoveAt(box.SelectedIndices[i]);
                }
            }
        }

        static public void ListBoxSelectAll(ListBox box)
        {
            for (int i = 0; i < box.Items.Count; i++)
            {
                box.SetSelected(i, true);
            }
        }

        static public void ListBoxCopyToClipboard(ListBox box)
        {
            if (box.Items.Count == 0) return;
            string text;
            if (box.SelectedItems.Count == 0)
            {
                ListBoxSelectAll(box);
            }
            text = string.Join(Environment.NewLine, box.SelectedItems.Cast<string>());
            Clipboard.SetText(text);
        }

        static public bool ChkComboBoxIsEmpty(ComboBox box)
        {
            if (box.Text.Length == 0)
            {
                MessageBox.Show("请先输入要替换的字符。", "没有要替换的字符", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        static public void DisableControls(Control parent, bool enabled)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is ComboBox || control is CheckBox || control is Button || control is NumericUpDown)
                {
                    control.Enabled = enabled;
                }
                if (control.HasChildren)
                {
                    DisableControls(control, enabled);
                }
            }
        }

        static public string ReplaceIgnoringCase(string input, string oldValue, string newValue)
        {
            int index = 0;
            while ((index = input.IndexOf(oldValue, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                input = input.Remove(index, oldValue.Length).Insert(index, newValue);
                index += newValue.Length;
            }
            return input;
        }

        static public ReplaceJob[] SortJobsByLevel(ReplaceJob[] jobs)
        {
            Array.Sort(jobs, (job1, job2) => job2.PathLevel.CompareTo(job1.PathLevel));
            return jobs;
        }
    }
}
