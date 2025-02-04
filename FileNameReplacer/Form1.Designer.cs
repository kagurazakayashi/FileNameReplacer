namespace FileNameReplacer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxRootPath = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonReplaceStop = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.comboBoxReplaceFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxReplaceTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPreview = new System.Windows.Forms.CheckBox();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxLimit = new System.Windows.Forms.CheckBox();
            this.buttonSearchStop = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxASub = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAFile = new System.Windows.Forms.CheckBox();
            this.checkBoxADir = new System.Windows.Forms.CheckBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonChgRootPath = new System.Windows.Forms.Button();
            this.dataFileList = new System.Windows.Forms.DataGridView();
            this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.Dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNumDir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNumFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonP1rm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonP1cp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonP1cls = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReplace = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonReplaceExchange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFileList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRootPath
            // 
            this.comboBoxRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRootPath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRootPath.FormattingEnabled = true;
            this.comboBoxRootPath.Location = new System.Drawing.Point(13, 55);
            this.comboBoxRootPath.Name = "comboBoxRootPath";
            this.comboBoxRootPath.Size = new System.Drawing.Size(256, 27);
            this.comboBoxRootPath.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataFileList);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(849, 606);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(5, 577);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(273, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonReplaceStop);
            this.groupBox2.Controls.Add(this.buttonReplace);
            this.groupBox2.Controls.Add(this.buttonReplaceExchange);
            this.groupBox2.Controls.Add(this.buttonPreview);
            this.groupBox2.Controls.Add(this.comboBoxReplaceFrom);
            this.groupBox2.Controls.Add(this.comboBoxReplaceTo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBoxPreview);
            this.groupBox2.Controls.Add(this.checkBoxCase);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 223);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "重命名条件";
            // 
            // buttonReplaceStop
            // 
            this.buttonReplaceStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplaceStop.Enabled = false;
            this.buttonReplaceStop.Image = global::FileNameReplacer.Properties.Resources.StopOutline;
            this.buttonReplaceStop.Location = new System.Drawing.Point(119, 169);
            this.buttonReplaceStop.Name = "buttonReplaceStop";
            this.buttonReplaceStop.Size = new System.Drawing.Size(150, 42);
            this.buttonReplaceStop.TabIndex = 9;
            this.buttonReplaceStop.Text = "停止重命名(&T)";
            this.buttonReplaceStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReplaceStop.UseVisualStyleBackColor = true;
            this.buttonReplaceStop.Visible = false;
            this.buttonReplaceStop.Click += new System.EventHandler(this.buttonSearchStop_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Image = global::FileNameReplacer.Properties.Resources.RenameEvent;
            this.buttonReplace.Location = new System.Drawing.Point(13, 169);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(256, 42);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "开始重命名(&R)";
            this.buttonReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.Image = global::FileNameReplacer.Properties.Resources.Test;
            this.buttonPreview.Location = new System.Drawing.Point(147, 136);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(122, 27);
            this.buttonPreview.TabIndex = 9;
            this.buttonPreview.Text = "预览(&P)";
            this.buttonPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // comboBoxReplaceFrom
            // 
            this.comboBoxReplaceFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxReplaceFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReplaceFrom.FormattingEnabled = true;
            this.comboBoxReplaceFrom.Location = new System.Drawing.Point(13, 49);
            this.comboBoxReplaceFrom.Name = "comboBoxReplaceFrom";
            this.comboBoxReplaceFrom.Size = new System.Drawing.Size(256, 27);
            this.comboBoxReplaceFrom.TabIndex = 1;
            this.comboBoxReplaceFrom.TextChanged += new System.EventHandler(this.comboBoxReplaceFrom_TextChanged);
            // 
            // comboBoxReplaceTo
            // 
            this.comboBoxReplaceTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxReplaceTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReplaceTo.FormattingEnabled = true;
            this.comboBoxReplaceTo.Location = new System.Drawing.Point(13, 105);
            this.comboBoxReplaceTo.Name = "comboBoxReplaceTo";
            this.comboBoxReplaceTo.Size = new System.Drawing.Size(256, 27);
            this.comboBoxReplaceTo.TabIndex = 3;
            this.comboBoxReplaceTo.TextChanged += new System.EventHandler(this.comboBoxReplaceTo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::FileNameReplacer.Properties.Resources.ReplaceAll;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "　替换为：";
            // 
            // checkBoxPreview
            // 
            this.checkBoxPreview.AutoSize = true;
            this.checkBoxPreview.Checked = true;
            this.checkBoxPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPreview.Image = global::FileNameReplacer.Properties.Resources.StringData;
            this.checkBoxPreview.Location = new System.Drawing.Point(13, 138);
            this.checkBoxPreview.Name = "checkBoxPreview";
            this.checkBoxPreview.Size = new System.Drawing.Size(109, 25);
            this.checkBoxPreview.TabIndex = 3;
            this.checkBoxPreview.Text = "实时预览";
            this.checkBoxPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxPreview.UseVisualStyleBackColor = true;
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Image = global::FileNameReplacer.Properties.Resources.StringData;
            this.checkBoxCase.Location = new System.Drawing.Point(144, 24);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(125, 25);
            this.checkBoxCase.TabIndex = 3;
            this.checkBoxCase.Text = "区分大小写";
            this.checkBoxCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::FileNameReplacer.Properties.Resources.StringRegistryValue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "　要替换的字符：";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Image = global::FileNameReplacer.Properties.Resources.Test;
            this.button1.Location = new System.Drawing.Point(5, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "测试(&T)";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numericUpDownLimit);
            this.groupBox1.Controls.Add(this.checkBoxLimit);
            this.groupBox1.Controls.Add(this.buttonSearchStop);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.checkBoxASub);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxAFile);
            this.groupBox1.Controls.Add(this.checkBoxADir);
            this.groupBox1.Controls.Add(this.labelFilePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxRootPath);
            this.groupBox1.Controls.Add(this.comboBoxSearch);
            this.groupBox1.Controls.Add(this.buttonChgRootPath);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件搜索";
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Location = new System.Drawing.Point(160, 206);
            this.numericUpDownLimit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.Size = new System.Drawing.Size(109, 29);
            this.numericUpDownLimit.TabIndex = 12;
            this.numericUpDownLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownLimit.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // checkBoxLimit
            // 
            this.checkBoxLimit.AutoSize = true;
            this.checkBoxLimit.Checked = true;
            this.checkBoxLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLimit.Image = global::FileNameReplacer.Properties.Resources.FullTextStopList;
            this.checkBoxLimit.Location = new System.Drawing.Point(13, 207);
            this.checkBoxLimit.Name = "checkBoxLimit";
            this.checkBoxLimit.Size = new System.Drawing.Size(125, 25);
            this.checkBoxLimit.TabIndex = 11;
            this.checkBoxLimit.Text = "结果限量：";
            this.checkBoxLimit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxLimit.UseVisualStyleBackColor = true;
            this.checkBoxLimit.CheckedChanged += new System.EventHandler(this.checkBoxLimit_CheckedChanged);
            // 
            // buttonSearchStop
            // 
            this.buttonSearchStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchStop.Enabled = false;
            this.buttonSearchStop.Image = global::FileNameReplacer.Properties.Resources.StopOutline;
            this.buttonSearchStop.Location = new System.Drawing.Point(119, 241);
            this.buttonSearchStop.Name = "buttonSearchStop";
            this.buttonSearchStop.Size = new System.Drawing.Size(150, 42);
            this.buttonSearchStop.TabIndex = 9;
            this.buttonSearchStop.Text = "停止搜索(&Q)";
            this.buttonSearchStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchStop.UseVisualStyleBackColor = true;
            this.buttonSearchStop.Visible = false;
            this.buttonSearchStop.Click += new System.EventHandler(this.buttonSearchStop_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::FileNameReplacer.Properties.Resources.SearchFolderOpened;
            this.buttonSearch.Location = new System.Drawing.Point(13, 241);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(256, 42);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "开始搜索(&S)";
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxASub
            // 
            this.checkBoxASub.AutoSize = true;
            this.checkBoxASub.Checked = true;
            this.checkBoxASub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxASub.Image = global::FileNameReplacer.Properties.Resources.Class;
            this.checkBoxASub.Location = new System.Drawing.Point(134, 148);
            this.checkBoxASub.Name = "checkBoxASub";
            this.checkBoxASub.Size = new System.Drawing.Size(128, 25);
            this.checkBoxASub.TabIndex = 7;
            this.checkBoxASub.Text = "子文件夹(&S)";
            this.checkBoxASub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxASub.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::FileNameReplacer.Properties.Resources.TypeDefinition;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "　搜索内容：";
            // 
            // checkBoxAFile
            // 
            this.checkBoxAFile.AutoSize = true;
            this.checkBoxAFile.Checked = true;
            this.checkBoxAFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAFile.Image = global::FileNameReplacer.Properties.Resources.FileSystemEditor;
            this.checkBoxAFile.Location = new System.Drawing.Point(134, 176);
            this.checkBoxAFile.Name = "checkBoxAFile";
            this.checkBoxAFile.Size = new System.Drawing.Size(96, 25);
            this.checkBoxAFile.TabIndex = 5;
            this.checkBoxAFile.Text = "文件(&F)";
            this.checkBoxAFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxAFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxADir
            // 
            this.checkBoxADir.AutoSize = true;
            this.checkBoxADir.Checked = true;
            this.checkBoxADir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxADir.Image = global::FileNameReplacer.Properties.Resources.FolderClosed;
            this.checkBoxADir.Location = new System.Drawing.Point(13, 176);
            this.checkBoxADir.Name = "checkBoxADir";
            this.checkBoxADir.Size = new System.Drawing.Size(115, 25);
            this.checkBoxADir.TabIndex = 5;
            this.checkBoxADir.Text = "文件夹(&D)";
            this.checkBoxADir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxADir.UseVisualStyleBackColor = true;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Image = global::FileNameReplacer.Properties.Resources.FolderOpened;
            this.labelFilePath.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelFilePath.Location = new System.Drawing.Point(9, 31);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(122, 21);
            this.labelFilePath.TabIndex = 0;
            this.labelFilePath.Text = "　起始文件夹：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::FileNameReplacer.Properties.Resources.SearchFolderClosed;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "　搜索条件(*通配符)：";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "*.*",
            "*"});
            this.comboBoxSearch.Location = new System.Drawing.Point(13, 113);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(256, 27);
            this.comboBoxSearch.TabIndex = 1;
            // 
            // buttonChgRootPath
            // 
            this.buttonChgRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChgRootPath.Image = global::FileNameReplacer.Properties.Resources.OpenFolder;
            this.buttonChgRootPath.Location = new System.Drawing.Point(147, 25);
            this.buttonChgRootPath.Name = "buttonChgRootPath";
            this.buttonChgRootPath.Size = new System.Drawing.Size(122, 27);
            this.buttonChgRootPath.TabIndex = 2;
            this.buttonChgRootPath.Text = "浏览(&B)...";
            this.buttonChgRootPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChgRootPath.UseVisualStyleBackColor = true;
            this.buttonChgRootPath.Click += new System.EventHandler(this.buttonChgRootPath_Click);
            // 
            // dataFileList
            // 
            this.dataFileList.AllowUserToAddRows = false;
            this.dataFileList.AllowUserToResizeRows = false;
            this.dataFileList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataFileList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIcon,
            this.Dir,
            this.Source,
            this.NewName,
            this.isDir});
            this.dataFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFileList.Location = new System.Drawing.Point(0, 28);
            this.dataFileList.Name = "dataFileList";
            this.dataFileList.ReadOnly = true;
            this.dataFileList.RowTemplate.Height = 23;
            this.dataFileList.Size = new System.Drawing.Size(560, 576);
            this.dataFileList.TabIndex = 2;
            this.dataFileList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataFileList_RowsRemoved);
            // 
            // ColumnIcon
            // 
            this.ColumnIcon.HeaderText = "";
            this.ColumnIcon.Image = global::FileNameReplacer.Properties.Resources.Document;
            this.ColumnIcon.Name = "ColumnIcon";
            this.ColumnIcon.ReadOnly = true;
            this.ColumnIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnIcon.Width = 30;
            // 
            // Dir
            // 
            this.Dir.HeaderText = "文件(夹)所在路径";
            this.Dir.MinimumWidth = 200;
            this.Dir.Name = "Dir";
            this.Dir.ReadOnly = true;
            this.Dir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Dir.Width = 200;
            // 
            // Source
            // 
            this.Source.HeaderText = "原文件(夹)名";
            this.Source.MinimumWidth = 130;
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Source.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Source.Width = 130;
            // 
            // NewName
            // 
            this.NewName.HeaderText = "新文件(夹)名";
            this.NewName.MinimumWidth = 130;
            this.NewName.Name = "NewName";
            this.NewName.ReadOnly = true;
            this.NewName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NewName.Width = 130;
            // 
            // isDir
            // 
            this.isDir.HeaderText = "";
            this.isDir.MinimumWidth = 2;
            this.isDir.Name = "isDir";
            this.isDir.ReadOnly = true;
            this.isDir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isDir.Visible = false;
            this.isDir.Width = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNumDir,
            this.toolStripButtonNumFile,
            this.toolStripSeparator3,
            this.toolStripButtonP1rm,
            this.toolStripSeparator1,
            this.toolStripButtonP1cp,
            this.toolStripSeparator2,
            this.toolStripButtonP1cls});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(560, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNumDir
            // 
            this.toolStripButtonNumDir.Enabled = false;
            this.toolStripButtonNumDir.Image = global::FileNameReplacer.Properties.Resources.FolderClosed;
            this.toolStripButtonNumDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNumDir.Name = "toolStripButtonNumDir";
            this.toolStripButtonNumDir.Size = new System.Drawing.Size(39, 25);
            this.toolStripButtonNumDir.Text = "0";
            // 
            // toolStripButtonNumFile
            // 
            this.toolStripButtonNumFile.Enabled = false;
            this.toolStripButtonNumFile.Image = global::FileNameReplacer.Properties.Resources.Document;
            this.toolStripButtonNumFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNumFile.Name = "toolStripButtonNumFile";
            this.toolStripButtonNumFile.Size = new System.Drawing.Size(39, 25);
            this.toolStripButtonNumFile.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonP1rm
            // 
            this.toolStripButtonP1rm.Image = global::FileNameReplacer.Properties.Resources.DeleteDocument;
            this.toolStripButtonP1rm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP1rm.Name = "toolStripButtonP1rm";
            this.toolStripButtonP1rm.Size = new System.Drawing.Size(184, 25);
            this.toolStripButtonP1rm.Text = "移除选定项(不要处理)";
            this.toolStripButtonP1rm.Click += new System.EventHandler(this.toolStripButtonP1rm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonP1cp
            // 
            this.toolStripButtonP1cp.Image = global::FileNameReplacer.Properties.Resources.Copy;
            this.toolStripButtonP1cp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP1cp.Name = "toolStripButtonP1cp";
            this.toolStripButtonP1cp.Size = new System.Drawing.Size(126, 25);
            this.toolStripButtonP1cp.Text = "复制到剪贴板";
            this.toolStripButtonP1cp.Click += new System.EventHandler(this.toolStripButtonP1cp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonP1cls
            // 
            this.toolStripButtonP1cls.Image = global::FileNameReplacer.Properties.Resources.CleanData;
            this.toolStripButtonP1cls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP1cls.Name = "toolStripButtonP1cls";
            this.toolStripButtonP1cls.Size = new System.Drawing.Size(62, 25);
            this.toolStripButtonP1cls.Text = "清空";
            this.toolStripButtonP1cls.Click += new System.EventHandler(this.toolStripButtonP1cls_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "选择要查找文件(夹)的根目录";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.WorkerReportsProgress = true;
            this.backgroundWorkerSearch.WorkerSupportsCancellation = true;
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
            this.backgroundWorkerSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSearch_ProgressChanged);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
            // 
            // backgroundWorkerReplace
            // 
            this.backgroundWorkerReplace.WorkerReportsProgress = true;
            this.backgroundWorkerReplace.WorkerSupportsCancellation = true;
            this.backgroundWorkerReplace.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReplace_DoWork);
            this.backgroundWorkerReplace.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerReplace_ProgressChanged);
            this.backgroundWorkerReplace.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReplace_RunWorkerCompleted);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::FileNameReplacer.Properties.Resources.Document;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // buttonReplaceExchange
            // 
            this.buttonReplaceExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplaceExchange.Location = new System.Drawing.Point(218, 77);
            this.buttonReplaceExchange.Name = "buttonReplaceExchange";
            this.buttonReplaceExchange.Size = new System.Drawing.Size(51, 27);
            this.buttonReplaceExchange.TabIndex = 9;
            this.buttonReplaceExchange.Text = "↑↓";
            this.buttonReplaceExchange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReplaceExchange.UseVisualStyleBackColor = true;
            this.buttonReplaceExchange.Click += new System.EventHandler(this.buttonReplaceExchange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 606);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "文件名批量替换工具 v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFileList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.ComboBox comboBoxRootPath;
        private System.Windows.Forms.Button buttonChgRootPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxReplaceFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.ComboBox comboBoxReplaceTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxADir;
        private System.Windows.Forms.CheckBox checkBoxASub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAFile;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.Button buttonSearchStop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReplace;
        private System.Windows.Forms.DataGridView dataFileList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNumDir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonP1rm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonP1cp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonP1cls;
        private System.Windows.Forms.ToolStripButton toolStripButtonNumFile;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDir;
        private System.Windows.Forms.CheckBox checkBoxPreview;
        private System.Windows.Forms.Button buttonReplaceStop;
        private System.Windows.Forms.Button buttonReplaceExchange;
    }
}

