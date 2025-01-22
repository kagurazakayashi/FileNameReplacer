namespace FileNameReplacer
{
    /// <summary>
    /// 结构体：表示文件或文件夹的信息
    /// </summary>
    struct FileItem
    {
        /// <summary>
        /// 是否是文件夹（true 表示是文件夹，false 表示是文件）
        /// </summary>
        public bool isDir;

        /// <summary>
        /// 文件或文件夹所在的路径（不包含文件或文件夹名称）
        /// </summary>
        public string inPath;

        /// <summary>
        /// 文件或文件夹的名称（不包含路径）
        /// </summary>
        public string fileName;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="isDir">是否是文件夹</param>
        /// <param name="inPath">所在路径</param>
        /// <param name="fileName">名称</param>
        public FileItem(bool isDir, string inPath, string fileName)
        {
            this.isDir = isDir;
            this.inPath = inPath;
            this.fileName = fileName;
        }
    }
}
