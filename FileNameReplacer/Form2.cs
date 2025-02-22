using FileNameReplacer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileNameReplacer
{
    public partial class Form2 : Form
    {
        public string Value = "";

        public void updateValue()
        {
            List<string> list = new List<string>();
            foreach (string v in listBox1.Items)
            {
                list.Add(v);
            }
            Value = string.Join(";", list);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DarkMode.AutoDarkMode(this);
        }

        public void loadData(string val)
        {
            Value = val;
            foreach (string v in val.Split(';'))
            {
                if (v.Length > 0)
                {
                    appendToListBox(v);
                }
            }
            updateValue();
            cleanEmptyItems();
            removeDuplicatesFromListBox();
            chkHasData();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                appendToListBox(textBox1.Text);
                textBox1.Text = "";
                updateValue();
            }
            cleanEmptyItems();
            chkHasData();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleanEmptyItems();
            List<object> itemsToRemove = new List<object>();
            foreach (var item in listBox1.SelectedItems)
            {
                itemsToRemove.Add(item);
            }
            foreach (var item in itemsToRemove)
            {
                listBox1.Items.Remove(item);
            }
            updateValue();
            chkHasData();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleanEmptyItems();
            removeDuplicatesFromListBox();
            updateValue();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            updateValue();
            chkHasData();
            textBox1.Focus();
        }

        private void chkHasData()
        {
            bool hasData = listBox1.Items.Count > 0;
            button5.Enabled = hasData;
            button7.Enabled = hasData;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hasData = listBox1.SelectedItems.Count > 0;
            button2.Enabled = hasData;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cleanEmptyItems();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        foreach (var item in listBox1.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "保存文件时发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                toolTip1.ToolTipTitle = "已将文件保存到：";
                Point mousePosition = this.PointToClient(Cursor.Position);
                toolTip1.Show(saveFileDialog1.FileName, this, mousePosition);
                timerToolTipHide.Enabled = true;
            }
            chkHasData();
        }

        private void timerToolTipHide_Tick(object sender, EventArgs e)
        {
            timerToolTipHide.Enabled = false;
            toolTip1.Hide(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cleanEmptyItems();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (listBox1.Items.Count > 0)
                {
                    DialogResult res = MessageBox.Show("列表中已经有内容了，要替换它们吗？\r\n[是] 替换内容。\r\n[否] 追加内容。", "解决冲突", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        listBox1.Items.Clear();
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            appendToListBox(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "加载文件时发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            cleanEmptyItems();
            chkHasData();
        }

        private void cleanEmptyItems()
        {
            if (listBox1.Items.Count > 0)
            {
                for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listBox1.Items[i];
                    if (item == null || string.IsNullOrWhiteSpace(item.ToString()))
                    {
                        listBox1.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void appendToListBox(string content)
        {
            if (!listBox1.Items.Contains(content))
            {
                listBox1.Items.Add(content);
            }
        }

        private void removeDuplicatesFromListBox()
        {
            HashSet<string> uniqueItems = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                string item = listBox1.Items[i].ToString();
                if (uniqueItems.Contains(item))
                {
                    listBox1.Items.RemoveAt(i);
                }
                else
                {
                    uniqueItems.Add(item);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Help help = new Help("搜索条件", Resources.SearchF);
            help.ShowDialog();
        }
    }
}
