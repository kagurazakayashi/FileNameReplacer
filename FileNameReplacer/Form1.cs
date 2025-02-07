using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileNameReplacer
{
    public partial class Form1: Form
    {
        private Search searchEngine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSearchStop.Location = buttonSearch.Location;
            buttonReplaceStop.Location = buttonReplace.Location;
            buttonSearchStop.Size = buttonSearch.Size;
            buttonReplaceStop.Size = buttonReplace.Size;
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
            if (searchEngine != null)
            {
                searchEngine.TotalC[0] = dir;
                searchEngine.TotalC[1] = file;
            }
            toolStripButtonNumDir.Text = dir.ToString();
            toolStripButtonNumFile.Text = file.ToString();
            //string[] texts = toolStripButtonNumDir.Text.Split(' ');
            //texts[0] = dataFileList.Rows.Count.ToString();
            //toolStripButtonNumDir.Text = string.Join(" ", texts);
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (UIAction.ChkComboBoxIsEmpty(comboBoxReplaceFrom)) return;
            previewAll();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (UIAction.ChkComboBoxIsEmpty(comboBoxReplaceFrom)) return;
            previewAll();
            backgroundWorkerReplace.RunWorkerAsync();
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
                dataFileList.Rows[dataLen].Cells[1].Value = UIAction.NormalizePath(fileItem.inPath);
                dataFileList.Rows[dataLen].Cells[2].Value = fileItem.fileName;
                dataFileList.Rows[dataLen].Cells[4].Value = fileItem.isDir;
                dataFileList.Rows[dataLen].Cells[6].Value = dataLen.ToString();
                if (fileItem.isDir)
                {
                    dataFileList.Rows[dataLen].Cells[0].Value = Properties.Resources.FolderClosed;
                    int num = int.Parse(toolStripButtonNumDir.Text) + 1;
                    toolStripButtonNumDir.Text = num.ToString();
                    searchEngine.TotalC[0] = num;
                }
                else
                {
                    int num = int.Parse(toolStripButtonNumDir.Text) + 1;
                    toolStripButtonNumFile.Text = num.ToString();
                    searchEngine.TotalC[1] = num;
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
            this.Cursor = isRun ? Cursors.AppStarting : Cursors.Default;
            dataFileList.Cursor = this.Cursor;
            buttonSearch.Visible = !isRun;
            buttonSearchStop.Visible = isRun;
            pictureBoxSearch.Visible = isRun;
            buttonSearchStop.Enabled = isRun;
            progressBar1.Value = progressBar1.Maximum;
            progressBar1.Style = isRun ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
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
                numericUpDownLimit.Value = 10000;
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
                string fromName = UIAction.NormalizePath(puth + Path.DirectorySeparatorChar + dataFileList.Rows[i].Cells[2].Value.ToString());
                string toName = UIAction.NormalizePath(puth + Path.DirectorySeparatorChar + dataFileList.Rows[i].Cells[3].Value.ToString());
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
            this.Invoke((MethodInvoker)delegate
            {
                jobs = GetRenameJob();
            });
            foreach (ReplaceJob job in jobs)
            {
                Console.WriteLine(job.ToString());
            }
        }

        private void backgroundWorkerReplace_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorkerReplace_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void toolStripButtonP1rm_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataFileList.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataFileList.Rows.Remove(row);
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
    }
}
