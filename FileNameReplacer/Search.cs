using System;
using System.Collections.Generic;
using System.IO;

namespace FileNameReplacer
{
    class Search
    {
        public string rootDir = ""; // 搜尋的根目錄
        public string searchMode = "*"; // 搜尋模式 (預設所有檔案)
        public bool searchSubDir = false; // 是否搜尋子目錄
        public bool searchDir = false; // 是否包含資料夾
        public bool searchFile = true; // 是否包含檔案

        // 定義回撥委託，通知外部介面更新 ListBox
        public Action<FileItem> OnFileFound;

        /// <summary>
        /// 開始搜尋檔案，並透過 OnFileFound 實時通知 UI
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
            try
            {
                // 搜尋檔案
                if (searchFile)
                {
                    try
                    {
                        string[] files = Directory.GetFiles(dir, searchMode);
                        foreach (string file in files)
                        {
                            FileItem item = new FileItem(false, dir, Path.GetFileName(file));
                            OnFileFound?.Invoke(item); // 觸發回撥，通知 UI
                        }
                    }
                    catch (UnauthorizedAccessException) { }
                    catch (DirectoryNotFoundException) { }
                }

                // 搜尋子目錄
                string[] directories;
                try
                {
                    directories = Directory.GetDirectories(dir);
                }
                catch (UnauthorizedAccessException)
                {
                    return;
                }
                catch (DirectoryNotFoundException)
                {
                    return;
                }

                foreach (string subDir in directories)
                {
                    if (searchDir)
                    {
                        FileItem item = new FileItem(true, dir, Path.GetFileName(subDir));
                        OnFileFound?.Invoke(item); // 觸發回撥
                    }

                    if (searchSubDir)
                    {
                        SearchDirectory(subDir); // 遞迴搜尋
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"搜尋目錄 {dir} 時發生錯誤: {ex.Message}");
            }
        }
    }
}
