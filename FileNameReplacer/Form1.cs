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
        private Search searchEngine;

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
            if (!backgroundWorkerSearch.IsBusy)
            {
                searchRunningUI(true);
                listBoxSearchResults.Items.Clear(); // 清空 ListBox
                backgroundWorkerSearch.RunWorkerAsync(); // 开始异步搜索
            }
        }

        private void backgroundWorkerSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            // 先读取 UI 控件的值，确保数据在 UI 线程中获取
            string rootPath = "";
            string searchPattern = "";
            bool searchSubDir = false;
            bool searchDir = false;
            bool searchFile = false;
            this.Invoke((MethodInvoker)delegate
            {
                rootPath = comboBoxRootPath.Text;
                searchPattern = comboBoxSearch.Text;
                searchSubDir = checkBoxASub.Checked;
                searchDir = checkBoxADir.Checked;
                searchFile = checkBoxAFile.Checked;
            });
            searchEngine = new Search
            {
                rootDir = rootPath,
                searchMode = searchPattern,
                searchSubDir = searchSubDir,
                searchDir = searchDir,
                searchFile = searchFile,
                ShouldCancel = () => backgroundWorkerSearch.CancellationPending
            };
            // 绑定回调函数
            searchEngine.OnFileFound = (fileItem) =>
            {
                if (backgroundWorkerSearch.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                // 向 UI 线程发送搜索结果
                backgroundWorkerSearch.ReportProgress(0, fileItem);
            };
            searchEngine.SearchFile();
            // 任務完成後，檢查是否被取消
            if (backgroundWorkerSearch.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorkerSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is FileItem fileItem)
            {
                listBoxSearchResults.Items.Add($"{(fileItem.isDir ? icoDir : icoFile)} {fileItem.inPath}\\{fileItem.fileName}");
            }
        }

        private void backgroundWorkerSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            searchRunningUI(false);
            if (e.Cancelled)
            {
                MessageBox.Show("搜索已取消。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("搜索完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSearchStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerSearch.IsBusy)
            {
                backgroundWorkerSearch.CancelAsync();
            }
            if (!backgroundWorkerSearch.IsBusy)
            {
                searchRunningUI(false);
            }
        }

        private void searchRunningUI(bool isRun)
        {
            UIAction.DisableControls(this, !isRun);
            buttonSearch.Visible = !isRun;
            buttonSearchStop.Visible = isRun;
            buttonSearchStop.Enabled = isRun;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxRootPath.Text = "B:\\TestFolder";
            comboBoxSearch.Text = "2024";
        }
    }
}
