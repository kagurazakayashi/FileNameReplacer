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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxRootPath = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonReplaceExchange = new System.Windows.Forms.Button();
            this.comboBoxReplaceFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxReplaceTo = new System.Windows.Forms.ComboBox();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.dataFileList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReplace = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.timerAutoWidth = new System.Windows.Forms.Timer(this.components);
            this.labelTableWait = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDownSleep = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonReplaceStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.checkBoxPreview = new System.Windows.Forms.CheckBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.buttonChgRootPath = new System.Windows.Forms.Button();
            this.checkBoxLimit = new System.Windows.Forms.CheckBox();
            this.buttonSearchStop = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxASub = new System.Windows.Forms.CheckBox();
            this.checkBoxADir = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAFile = new System.Windows.Forms.CheckBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.pictureBoxReplace = new System.Windows.Forms.PictureBox();
            this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStripButtonNumDir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNumFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP1rm = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP1cp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAutoWidth = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP1cls = new System.Windows.Forms.ToolStripButton();
            this.checkBoxRealWidth = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFileList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReplace)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRootPath
            // 
            this.comboBoxRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRootPath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRootPath.FormattingEnabled = true;
            this.comboBoxRootPath.Location = new System.Drawing.Point(8, 38);
            this.comboBoxRootPath.Name = "comboBoxRootPath";
            this.comboBoxRootPath.Size = new System.Drawing.Size(257, 27);
            this.comboBoxRootPath.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxSearch);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxReplace);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataFileList);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.labelTableWait);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 661);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(5, 630);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // buttonReplaceExchange
            // 
            this.buttonReplaceExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplaceExchange.Location = new System.Drawing.Point(215, 64);
            this.buttonReplaceExchange.Name = "buttonReplaceExchange";
            this.buttonReplaceExchange.Size = new System.Drawing.Size(51, 27);
            this.buttonReplaceExchange.TabIndex = 9;
            this.buttonReplaceExchange.Text = "↑↓";
            this.buttonReplaceExchange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReplaceExchange.UseVisualStyleBackColor = true;
            this.buttonReplaceExchange.Click += new System.EventHandler(this.buttonReplaceExchange_Click);
            // 
            // comboBoxReplaceFrom
            // 
            this.comboBoxReplaceFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxReplaceFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReplaceFrom.FormattingEnabled = true;
            this.comboBoxReplaceFrom.Location = new System.Drawing.Point(7, 36);
            this.comboBoxReplaceFrom.Name = "comboBoxReplaceFrom";
            this.comboBoxReplaceFrom.Size = new System.Drawing.Size(259, 27);
            this.comboBoxReplaceFrom.TabIndex = 1;
            this.comboBoxReplaceFrom.TextChanged += new System.EventHandler(this.comboBoxReplaceFrom_TextChanged);
            // 
            // comboBoxReplaceTo
            // 
            this.comboBoxReplaceTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxReplaceTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReplaceTo.FormattingEnabled = true;
            this.comboBoxReplaceTo.Location = new System.Drawing.Point(7, 92);
            this.comboBoxReplaceTo.Name = "comboBoxReplaceTo";
            this.comboBoxReplaceTo.Size = new System.Drawing.Size(259, 27);
            this.comboBoxReplaceTo.TabIndex = 3;
            this.comboBoxReplaceTo.TextChanged += new System.EventHandler(this.comboBoxReplaceTo_TextChanged);
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Location = new System.Drawing.Point(156, 11);
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
            // comboBoxSearch
            // 
            this.comboBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "*.*",
            "*"});
            this.comboBoxSearch.Location = new System.Drawing.Point(8, 96);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(257, 27);
            this.comboBoxSearch.TabIndex = 1;
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
            this.isDir,
            this.Status,
            this.ID});
            this.dataFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFileList.Location = new System.Drawing.Point(0, 28);
            this.dataFileList.Name = "dataFileList";
            this.dataFileList.ReadOnly = true;
            this.dataFileList.RowTemplate.Height = 23;
            this.dataFileList.Size = new System.Drawing.Size(712, 629);
            this.dataFileList.TabIndex = 2;
            this.dataFileList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataFileList_RowsRemoved);
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
            this.toolStripButtonAutoWidth,
            this.toolStripSeparator4,
            this.toolStripButtonP1cls});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(193, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "测试";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // timerAutoWidth
            // 
            this.timerAutoWidth.Interval = 500;
            this.timerAutoWidth.Tick += new System.EventHandler(this.timerAutoWidth_Tick);
            // 
            // labelTableWait
            // 
            this.labelTableWait.BackColor = System.Drawing.SystemColors.Window;
            this.labelTableWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTableWait.Location = new System.Drawing.Point(0, 0);
            this.labelTableWait.Name = "labelTableWait";
            this.labelTableWait.Size = new System.Drawing.Size(712, 657);
            this.labelTableWait.TabIndex = 3;
            this.labelTableWait.Text = "请稍候";
            this.labelTableWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "文件名批量替换工具：正在工作中";
            this.notifyIcon1.BalloonTipClosed += new System.EventHandler(this.notifyIcon1_BalloonTipClosed);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // Dir
            // 
            this.Dir.HeaderText = "文件(夹)所在路径";
            this.Dir.MinimumWidth = 120;
            this.Dir.Name = "Dir";
            this.Dir.ReadOnly = true;
            this.Dir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Dir.Width = 230;
            // 
            // Source
            // 
            this.Source.HeaderText = "原文件(夹)名";
            this.Source.MinimumWidth = 100;
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Source.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Source.Width = 140;
            // 
            // NewName
            // 
            this.NewName.HeaderText = "新文件(夹)名";
            this.NewName.MinimumWidth = 100;
            this.NewName.Name = "NewName";
            this.NewName.ReadOnly = true;
            this.NewName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NewName.Width = 140;
            // 
            // isDir
            // 
            this.isDir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isDir.HeaderText = "";
            this.isDir.MinimumWidth = 2;
            this.isDir.Name = "isDir";
            this.isDir.ReadOnly = true;
            this.isDir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isDir.Visible = false;
            this.isDir.Width = 2;
            // 
            // Status
            // 
            this.Status.HeaderText = "执行结果";
            this.Status.MinimumWidth = 120;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Status.Width = 120;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "";
            this.ID.MinimumWidth = 2;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Visible = false;
            this.ID.Width = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(277, 273);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.labelFilePath);
            this.tabPage1.Controls.Add(this.buttonChgRootPath);
            this.tabPage1.Controls.Add(this.comboBoxSearch);
            this.tabPage1.Controls.Add(this.buttonSearchStop);
            this.tabPage1.Controls.Add(this.comboBoxRootPath);
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBoxASub);
            this.tabPage1.Controls.Add(this.checkBoxADir);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.checkBoxAFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(271, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文件搜索";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDownLimit);
            this.tabPage2.Controls.Add(this.checkBoxLimit);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numericUpDownSleep);
            this.tabPage2.Controls.Add(this.checkBoxRealWidth);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(269, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "高级设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(3, 278);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(277, 241);
            this.tabControl2.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonReplaceStop);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.buttonReplace);
            this.tabPage3.Controls.Add(this.checkBoxCase);
            this.tabPage3.Controls.Add(this.buttonReplaceExchange);
            this.tabPage3.Controls.Add(this.checkBoxPreview);
            this.tabPage3.Controls.Add(this.buttonPreview);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.comboBoxReplaceFrom);
            this.tabPage3.Controls.Add(this.comboBoxReplaceTo);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(269, 207);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "文件名替换";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSleep
            // 
            this.numericUpDownSleep.Location = new System.Drawing.Point(156, 46);
            this.numericUpDownSleep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSleep.Name = "numericUpDownSleep";
            this.numericUpDownSleep.Size = new System.Drawing.Size(109, 29);
            this.numericUpDownSleep.TabIndex = 14;
            this.numericUpDownSleep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSleep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::FileNameReplacer.Properties.Resources.Document;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // buttonReplaceStop
            // 
            this.buttonReplaceStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplaceStop.Enabled = false;
            this.buttonReplaceStop.Image = global::FileNameReplacer.Properties.Resources.StopOutline;
            this.buttonReplaceStop.Location = new System.Drawing.Point(113, 156);
            this.buttonReplaceStop.Name = "buttonReplaceStop";
            this.buttonReplaceStop.Size = new System.Drawing.Size(153, 42);
            this.buttonReplaceStop.TabIndex = 9;
            this.buttonReplaceStop.Text = "停止重命名(&T)";
            this.buttonReplaceStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReplaceStop.UseVisualStyleBackColor = true;
            this.buttonReplaceStop.Visible = false;
            this.buttonReplaceStop.Click += new System.EventHandler(this.buttonSearchStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::FileNameReplacer.Properties.Resources.StringRegistryValue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "　要替换的字符：";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Enabled = false;
            this.buttonReplace.Image = global::FileNameReplacer.Properties.Resources.RenameEvent;
            this.buttonReplace.Location = new System.Drawing.Point(7, 156);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(259, 42);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "开始重命名(&R)";
            this.buttonReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Image = global::FileNameReplacer.Properties.Resources.StringData;
            this.checkBoxCase.Location = new System.Drawing.Point(141, 11);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(125, 25);
            this.checkBoxCase.TabIndex = 3;
            this.checkBoxCase.Text = "区分大小写";
            this.checkBoxCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreview
            // 
            this.checkBoxPreview.AutoSize = true;
            this.checkBoxPreview.Checked = true;
            this.checkBoxPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPreview.Image = global::FileNameReplacer.Properties.Resources.StringData;
            this.checkBoxPreview.Location = new System.Drawing.Point(7, 125);
            this.checkBoxPreview.Name = "checkBoxPreview";
            this.checkBoxPreview.Size = new System.Drawing.Size(109, 25);
            this.checkBoxPreview.TabIndex = 3;
            this.checkBoxPreview.Text = "实时预览";
            this.checkBoxPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxPreview.UseVisualStyleBackColor = true;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.Image = global::FileNameReplacer.Properties.Resources.Test;
            this.buttonPreview.Location = new System.Drawing.Point(144, 123);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(122, 27);
            this.buttonPreview.TabIndex = 9;
            this.buttonPreview.Text = "预览(&P)";
            this.buttonPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::FileNameReplacer.Properties.Resources.ReplaceAll;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "　替换为：";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Image = global::FileNameReplacer.Properties.Resources.FolderOpened;
            this.labelFilePath.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelFilePath.Location = new System.Drawing.Point(6, 14);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(122, 21);
            this.labelFilePath.TabIndex = 0;
            this.labelFilePath.Text = "　起始文件夹：";
            // 
            // buttonChgRootPath
            // 
            this.buttonChgRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChgRootPath.Image = global::FileNameReplacer.Properties.Resources.OpenFolder;
            this.buttonChgRootPath.Location = new System.Drawing.Point(143, 3);
            this.buttonChgRootPath.Name = "buttonChgRootPath";
            this.buttonChgRootPath.Size = new System.Drawing.Size(122, 32);
            this.buttonChgRootPath.TabIndex = 2;
            this.buttonChgRootPath.Text = "浏览(&B)...";
            this.buttonChgRootPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChgRootPath.UseVisualStyleBackColor = true;
            this.buttonChgRootPath.Click += new System.EventHandler(this.buttonChgRootPath_Click);
            // 
            // checkBoxLimit
            // 
            this.checkBoxLimit.AutoSize = true;
            this.checkBoxLimit.Checked = true;
            this.checkBoxLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLimit.Image = global::FileNameReplacer.Properties.Resources.FullTextStopList;
            this.checkBoxLimit.Location = new System.Drawing.Point(9, 12);
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
            this.buttonSearchStop.Location = new System.Drawing.Point(113, 190);
            this.buttonSearchStop.Name = "buttonSearchStop";
            this.buttonSearchStop.Size = new System.Drawing.Size(151, 42);
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
            this.buttonSearch.Location = new System.Drawing.Point(7, 190);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(257, 42);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "开始搜索(&S)";
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::FileNameReplacer.Properties.Resources.SearchFolderClosed;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "　搜索条件(*通配符)：";
            // 
            // checkBoxASub
            // 
            this.checkBoxASub.AutoSize = true;
            this.checkBoxASub.Checked = true;
            this.checkBoxASub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxASub.Image = global::FileNameReplacer.Properties.Resources.Class;
            this.checkBoxASub.Location = new System.Drawing.Point(129, 131);
            this.checkBoxASub.Name = "checkBoxASub";
            this.checkBoxASub.Size = new System.Drawing.Size(128, 25);
            this.checkBoxASub.TabIndex = 7;
            this.checkBoxASub.Text = "子文件夹(&S)";
            this.checkBoxASub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxASub.UseVisualStyleBackColor = true;
            // 
            // checkBoxADir
            // 
            this.checkBoxADir.AutoSize = true;
            this.checkBoxADir.Checked = true;
            this.checkBoxADir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxADir.Image = global::FileNameReplacer.Properties.Resources.FolderClosed;
            this.checkBoxADir.Location = new System.Drawing.Point(8, 159);
            this.checkBoxADir.Name = "checkBoxADir";
            this.checkBoxADir.Size = new System.Drawing.Size(115, 25);
            this.checkBoxADir.TabIndex = 5;
            this.checkBoxADir.Text = "文件夹(&D)";
            this.checkBoxADir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxADir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::FileNameReplacer.Properties.Resources.TypeDefinition;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(4, 132);
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
            this.checkBoxAFile.Location = new System.Drawing.Point(129, 159);
            this.checkBoxAFile.Name = "checkBoxAFile";
            this.checkBoxAFile.Size = new System.Drawing.Size(96, 25);
            this.checkBoxAFile.TabIndex = 5;
            this.checkBoxAFile.Text = "文件(&F)";
            this.checkBoxAFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxAFile.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSearch.Image = global::FileNameReplacer.Properties.Resources.FINDCOMP;
            this.pictureBoxSearch.Location = new System.Drawing.Point(3, 581);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(274, 45);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 11;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Visible = false;
            // 
            // pictureBoxReplace
            // 
            this.pictureBoxReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxReplace.Image = global::FileNameReplacer.Properties.Resources.FILEMOVE;
            this.pictureBoxReplace.Location = new System.Drawing.Point(3, 566);
            this.pictureBoxReplace.Name = "pictureBoxReplace";
            this.pictureBoxReplace.Size = new System.Drawing.Size(274, 60);
            this.pictureBoxReplace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReplace.TabIndex = 12;
            this.pictureBoxReplace.TabStop = false;
            this.pictureBoxReplace.Visible = false;
            // 
            // ColumnIcon
            // 
            this.ColumnIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnIcon.HeaderText = "";
            this.ColumnIcon.Image = global::FileNameReplacer.Properties.Resources.Document;
            this.ColumnIcon.Name = "ColumnIcon";
            this.ColumnIcon.ReadOnly = true;
            this.ColumnIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnIcon.Width = 30;
            // 
            // toolStripButtonNumDir
            // 
            this.toolStripButtonNumDir.Image = global::FileNameReplacer.Properties.Resources.FolderClosed;
            this.toolStripButtonNumDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNumDir.Name = "toolStripButtonNumDir";
            this.toolStripButtonNumDir.Size = new System.Drawing.Size(39, 25);
            this.toolStripButtonNumDir.Text = "0";
            // 
            // toolStripButtonNumFile
            // 
            this.toolStripButtonNumFile.Image = global::FileNameReplacer.Properties.Resources.Document;
            this.toolStripButtonNumFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNumFile.Name = "toolStripButtonNumFile";
            this.toolStripButtonNumFile.Size = new System.Drawing.Size(39, 25);
            this.toolStripButtonNumFile.Text = "0";
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
            // toolStripButtonP1cp
            // 
            this.toolStripButtonP1cp.Image = global::FileNameReplacer.Properties.Resources.Copy;
            this.toolStripButtonP1cp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP1cp.Name = "toolStripButtonP1cp";
            this.toolStripButtonP1cp.Size = new System.Drawing.Size(126, 25);
            this.toolStripButtonP1cp.Text = "复制到剪贴板";
            this.toolStripButtonP1cp.Click += new System.EventHandler(this.toolStripButtonP1cp_Click);
            // 
            // toolStripButtonAutoWidth
            // 
            this.toolStripButtonAutoWidth.Image = global::FileNameReplacer.Properties.Resources.AutoSizeStretch;
            this.toolStripButtonAutoWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAutoWidth.Name = "toolStripButtonAutoWidth";
            this.toolStripButtonAutoWidth.Size = new System.Drawing.Size(126, 25);
            this.toolStripButtonAutoWidth.Text = "自动调整列宽";
            this.toolStripButtonAutoWidth.Click += new System.EventHandler(this.toolStripButtonAutoWidth_Click);
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
            // checkBoxRealWidth
            // 
            this.checkBoxRealWidth.AutoSize = true;
            this.checkBoxRealWidth.Image = global::FileNameReplacer.Properties.Resources.AutoSizeStretch;
            this.checkBoxRealWidth.Location = new System.Drawing.Point(9, 81);
            this.checkBoxRealWidth.Name = "checkBoxRealWidth";
            this.checkBoxRealWidth.Size = new System.Drawing.Size(189, 25);
            this.checkBoxRealWidth.TabIndex = 13;
            this.checkBoxRealWidth.Text = "实时调整列宽（慢）";
            this.checkBoxRealWidth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxRealWidth.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::FileNameReplacer.Properties.Resources.Timer;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(7, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "　线程等待：";
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 1000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 661);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "文件名批量替换工具 v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFileList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReplace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.ComboBox comboBoxRootPath;
        private System.Windows.Forms.Button buttonChgRootPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBoxReplaceFrom;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.CheckBox checkBoxPreview;
        private System.Windows.Forms.Button buttonReplaceStop;
        private System.Windows.Forms.Button buttonReplaceExchange;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxReplace;
        private System.Windows.Forms.ToolStripButton toolStripButtonAutoWidth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Timer timerAutoWidth;
        private System.Windows.Forms.Label labelTableWait;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numericUpDownSleep;
        private System.Windows.Forms.CheckBox checkBoxRealWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerLoad;
    }
}

