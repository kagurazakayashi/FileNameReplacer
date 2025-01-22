using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileNameReplacer
{
    public partial class Form1: Form
    {
        private Search search = new Search();
        private static string icoFile = "📄";
        private static string icoDir = "📁";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSearch.SelectedIndex = 0;
            updateListBoxItemCount();
        }

        private void buttonChgRootPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                comboBoxRootPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void toolStripButtonP1rm_Click(object sender, EventArgs e)
        {
            UIAction.ListBoxDelItem(listBoxSearchResults);
            UIAction.ToolStripButtonCountListBox(toolStripButtonP1Num, listBoxSearchResults);

        }

        private void toolStripButtonP1cp_Click(object sender, EventArgs e)
        {
            UIAction.ListBoxCopyToClipboard(listBoxSearchResults);
        }

        private void toolStripButtonP1cls_Click(object sender, EventArgs e)
        {
            cleanListBox();
        }

        private void toolStripButtonP2cp_Click(object sender, EventArgs e)
        {
            UIAction.ListBoxCopyToClipboard(listBoxReplacePreview);
        }

        private void toolStripButtonP2cls_Click(object sender, EventArgs e)
        {
            cleanListBox();
        }

        private void updateListBoxItemCount()
        {
            UIAction.ToolStripButtonCountListBox(toolStripButtonP1Num, listBoxSearchResults);
            UIAction.ToolStripButtonCountListBox(toolStripButtonP2Num, listBoxReplacePreview);
        }

        private void cleanListBox()
        {
            UIAction.ListBoxDelAll(listBoxSearchResults);
            UIAction.ListBoxDelAll(listBoxReplacePreview);
            updateListBoxItemCount();
        }

        private void toolStripButtonP3cp_Click(object sender, EventArgs e)
        {
            if (textBoxRunLog.Text != null && textBoxRunLog.Text.Length > 0)
            {
                Clipboard.SetText(textBoxRunLog.Text);
            }
        }

        private void toolStripButtonP3cls_Click(object sender, EventArgs e)
        {
            textBoxRunLog.Text = "";
        }

        private void listBoxReplacePreview_KeyDown(object sender, KeyEventArgs e)
        {
            UIAction.ListBoxKeyDown(listBoxReplacePreview, e);
        }

        private void listBoxSearchResults_KeyDown(object sender, KeyEventArgs e)
        {
            UIAction.ListBoxKeyDown(listBoxSearchResults, e);
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (UIAction.ChkListBoxIsEmpty(listBoxSearchResults) || UIAction.ChkComboBoxIsEmpty(comboBoxReplaceFrom)) return;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (UIAction.ChkListBoxIsEmpty(listBoxSearchResults) || UIAction.ChkComboBoxIsEmpty(comboBoxReplaceFrom)) return;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // 创建 Search 对象
            Search search = new Search
            {
                rootDir = comboBoxRootPath.Text,  // 搜索的根目录
                searchMode = comboBoxSearch.Text,   // 搜索文件
                searchSubDir = checkBoxASub.Checked,    // 递归搜索子目录
                searchDir = checkBoxADir.Checked,       // 也包括文件夹
                searchFile = checkBoxAFile.Checked       // 也包括文件
            };
            // 执行搜索
            List<FileItem> results = search.SearchFile();

            // 输出搜索结果
            listBoxSearchResults.Items.Clear();
            foreach (FileItem item in results)
            {
                listBoxSearchResults.Items.Add($"{(item.isDir ? icoDir : icoFile)} {item.inPath}\\{item.fileName}");
            }
        }
    }
}
