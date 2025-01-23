using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileNameReplacer
{
    static class UIAction
    {
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

        static public void ListBoxDelAll(ListBox box)
        {
            box.Items.Clear();
        }

        static public void ListBoxKeyDown(ListBox box, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) // Ctrl+A
            {
                ListBoxSelectAll(box);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.C) // Ctrl+C
            {
                ListBoxCopyToClipboard(box);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete) // Delete
            {
                ListBoxDelItem(box);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape) // Esc
            {
                box.ClearSelected();
                e.Handled = true;
            }
        }

        static public void ToolStripButtonCountListBox(ToolStripButton btn, ListBox box)
        {
            string[] texts = btn.Text.Split(' ');
            texts[0] = box.Items.Count.ToString();
            btn.Text = string.Join(" ", texts);
        }

        static public bool ChkListBoxIsEmpty(ListBox box)
        {
            if (box.Items.Count == 0)
            {
                MessageBox.Show("文件列表为空，请先搜索要执行操作的文件(夹)。", "没有需要处理的文件(夹)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
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
                if (control is ComboBox || control is CheckBox || control is Button)
                {
                    control.Enabled = enabled;
                }
                if (control.HasChildren)
                {
                    DisableControls(control, enabled);
                }
            }
        }
    }
}
