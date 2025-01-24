using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileNameReplacer
{
    class Search
    {
        public string rootDir = ""; // 搜索的根目录
        public string searchMode = "*"; // 搜索模式
        public bool searchSubDir = false; // 是否搜索子目录
        public bool searchDir = false; // 是否包含文件夹
        public bool searchFile = true; // 是否包含文件

        // 回调：当找到文件或文件夹时触发
        public Action<FileItem> OnFileFound;

        // 取消搜索的检查（由 BackgroundWorker 提供）
        public Func<bool> ShouldCancel;

        /// <summary>
        /// 开始搜索
        /// </summary>
        public void SearchFile()
        {
            if (string.IsNullOrEmpty(rootDir) || !Directory.Exists(rootDir))
            {
                return;
            }

            SearchDirectory(rootDir);
        }

        private void SearchDirectory(string dir)
        {
            // 先檢查是否請求取消
            if (ShouldCancel != null && ShouldCancel())
            {
                return;
            }

            try
            {
                // 先處理檔案（獨立於 searchDir）
                if (searchFile)
                {
                    string[] files = Directory.GetFiles(dir);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file); // 只獲取檔名，不帶副檔名

                        // 支援萬用字元匹配
                        if (IsMatch(fileName, searchMode))
                        {
                            FileItem item = new FileItem(false, dir, Path.GetFileName(file));
                            OnFileFound?.Invoke(item);
                        }
                    }
                }

                // 再處理資料夾
                if (searchDir)
                {
                    string[] directories = Directory.GetDirectories(dir);
                    foreach (string subDir in directories)
                    {
                        string folderName = Path.GetFileName(subDir);

                        // 支援萬用字元匹配
                        if (IsMatch(folderName, searchMode))
                        {
                            FileItem item = new FileItem(true, dir, folderName);
                            OnFileFound?.Invoke(item);
                        }

                        // 遞迴子目錄（無論 searchDir 是 true 還是 false）
                        if (searchSubDir)
                        {
                            SearchDirectory(subDir);
                        }
                    }
                }
                else
                {
                    // 即使 searchDir 為 false，仍然繼續遞迴搜尋子目錄，以便查詢檔案
                    if (searchSubDir)
                    {
                        string[] directories = Directory.GetDirectories(dir);
                        foreach (string subDir in directories)
                        {
                            SearchDirectory(subDir);
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException) { }
            catch (DirectoryNotFoundException) { }
            catch (Exception ex)
            {
                Console.WriteLine($"搜尋目錄 {dir} 時發生錯誤: {ex.Message}");
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

    }
}
