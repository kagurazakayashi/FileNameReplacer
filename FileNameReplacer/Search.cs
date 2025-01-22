using System;
using System.Collections.Generic;
using System.IO;

namespace FileNameReplacer
{
    class Search
    {
        public string rootDir = ""; // 要搜尋的根目錄
        public string searchMode = ""; // 要搜尋的內容(萬用字元,例如 *.jpg )
        public bool searchSubDir = false; // 是否搜尋子資料夾
        public bool searchDir = false; // 是否將資料夾列入搜尋結果
        public bool searchFile = false; // 是否將檔案列入搜尋結果
        /// <summary>
        /// 根據當前設定的引數搜尋檔案或資料夾
        /// </summary>
        /// <returns>搜尋到的檔案或資料夾列表</returns>
        public List<FileItem> SearchFile()
        {
            // 儲存搜尋結果的列表
            List<FileItem> results = new List<FileItem>();

            // 如果根目錄為空或不存在，則返回空列表
            if (string.IsNullOrEmpty(rootDir) || !Directory.Exists(rootDir))
            {
                return results;
            }

            // 遞迴搜尋目錄
            SearchDirectory(rootDir, results);
            return results;
        }

        /// <summary>
        /// 遞迴搜尋指定目錄
        /// </summary>
        /// <param name="dir">當前搜尋的目錄</param>
        /// <param name="results">儲存搜尋結果的列表</param>
        private void SearchDirectory(string dir, List<FileItem> results)
        {
            try
            {
                // 確保目錄存在
                if (!Directory.Exists(dir))
                {
                    return; // 目錄不存在，直接返回
                }

                // 搜尋檔案（確保 searchFile 為 true）
                if (searchFile)
                {
                    try
                    {
                        string[] files = Directory.GetFiles(dir, searchMode);
                        foreach (string file in files)
                        {
                            results.Add(new FileItem(false, dir, Path.GetFileName(file)));
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // 忽略無許可權的資料夾
                    }
                    catch (DirectoryNotFoundException)
                    {
                        // 忽略已被刪除或無效的目錄
                    }
                }

                // 搜尋子目錄
                string[] directories;
                try
                {
                    directories = Directory.GetDirectories(dir);
                }
                catch (UnauthorizedAccessException)
                {
                    return; // 無許可權訪問，直接返回
                }
                catch (DirectoryNotFoundException)
                {
                    return; // 目錄在搜尋過程中被刪除，直接返回
                }

                foreach (string subDir in directories)
                {
                    // 如果 searchDir 為 true，則將資料夾加入結果
                    if (searchDir)
                    {
                        results.Add(new FileItem(true, dir, Path.GetFileName(subDir)));
                    }

                    // 遞迴搜尋子目錄
                    if (searchSubDir)
                    {
                        SearchDirectory(subDir, results);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{dir} E: {ex.Message}");
            }
        }
    }
}
