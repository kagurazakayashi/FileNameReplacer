using FileNameReplacer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FileNameReplacer
{
    public partial class Form1: Form
    {
        private Search searchEngine;
        private Replace replaceEngine;
        private Int16 FileAction = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerLoad.Enabled = true;
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
            if (searchEngine != null)
            {
                searchEngine.TotalC[0] = dir;
                searchEngine.TotalC[1] = file;
            }
            toolStripButtonNumDir.Text = dir.ToString();
            toolStripButtonNumFile.Text = file.ToString();
            if (dir == 0 && file == 0)
            {
                labelUpdateAlert.Text = "没有文件可以操作";
                labelUpdateAlert.Visible = true;
                tabControl2.Visible = false;
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (UIAction.ChkComboBoxIsEmpty(comboBoxReplaceFrom)) return;
            previewAll();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (UIAction.ChkComboBoxIsEmpty(comboBoxReplaceFrom)) return;
            if (dataFileList.Rows.Count == 0)
            {
                MessageBox.Show("文件处理列表是空的，请先进行文件搜索。", "请先指定要操作的文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxReplaceFrom.Text == comboBoxReplaceTo.Text)
            {
                MessageBox.Show("替换前后的内容是一样的。", "无效替换", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            previewAll();
            if (!backgroundWorkerReplace.IsBusy)
            {
                searchRunningUI(true, 0);
                FileAction = 0;
                pictureBoxReplace.Image = Resources.FILEMOVE;
                backgroundWorkerReplace.RunWorkerAsync();
            }
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
                searchRunningUI(true, -1);
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
            int sleepTime = 1;
            this.Invoke((MethodInvoker)delegate
            {
                rootPath = comboBoxRootPath.Text;
                searchPattern = comboBoxSearch.Text;
                searchSubDir = checkBoxASub.Checked;
                searchDir = checkBoxADir.Checked;
                searchFile = checkBoxAFile.Checked;
                maxSearchLimit = numericUpDownLimit.Value;
                sleepTime = Convert.ToInt32(numericUpDownSleep.Value);
            });
            List<string> tPattern = new List<string>();
            foreach (string patt in searchPattern.Split(';'))
            {
                if (patt.Length > 0)
                {
                    tPattern.Add(patt);
                }
            }
            searchEngine = new Search
            {
                rootDir = rootPath,
                searchMode = tPattern.ToArray(),
                searchSubDir = searchSubDir,
                searchDir = searchDir,
                searchFile = searchFile,
                maxSearchLimit = maxSearchLimit,
                SleepTime = sleepTime,
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

        private void addFileItemToList(FileItem fileItem)
        {
            int dataLen = dataFileList.Rows.Count;
            dataFileList.Rows.Add(); //dataGridView
            dataFileList.Rows[dataLen].Cells[1].Value = UIAction.NormalizePath(fileItem.inPath);
            dataFileList.Rows[dataLen].Cells[2].Value = fileItem.fileName;
            dataFileList.Rows[dataLen].Cells[4].Value = fileItem.isDir;
            dataFileList.Rows[dataLen].Cells[6].Value = dataLen.ToString();
            if (fileItem.isDir)
            {
                dataFileList.Rows[dataLen].Cells[0].Value = Resources.FolderClosed;
                int num = int.Parse(toolStripButtonNumDir.Text) + 1;
                toolStripButtonNumDir.Text = num.ToString();
                if (searchEngine != null) searchEngine.TotalC[0] = num;
            }
            else
            {
                int num = int.Parse(toolStripButtonNumDir.Text) + 1;
                toolStripButtonNumFile.Text = num.ToString();
                if (searchEngine != null) searchEngine.TotalC[1] = num;
            }
            if (checkBoxRealWidth.Checked)
            {
                dataFileList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void backgroundWorkerSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is FileItem fileItem)
            {
                addFileItemToList(fileItem);
            }
        }

        private void backgroundWorkerSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            searchRunningUI(false, -1);
            notifyIcon1.Visible = true;
            if (e.Cancelled || searchEngine.Status == 2)
            {
                notifyIcon1.ShowBalloonTip(3000, "搜索已取消。", $"找到了 {toolStripButtonNumDir.Text} 个文件夹和 {toolStripButtonNumFile.Text} 个文件。", ToolTipIcon.Error);
            }
            else
            {
                notifyIcon1.ShowBalloonTip(3000, "搜索完成。", $"找到了 {toolStripButtonNumDir.Text} 个文件夹和 {toolStripButtonNumFile.Text} 个文件。", ToolTipIcon.Info);
            }
            //labelUpdateAlert
            if (dataFileList.Rows.Count > 0)
            {
                buttonReplace.Enabled = true;
                buttonRM.Enabled = true;
                labelUpdateAlert.Visible = false;
                tabControl2.Visible = true;
            }
            else
            {
                labelUpdateAlert.Text = "没有文件可以操作";
                labelUpdateAlert.Visible = true;
                tabControl2.Visible = false;
            }
        }

        private void buttonSearchStop_Click(object sender, EventArgs e)
        {
            buttonSearchStop.Enabled = false;
            if (backgroundWorkerSearch.IsBusy)
            {
                backgroundWorkerSearch.CancelAsync();
            }
            if (!backgroundWorkerSearch.IsBusy)
            {
                searchRunningUI(false, -1);
            }
        }

        private void searchRunningUI(bool isRun, Int16 mode)
        {
            this.Cursor = isRun ? Cursors.AppStarting : Cursors.Default;
            UIAction.DisableControls(this, !isRun);
            dataFileList.Cursor = this.Cursor;

            buttonSearch.Enabled = false;
            buttonSearch.Visible = true;
            buttonSearchStop.Enabled = false;
            buttonSearchStop.Visible = false;

            buttonReplace.Enabled = false;
            buttonReplace.Visible = true;
            buttonReplaceStop.Enabled = false;
            buttonReplaceStop.Visible = false;

            buttonRM.Enabled = false;
            buttonRM.Visible = true;
            buttonRMStop.Enabled = false;
            buttonRMStop.Visible = false;

            pictureBoxSearch.Visible = false;
            pictureBoxReplace.Visible = false;
            tabControl2.Visible = true;
            progressBar1.Style = ProgressBarStyle.Blocks;

            if (isRun)
            {
                notifyIcon1.Visible = true;
                labelUpdateAlert.Visible = false;
                if (mode == -1)
                {
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    pictureBoxSearch.Visible = true;
                    buttonSearch.Visible = false;
                    buttonSearchStop.Enabled = true;
                    buttonSearchStop.Visible = true;
                }
                else if (mode == 0)
                {
                    pictureBoxReplace.Visible = true;
                    buttonReplace.Visible = false;
                    buttonReplaceStop.Enabled = true;
                    buttonReplaceStop.Visible = true;
                }
                else if (mode == 1 || mode == 2)
                {
                    pictureBoxReplace.Visible = true;
                    buttonRM.Visible = false;
                    buttonRMStop.Enabled = true;
                    buttonRMStop.Visible = true;
                }
            }
            else
            {
                if (mode != -1)
                {
                    labelUpdateAlert.Text = "为了确保数据是最新的\n请重新进行搜索";
                    labelUpdateAlert.Visible = true;
                    tabControl2.Visible = false;
                }
                buttonSearch.Enabled = true;
                if (mode == -1 || mode == 0)
                {
                    buttonReplace.Enabled = true;
                    buttonReplace.Visible = true;
                }
                if (mode == -1 || mode == 1 || mode == 2)
                {
                    buttonRM.Enabled = true;
                    buttonRM.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxRootPath.Text = "B:\\TestFolder";
            comboBoxSearch.Text = "2024*";
            comboBoxReplaceFrom.Text = "2024";
            comboBoxReplaceTo.Text = "2025";
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
                numericUpDownLimit.Value = 1000;
            }
        }

        private string preview(string oldStr)
        {
            string newStr;
            if (checkBoxCase.Checked)
            {
                newStr = oldStr.Replace(comboBoxReplaceFrom.Text, comboBoxReplaceTo.Text);
            }
            else
            {
                newStr = UIAction.ReplaceIgnoringCase(oldStr, comboBoxReplaceFrom.Text, comboBoxReplaceTo.Text);
            }
            return newStr;
        }

        private void previewAll()
        {
            foreach (DataGridViewRow row in dataFileList.Rows)
            {
                string srcName = (string)row.Cells[2].Value;
                row.Cells[3].Value = preview(srcName);
            }
        }

        private ReplaceJob[] GetRenameJob()
        {
            int rowCount = dataFileList.Rows.Count;
            List<ReplaceJob> jobs = new List<ReplaceJob> { };
            for (int i = 0; i < rowCount; i++)
            {
                string puth = UIAction.NormalizePath(dataFileList.Rows[i].Cells[1].Value.ToString());
                bool isDir = Convert.ToBoolean(dataFileList.Rows[i].Cells[4].Value);
                string fromName = dataFileList.Rows[i].Cells[2].Value.ToString();
                string toName = dataFileList.Rows[i].Cells[3].Value?.ToString();
                int id = Convert.ToInt32(dataFileList.Rows[i].Cells[6].Value);
                ReplaceJob job = new ReplaceJob(id, isDir, puth, fromName, toName);
                jobs.Add(job);
            }
            ReplaceJob[] jobsR = jobs.ToArray();
            jobsR = UIAction.SortJobsByLevel(jobsR);
            return jobsR;
        }

        private void backgroundWorkerReplace_DoWork(object sender, DoWorkEventArgs e)
        {
            // 先讀取 UI 控制元件的值，確保資料在 UI 執行緒中獲取
            ReplaceJob[] jobs = new ReplaceJob[] { };
            int sleepTime = 1;
            bool emu = false;
            this.Invoke((MethodInvoker)delegate
            {
                jobs = GetRenameJob();
                progressBar1.Minimum = 0;
                progressBar1.Maximum = jobs.Length;
                progressBar1.Value = progressBar1.Minimum;
                progressBar1.Style = ProgressBarStyle.Blocks;
                sleepTime = Convert.ToInt32(numericUpDownSleep.Value);
                emu = checkBoxDebug.Checked;
            });
            replaceEngine = new Replace
            {
                Jobs = jobs,
                SleepTime = sleepTime,
                FileAction = this.FileAction,
                Emu = emu
            };
            replaceEngine.OnFileRename = (fileItem) =>
            {
                if (backgroundWorkerReplace.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                backgroundWorkerReplace.ReportProgress(0, fileItem);
            };
            replaceEngine.ReplaceFile();
            if (backgroundWorkerReplace.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorkerReplace_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int jobID = 0;
            int nowID = 0;
            if (e.UserState is ReplaceJob job)
            {
                jobID = job.ID;
                progressBar1.Value++;
                foreach (DataGridViewRow row in dataFileList.Rows)
                {
                    nowID = Convert.ToInt32(row.Cells[6].Value);
                    if (jobID == nowID)
                    {
                        if (job.Result == "O")
                        {
                            row.Cells[5].Value = "重命名成功";
                            row.Cells[0].Value = job.IsDir ? Resources.FolderCodeAnalysis : Resources.DocumentOK;
                        }
                        else if (job.Result == "I")
                        {
                            row.Cells[5].Value = "跳过";
                            row.Cells[0].Value = job.IsDir ? Resources.FolderCodeAnalysis : Resources.DocumentOK;
                        }
                        else if (job.Result == "B")
                        {
                            row.Cells[5].Value = "放入回收站";
                            row.Cells[0].Value = job.IsDir ? Resources.DeleteFolder : Resources.DeleteDocument;
                        }
                        else if (job.Result == "R")
                        {
                            row.Cells[5].Value = "已永久删除";
                            row.Cells[0].Value = job.IsDir ? Resources.DeleteFolder : Resources.DeleteDocument;
                        }
                        else
                        {
                            row.Cells[5].Value = job.Result;
                            row.Cells[0].Value = job.IsDir ? Resources.FolderError : Resources.DocumentError;
                        }
                        return;
                    }
                }
            }
        }

        private void backgroundWorkerReplace_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            searchRunningUI(false, FileAction);
            notifyIcon1.Visible = true;
            if (e.Cancelled || replaceEngine.Status == 2)
            {
                notifyIcon1.ShowBalloonTip(3000, "操作已取消。", $"{replaceEngine.TotalOK[0].ToString()} 个成功, {replaceEngine.TotalOK[1].ToString()} 个失败， {replaceEngine.TotalOK[2].ToString()} 个跳过。", ToolTipIcon.Error);
            }
            else
            {
                notifyIcon1.ShowBalloonTip(3000, "操作完成。", $"{replaceEngine.TotalOK[0].ToString()} 个成功, {replaceEngine.TotalOK[1].ToString()} 个失败， {replaceEngine.TotalOK[2].ToString()} 个跳过。", ToolTipIcon.Info);
            }
            buttonReplace.Enabled = false;
            buttonRM.Enabled = false;
        }

        private void toolStripButtonP1rm_Click(object sender, EventArgs e)
        {
            if (dataFileList.SelectedCells.Count > 0)
            {
                HashSet<int> rowsToDelete = new HashSet<int>();
                foreach (DataGridViewCell cell in dataFileList.SelectedCells)
                {
                    rowsToDelete.Add(cell.RowIndex);
                }
                foreach (int rowIndex in rowsToDelete.OrderByDescending(x => x))
                {
                    dataFileList.Rows.RemoveAt(rowIndex);
                }
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

        private void comboBoxReplaceFrom_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                previewAll();
            }
        }

        private void comboBoxReplaceTo_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                previewAll();
            }
        }

        private void buttonReplaceExchange_Click(object sender, EventArgs e)
        {
            string tmp = comboBoxReplaceTo.Text;
            comboBoxReplaceTo.Text = comboBoxReplaceFrom.Text;
            comboBoxReplaceFrom.Text = tmp;
        }

        private void toolStripButtonAutoWidth_Click(object sender, EventArgs e)
        {
            int len = dataFileList.Rows.Count;
            if (len == 0) return;
            if (len > 1000)
            {
                DialogResult result = MessageBox.Show(
                    $"调整 {len.ToString()} 行的宽度可能需要一些时间，\n操作过程中程序可能会暂停响应，请等待。\n是否继续？",
                    "自动调整表格列宽度",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    this.UseWaitCursor = true;
                    dataFileList.Visible = false;
                    timerAutoWidth.Enabled = true;
                }
            }
            else
            {
                this.UseWaitCursor = true;
                dataFileList.Visible = false;
                timerAutoWidth.Enabled = true;
            }
        }

        private void timerAutoWidth_Tick(object sender, EventArgs e)
        {
            timerAutoWidth.Enabled = false;
            dataFileList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataFileList.Visible = true;
            this.UseWaitCursor = false;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Enabled = false;
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
            //updateListBoxItemCount();
        }

        private void buttonRM_Click(object sender, EventArgs e)
        {
            if (dataFileList.Rows.Count == 0)
            {
                MessageBox.Show("文件处理列表是空的，请先进行文件搜索。", "请先指定要操作的文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!backgroundWorkerReplace.IsBusy)
            {
                searchRunningUI(true, 0);
                if (radioButtonRm.Checked)
                {
                    FileAction = 1;
                    pictureBoxReplace.Image = Resources.FILEDEL;
                }
                else
                {
                    FileAction = 2;
                    pictureBoxReplace.Image = Resources.FILEDELR;
                }
                backgroundWorkerReplace.RunWorkerAsync();
            }
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            Form2 formMultiple = new Form2();
            formMultiple.loadData(comboBoxSearch.Text);
            if (formMultiple.ShowDialog() == DialogResult.OK)
            {
                comboBoxSearch.Text = formMultiple.Value;
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://github.com/kagurazakayashi/FileNameReplacer";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                if (MessageBox.Show($"无法打开网址 {url}\n{ex.Message}\n按[确定]将网址复制到剪贴板。", "无法打开网址", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Clipboard.SetText(url);
                }
            }
        }

        private void dataFileList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dataFileList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                bool isDir = Directory.Exists(file);
                char separator = Path.DirectorySeparatorChar;
                string[] pathUnit = file.Split(separator);
                string fileName = pathUnit.Last();
                string[] newParts = pathUnit.Take(pathUnit.Length - 1).ToArray();
                string inPath = string.Join(Path.DirectorySeparatorChar.ToString(), newParts);
                FileItem fileItem = new FileItem(isDir, inPath, fileName);
                addFileItemToList(fileItem);
            }
            searchRunningUI(false, -1);
            labelUpdateAlert.Visible = false;
            tabControl2.Visible = true;
        }

        private void dataFileList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                toolStripButtonP1rm_Click(sender, e);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] info = new string[]
            {
                "在文件系统中，* 通配符通常用于匹配文件名中的任意字符序列。例如：",
                "[*.txt] 匹配所有以 .txt 结尾的文件（如 file.txt、notes.txt）。",
                "[doc*] 匹配所有以 doc 开头的文件（如 document.docx、doc1.pdf）。",
                "[*2018*] 匹配所有名称中包含 2018 的文件（如 log-2018-05-01.log、2018-01.zip）。",
                "[*one.*] 匹配所有文件名以 one 结尾的文件（如 a1one.log、b2one.txt）。",
                "[*.*] 匹配所有带扩展名的文件名（如 file.txt、image.jpg）。",
                "[*] 匹配所有文件。"
            };
            MessageBox.Show(string.Join("\r\n", info), "通配符( * )使用说明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] info = new string[]
            {
                "前台绘制图形画面需要一些时间才能完成，没有足够时间刷新的话，将会导致程序看起来没有相应。",
                "这项设置会让后台工作等待前台绘制图形画面指定毫秒数，避免出现没有相应。",
                "建议设置区间：1-100 ，高速电脑建议值：1，低速电脑建议值：10。",
                "更小的值：可以让任务更快地完成，但是图形画面可能卡顿甚至程序在完成前停止响应。",
                "更大的值：可以更流畅地实时查看进度和文件列表，但是任务完成时间会延长。"
            };
            MessageBox.Show(string.Join("\r\n", info), "等待 UI 刷新配置说明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
