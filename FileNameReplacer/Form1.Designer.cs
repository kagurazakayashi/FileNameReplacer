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
            this.comboBoxReplaceFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxReplaceTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxSearchResults = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxReplacePreview = new System.Windows.Forms.ListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxRunLog = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxLimit = new System.Windows.Forms.CheckBox();
            this.buttonSearchStop = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxASub = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAFile = new System.Windows.Forms.CheckBox();
            this.checkBoxADir = new System.Windows.Forms.CheckBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChgRootPath = new System.Windows.Forms.Button();
            this.toolStripButtonP1Num = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP1rm = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP1cp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP1cls = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP2Num = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP1Num2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP2cp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP2cls = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP3cp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP3cls = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
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
            this.groupBox2.Controls.Add(this.buttonReplace);
            this.groupBox2.Controls.Add(this.buttonPreview);
            this.groupBox2.Controls.Add(this.comboBoxReplaceFrom);
            this.groupBox2.Controls.Add(this.comboBoxReplaceTo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBoxCase);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 192);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "重命名条件";
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
            // comboBoxSearch
            // 
            this.comboBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "*.*"});
            this.comboBoxSearch.Location = new System.Drawing.Point(13, 113);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(256, 27);
            this.comboBoxSearch.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxSearchResults);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "搜索结果";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxSearchResults
            // 
            this.listBoxSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSearchResults.Font = new System.Drawing.Font("Consolas", 12F);
            this.listBoxSearchResults.FormattingEnabled = true;
            this.listBoxSearchResults.ItemHeight = 19;
            this.listBoxSearchResults.Location = new System.Drawing.Point(3, 31);
            this.listBoxSearchResults.Name = "listBoxSearchResults";
            this.listBoxSearchResults.ScrollAlwaysVisible = true;
            this.listBoxSearchResults.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSearchResults.Size = new System.Drawing.Size(546, 536);
            this.listBoxSearchResults.TabIndex = 1;
            this.listBoxSearchResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxSearchResults_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonP1Num,
            this.toolStripSeparator3,
            this.toolStripButtonP1rm,
            this.toolStripSeparator1,
            this.toolStripButtonP1cp,
            this.toolStripSeparator2,
            this.toolStripButtonP1cls});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(546, 28);
            this.toolStrip1.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxReplacePreview);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "替换预览";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxReplacePreview
            // 
            this.listBoxReplacePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxReplacePreview.Font = new System.Drawing.Font("Consolas", 12F);
            this.listBoxReplacePreview.FormattingEnabled = true;
            this.listBoxReplacePreview.ItemHeight = 19;
            this.listBoxReplacePreview.Location = new System.Drawing.Point(3, 31);
            this.listBoxReplacePreview.Name = "listBoxReplacePreview";
            this.listBoxReplacePreview.ScrollAlwaysVisible = true;
            this.listBoxReplacePreview.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxReplacePreview.Size = new System.Drawing.Size(546, 536);
            this.listBoxReplacePreview.TabIndex = 3;
            this.listBoxReplacePreview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxReplacePreview_KeyDown);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonP2Num,
            this.toolStripSeparator5,
            this.toolStripButtonP1Num2,
            this.toolStripSeparator4,
            this.toolStripButtonP2cp,
            this.toolStripSeparator6,
            this.toolStripButtonP2cls});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(546, 28);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxRunLog);
            this.tabPage3.Controls.Add(this.toolStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "运行结果";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxRunLog
            // 
            this.textBoxRunLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRunLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRunLog.Location = new System.Drawing.Point(3, 31);
            this.textBoxRunLog.Multiline = true;
            this.textBoxRunLog.Name = "textBoxRunLog";
            this.textBoxRunLog.ReadOnly = true;
            this.textBoxRunLog.Size = new System.Drawing.Size(546, 536);
            this.textBoxRunLog.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonP3cp,
            this.toolStripSeparator9,
            this.toolStripButtonP3cls});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(546, 28);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 28);
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
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Image = global::FileNameReplacer.Properties.Resources.RenameEvent;
            this.buttonReplace.Location = new System.Drawing.Point(121, 138);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(148, 42);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "开始重命名(&R)";
            this.buttonReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Image = global::FileNameReplacer.Properties.Resources.Test;
            this.buttonPreview.Location = new System.Drawing.Point(13, 138);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(100, 42);
            this.buttonPreview.TabIndex = 9;
            this.buttonPreview.Text = "预览(&P)";
            this.buttonPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
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
            this.button1.Location = new System.Drawing.Point(3, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "测试(&T)";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.buttonSearchStop.Location = new System.Drawing.Point(34, 247);
            this.buttonSearchStop.Name = "buttonSearchStop";
            this.buttonSearchStop.Size = new System.Drawing.Size(235, 42);
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
            this.buttonSearch.Location = new System.Drawing.Point(13, 247);
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
            // toolStripButtonP1Num
            // 
            this.toolStripButtonP1Num.Enabled = false;
            this.toolStripButtonP1Num.Image = global::FileNameReplacer.Properties.Resources.FileDialogReport;
            this.toolStripButtonP1Num.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP1Num.Name = "toolStripButtonP1Num";
            this.toolStripButtonP1Num.Size = new System.Drawing.Size(108, 25);
            this.toolStripButtonP1Num.Text = "0 个已找到";
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
            // toolStripButtonP1cls
            // 
            this.toolStripButtonP1cls.Image = global::FileNameReplacer.Properties.Resources.CleanData;
            this.toolStripButtonP1cls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP1cls.Name = "toolStripButtonP1cls";
            this.toolStripButtonP1cls.Size = new System.Drawing.Size(62, 25);
            this.toolStripButtonP1cls.Text = "清空";
            this.toolStripButtonP1cls.Click += new System.EventHandler(this.toolStripButtonP1cls_Click);
            // 
            // toolStripButtonP2Num
            // 
            this.toolStripButtonP2Num.Enabled = false;
            this.toolStripButtonP2Num.Image = global::FileNameReplacer.Properties.Resources.FileDialogReport;
            this.toolStripButtonP2Num.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP2Num.Name = "toolStripButtonP2Num";
            this.toolStripButtonP2Num.Size = new System.Drawing.Size(92, 25);
            this.toolStripButtonP2Num.Text = "0 个结果";
            // 
            // toolStripButtonP1Num2
            // 
            this.toolStripButtonP1Num2.Enabled = false;
            this.toolStripButtonP1Num2.Image = global::FileNameReplacer.Properties.Resources.ReplaceAll;
            this.toolStripButtonP1Num2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP1Num2.Name = "toolStripButtonP1Num2";
            this.toolStripButtonP1Num2.Size = new System.Drawing.Size(92, 25);
            this.toolStripButtonP1Num2.Text = "0 个替换";
            // 
            // toolStripButtonP2cp
            // 
            this.toolStripButtonP2cp.Image = global::FileNameReplacer.Properties.Resources.Copy;
            this.toolStripButtonP2cp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP2cp.Name = "toolStripButtonP2cp";
            this.toolStripButtonP2cp.Size = new System.Drawing.Size(126, 25);
            this.toolStripButtonP2cp.Text = "复制到剪贴板";
            this.toolStripButtonP2cp.Click += new System.EventHandler(this.toolStripButtonP2cp_Click);
            // 
            // toolStripButtonP2cls
            // 
            this.toolStripButtonP2cls.Image = global::FileNameReplacer.Properties.Resources.CleanData;
            this.toolStripButtonP2cls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP2cls.Name = "toolStripButtonP2cls";
            this.toolStripButtonP2cls.Size = new System.Drawing.Size(62, 25);
            this.toolStripButtonP2cls.Text = "清空";
            this.toolStripButtonP2cls.Click += new System.EventHandler(this.toolStripButtonP2cls_Click);
            // 
            // toolStripButtonP3cp
            // 
            this.toolStripButtonP3cp.Image = global::FileNameReplacer.Properties.Resources.Copy;
            this.toolStripButtonP3cp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP3cp.Name = "toolStripButtonP3cp";
            this.toolStripButtonP3cp.Size = new System.Drawing.Size(126, 25);
            this.toolStripButtonP3cp.Text = "复制到剪贴板";
            this.toolStripButtonP3cp.Click += new System.EventHandler(this.toolStripButtonP3cp_Click);
            // 
            // toolStripButtonP3cls
            // 
            this.toolStripButtonP3cls.Image = global::FileNameReplacer.Properties.Resources.CleanData;
            this.toolStripButtonP3cls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP3cls.Name = "toolStripButtonP3cls";
            this.toolStripButtonP3cls.Size = new System.Drawing.Size(62, 25);
            this.toolStripButtonP3cls.Text = "清空";
            this.toolStripButtonP3cls.Click += new System.EventHandler(this.toolStripButtonP3cls_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripButton toolStripButtonP1rm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonP1cls;
        private System.Windows.Forms.ToolStripButton toolStripButtonP1Num;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ListBox listBoxReplacePreview;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonP2Num;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonP2cls;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButtonP3cls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonP1Num2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxRunLog;
        private System.Windows.Forms.ToolStripButton toolStripButtonP3cp;
        private System.Windows.Forms.ToolStripButton toolStripButtonP1cp;
        private System.Windows.Forms.ToolStripButton toolStripButtonP2cp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.ListBox listBoxSearchResults;
        private System.Windows.Forms.Button buttonSearchStop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
    }
}

