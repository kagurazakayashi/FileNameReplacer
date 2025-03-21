﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FileNameReplacer
{
    class Search
    {
        public string rootDir = ""; // 搜尋的根目錄
        public string[] searchMode = new string[] { }; // 搜尋模式
        public bool searchSubDir = false; // 是否搜尋子目錄
        public bool searchDir = false; // 是否包含資料夾
        public bool searchFile = true; // 是否包含檔案
        public bool extName = false;
        public int SleepTime = 1;
        public decimal maxSearchLimit = 10000; // 觸發使用者提示的搜尋條數
        private bool searchCountAlert = true; // 太多了提醒我
        public int[] TotalC = new int[2] { 0, 0 };
        public int[] TotalS = new int[2] { 0, 0 };
        public Int16 Status = 0;
        private bool diglogShow = false;
        public bool run = false;

        // 回调：当找到文件或文件夹时触发
        public Action<FileItem> OnFileFound;

        // 取消搜索的检查（由 BackgroundWorker 提供）
        public Func<bool> ShouldCancel;
        public bool ShouldCancel2 = false;

        /// <summary>
        /// 开始搜索
        /// </summary>
        public void SearchFile()
        {
            if (string.IsNullOrEmpty(rootDir) || !Directory.Exists(rootDir))
            {
                return;
            }
            Status = 1;
            ShouldCancel2 = false;
            if (maxSearchLimit > 0)
            {
                searchCountAlert = true;
            }
            diglogShow = false;
            SearchDirectory(rootDir);
            if (Status == 1)
            {
                Status = 0;
            }
        }

        private void SearchDirectory(string dir)
        {
            if (ShouldCancel2 || (ShouldCancel != null && ShouldCancel()))
            {
                return;
            }
            try
            {
                if (searchFile)
                {
                    string[] files = Directory.GetFiles(dir);
                    foreach (string file in files)
                    {
                        string fileName = extName ? Path.GetFileName(file) : Path.GetFileNameWithoutExtension(file);
                        foreach (string m in searchMode)
                        {
                            TotalS[1]++;
                            if (IsMatch(fileName, m))
                            {
                                if (!run)
                                {
                                    return;
                                }
                                FileItem item = new FileItem(false, dir, Path.GetFileName(file));
                                OnFileFound?.Invoke(item);
                                Thread.Sleep(SleepTime);
                                if (CheckSearchLimitExceeded())
                                {
                                    ShouldCancel2 = true;
                                    return;
                                }
                            }
                        }
                    }
                }
                if (searchDir)
                {
                    string[] directories = Directory.GetDirectories(dir);
                    foreach (string subDir in directories)
                    {
                        string folderName = Path.GetFileName(subDir);
                        foreach (string m in searchMode)
                        {
                            TotalS[0]++;
                            if (IsMatch(folderName, m))
                            {
                                if (!run)
                                {
                                    return;
                                }
                                FileItem item = new FileItem(true, dir, folderName);
                                OnFileFound?.Invoke(item);
                                Thread.Sleep(SleepTime);
                                if (CheckSearchLimitExceeded())
                                {
                                    ShouldCancel2 = true;
                                    return;
                                }
                            }
                        }
                        if (!run)
                        {
                            return;
                        }
                        if (searchSubDir)
                        {
                            SearchDirectory(subDir);
                        }
                    }
                }
                else
                {
                    if (!run)
                    {
                        return;
                    }
                    if (searchSubDir)
                    {
                        if (CheckSearchLimitExceeded())
                        {
                            ShouldCancel2 = true;
                            return;
                        }
                        string[] directories = Directory.GetDirectories(dir);
                        foreach (string subDir in directories)
                        {
                            SearchDirectory(subDir);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(dir + " : " + ex.Message);
            }
        }

        /// <summary>
        /// 判断文件或文件夹名是否匹配搜索模式（支持通配符）
        /// </summary>
        /// <param name="name">文件或文件夹名</param>
        /// <param name="pattern">搜索模式（可以包含 *）</param>
        /// <returns>是否匹配</returns>
        /// <summary>
        /// 判断文件或文件夹名是否匹配搜索模式（支持通配符）
        /// </summary>
        /// <param name="name">文件或文件夹名</param>
        /// <param name="pattern">搜索模式（可以包含 *）</param>
        /// <returns>是否匹配</returns>
        private bool IsMatch(string name, string pattern)
        {
            if (pattern.Contains("*"))
            {
                if (pattern.StartsWith("*") && pattern.EndsWith("*"))
                {
                    // *2024* → 包含 "2024"
                    string keyword = pattern.Trim('*');
                    return name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
                }
                else if (pattern.StartsWith("*"))
                {
                    // *2024 → 以 "2024" 结尾
                    string keyword = pattern.TrimStart('*');
                    return name.EndsWith(keyword, StringComparison.OrdinalIgnoreCase);
                }
                else if (pattern.EndsWith("*"))
                {
                    // 2024* → 以 "2024" 开头
                    string keyword = pattern.TrimEnd('*');
                    return name.StartsWith(keyword, StringComparison.OrdinalIgnoreCase);
                }
            }
            else
            {
                // 精确匹配
                return name.Equals(pattern, StringComparison.OrdinalIgnoreCase);
            }

            return false;
        }

        /// <summary>
        /// 如果搜尋結果超過 10000 條，提示使用者是否繼續搜尋
        /// </summary>
        /// <returns>如果使用者選擇停止搜尋，則返回 true</returns>
        private bool CheckSearchLimitExceeded()
        {
            int max = int.MaxValue - 7;
            int totalAll = TotalC[0] + TotalC[1];
            if (totalAll >= max)
            {
                if (!diglogShow && run)
                {
                    diglogShow = true;
                    MessageBox.Show(
                        $"本程序无法处理超过 {max.ToString()} 条搜索结果！\n{TotalC[0].ToString()} 个文件夹，{TotalC[1].ToString()} 个文件。",
                        "搜索结果过多",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.ServiceNotification
                    );
                }
                Status = 2;
                return true;
            }
            decimal nextLimit = totalAll + maxSearchLimit;
            if (searchCountAlert && totalAll > 0 && (totalAll % maxSearchLimit == 0))
            {
                if (!diglogShow && run)
                {
                    diglogShow = true;
                    DialogResult result = MessageBox.Show(
                    $"搜索结果已超过 {totalAll.ToString()} 条，是否需要停止搜索？\n{TotalC[0].ToString()} 个文件夹，{TotalC[1].ToString()} 个文件。\n[是] 中止搜索\n[否] 不要停止，超过 {nextLimit.ToString()} 条再询问我\n[取消] 不要停止，本次搜索不再询问",
                    "搜索结果过多",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification
                );
                    if (result == DialogResult.Yes)
                    {
                        Status = 2;
                        return true;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        searchCountAlert = false;
                    }
                    diglogShow = false;
                }
            }
            return false;
        }
    }
}
