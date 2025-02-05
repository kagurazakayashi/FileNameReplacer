using System.IO;

namespace FileNameReplacer
{
    /// <summary>
    /// 表示一個檔名替換任務的結構體。
    /// </summary>
    public struct ReplaceJob
    {
        /// <summary>
        /// 指示任務是否針對目錄。
        /// </summary>
        public bool IsDir;

        /// <summary>
        /// 輸入路徑，表示檔案或目錄所在的路徑。
        /// </summary>
        public string InPath;

        /// <summary>
        /// 需要替換的原始名稱。
        /// </summary>
        public string FromName;

        /// <summary>
        /// 替換後的目標名稱。
        /// </summary>
        public string ToName;

        /// <summary>
        /// 輸入路徑的層級深度。
        /// </summary>
        public int PathLevel;

        /// <summary>
        /// 初始化一個新的 <see cref="ReplaceJob"/> 例項。
        /// </summary>
        /// <param name="isDir">指示任務是否針對目錄。</param>
        /// <param name="inPath">輸入路徑，表示檔案或目錄所在的路徑。</param>
        /// <param name="fromName">需要替換的原始名稱。</param>
        /// <param name="toName">替換後的目標名稱。</param>
        public ReplaceJob(bool isDir, string inPath, string fromName, string toName)
        {
            IsDir = isDir;
            InPath = UIAction.NormalizePath(inPath); // 規範化路徑
            FromName = fromName;
            ToName = toName;
            string[] pathParts = InPath.Split(Path.DirectorySeparatorChar); // 分割路徑以計算層級
            PathLevel = pathParts.Length;
        }

        /// <summary>
        /// 獲取原始檔案或目錄的完整路徑。
        /// </summary>
        /// <returns>原始檔案或目錄的完整路徑。</returns>
        public string FromFullPath()
        {
            return InPath + Path.DirectorySeparatorChar + FromName;
        }

        /// <summary>
        /// 獲取目標檔案或目錄的完整路徑。
        /// </summary>
        /// <returns>目標檔案或目錄的完整路徑。</returns>
        public string ToFullPath()
        {
            return InPath + Path.DirectorySeparatorChar + ToName;
        }

        /// <summary>
        /// 返回表示當前 <see cref="ReplaceJob"/> 的字串(JSON)。
        /// </summary>
        /// <returns>表示當前 <see cref="ReplaceJob"/> 的字串(JSON)。</returns>
        public override string ToString()
        {
            string[] echo = new string[5]
            {
                "\"IsDir\":" + IsDir.ToString().ToLower(),
                "\"InPath\":\"" + InPath + "\"",
                "\"FromName\":\"" + FromName + "\"",
                "\"ToName\":\"" + ToName + "\"",
                "\"PathLevel\":" + PathLevel.ToString(),
            };
            return "{" + string.Join(",", echo) + "}";
        }
    }
}