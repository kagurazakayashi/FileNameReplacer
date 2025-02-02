using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            string[] paths = SysInfo.GetCommonUserFolders();
            foreach (var path in paths)
            {
                comboBoxRootPath.Items.Add(path);
            }
            string[] drives = SysInfo.GetDrives();
            foreach (var drive in drives)
            {
                comboBoxRootPath.Items.Add(drive);
            }
            comboBoxRootPath.SelectedIndex = 0;
            string[] extensions = SysInfo.GetRegisteredFileExtensions();
            foreach (var ext in extensions)
            {
                comboBoxSearch.Items.Add("*" + ext);
            }
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

        private void updateListBoxItemCount()
        {
            int dir = 0, file = 0;
            //dataFileList.Rows[dataLen].Cells[1].Value = fileItem.inPath;
            foreach (DataGridViewRow row in dataFileList.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    dir++;
                }
                else
                {
                    file++;
                }
            }
            toolStripButtonNumDir.Text = dir.ToString();
            toolStripButtonNumFile.Text = file.ToString();
            //string[] texts = toolStripButtonNumDir.Text.Split(' ');
            //texts[0] = dataFileList.Rows.Count.ToString();
            //toolStripButtonNumDir.Text = string.Join(" ", texts);
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            //TODO
            //if (UIAction.ChkListBoxIsEmpty(listBoxSearchResults) || UIAction.ChkComboBoxIsEmpty(comboBoxReplaceFrom)) return;
            preview();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            //TODO
            //if (UIAction.ChkListBoxIsEmpty(listBoxSearchResults) || UIAction.ChkComboBoxIsEmpty(comboBoxReplaceFrom)) return;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxRootPath.Text.Length == 0)
            {
                buttonChgRootPath_Click(sender, e);
                if (comboBoxRootPath.Text.Length == 0)
                {
                    MessageBox.Show("请指定要搜索的文件夹。", "请填写必要信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (comboBoxSearch.Text.Length == 0)
            {
                comboBoxSearch.Text = "*";
            }
            if (!backgroundWorkerSearch.IsBusy)
            {
                searchRunningUI(true);
                dataFileList.Rows.Clear();
                backgroundWorkerSearch.RunWorkerAsync(); // 开始异步搜索
            }
        }

        private void backgroundWorkerSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            // 先讀取 UI 控制元件的值，確保資料在 UI 執行緒中獲取
            string rootPath = "";
            string searchPattern = "";
            bool searchSubDir = false;
            bool searchDir = false;
            bool searchFile = false;
            decimal maxSearchLimit = 0;
            this.Invoke((MethodInvoker)delegate
            {
                rootPath = comboBoxRootPath.Text;
                searchPattern = comboBoxSearch.Text;
                searchSubDir = checkBoxASub.Checked;
                searchDir = checkBoxADir.Checked;
                searchFile = checkBoxAFile.Checked;
                maxSearchLimit = numericUpDownLimit.Value;
            });
            searchEngine = new Search
            {
                rootDir = rootPath,
                searchMode = searchPattern,
                searchSubDir = searchSubDir,
                searchDir = searchDir,
                searchFile = searchFile,
                maxSearchLimit = maxSearchLimit,
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
                int dataLen = dataFileList.Rows.Count;
                dataFileList.Rows.Add(); //dataGridView
                dataFileList.Rows[dataLen].Cells[1].Value = fileItem.inPath;
                dataFileList.Rows[dataLen].Cells[2].Value = fileItem.fileName;
                dataFileList.Rows[dataLen].Cells[4].Value = fileItem.isDir;
                if (fileItem.isDir)
                {
                    dataFileList.Rows[dataLen].Cells[0].Value = Properties.Resources.FolderClosed;
                    toolStripButtonNumDir.Text = (int.Parse(toolStripButtonNumDir.Text) + 1).ToString();
                }
                else
                {
                    toolStripButtonNumFile.Text = (int.Parse(toolStripButtonNumDir.Text) + 1).ToString();
                }
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
            if (!isRun)
            {
                dataFileList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxRootPath.Text = "B:\\TestFolder";
            comboBoxSearch.Text = "2024*";
        }

        private void checkBoxLimit_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownLimit.Enabled = checkBoxLimit.Checked;
            if (!checkBoxLimit.Checked)
            {
                numericUpDownLimit.Value = numericUpDownLimit.Maximum;
            }
            else if (numericUpDownLimit.Value == numericUpDownLimit.Maximum)
            {
                numericUpDownLimit.Value = 10000;
            }
        }

        private void preview()
        {
            //string[] searchResults = listBoxSearchResults.Items
            //.Cast<string>()
            //.Select(item => {
            //    int index = item.IndexOf(' ');
            //    return index >= 0 ? item.Substring(index + 1) : item;
            //})
            //.ToArray();

            //foreach (string searchResult in listBoxSearchResults.Items)
            //{
            //    string[] pathUnit = searchResult.Split(' ');
            //    string path = string.Join(" ", pathUnit.Skip(1));
                
            //}
        }

        private void backgroundWorkerReplace_DoWork(object sender, DoWorkEventArgs e)
        {
            // 先讀取 UI 控制元件的值，確保資料在 UI 執行緒中獲取
            
        }

        private void backgroundWorkerReplace_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorkerReplace_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void toolStripButtonP1rm_Click(object sender, EventArgs e)
        {
            if (dataFileList.CurrentCell != null)
            {
                dataFileList.Rows.RemoveAt(dataFileList.CurrentCell.RowIndex);
            }
        }

        private void toolStripButtonP1cp_Click(object sender, EventArgs e)
        {
            if (dataFileList.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                Clipboard.SetDataObject(dataFileList.GetClipboardContent());
            }
        }

        private void toolStripButtonP1cls_Click(object sender, EventArgs e)
        {
            dataFileList.Rows.Clear();
        }

        private void dataFileList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateListBoxItemCount();
        }
    }
}
