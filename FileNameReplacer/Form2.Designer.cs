namespace FileNameReplacer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerToolTipHide = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(453, 382);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(11, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 29);
            this.textBox1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::FileNameReplacer.Properties.Resources.Cancel;
            this.button4.Location = new System.Drawing.Point(318, 497);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 37);
            this.button4.TabIndex = 1;
            this.button4.Text = "取消(&C)";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::FileNameReplacer.Properties.Resources.CheckedOutForEdit;
            this.button3.Location = new System.Drawing.Point(164, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "确定(&O)";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = global::FileNameReplacer.Properties.Resources.CleanData;
            this.button5.Location = new System.Drawing.Point(12, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 37);
            this.button5.TabIndex = 1;
            this.button5.Text = "清空(&E)";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.Image = global::FileNameReplacer.Properties.Resources.Remove;
            this.button2.Location = new System.Drawing.Point(318, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "删除(&D)";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::FileNameReplacer.Properties.Resources.Add;
            this.button1.Location = new System.Drawing.Point(164, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加(&A)";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = global::FileNameReplacer.Properties.Resources.Input_16x;
            this.button6.Location = new System.Drawing.Point(164, 454);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 37);
            this.button6.TabIndex = 1;
            this.button6.Text = "导入(&I)";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Image = global::FileNameReplacer.Properties.Resources.Output_16x;
            this.button7.Location = new System.Drawing.Point(318, 454);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 37);
            this.button7.TabIndex = 1;
            this.button7.Text = "导出(&O)";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "搜索关键词规则列表.txt";
            this.openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "打开已有方案";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "搜索关键词规则列表.txt";
            this.saveFileDialog1.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            this.saveFileDialog1.Title = "将方案保存到";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // timerToolTipHide
            // 
            this.timerToolTipHide.Interval = 3000;
            this.timerToolTipHide.Tick += new System.EventHandler(this.timerToolTipHide_Tick);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Image = global::FileNameReplacer.Properties.Resources.HelpApplication_16x;
            this.button8.Location = new System.Drawing.Point(12, 497);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 37);
            this.button8.TabIndex = 1;
            this.button8.Text = "帮助(&H)";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 549);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "指定多个搜索条件";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timerToolTipHide;
        private System.Windows.Forms.Button button8;
    }
}