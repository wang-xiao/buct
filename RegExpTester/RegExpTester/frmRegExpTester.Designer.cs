namespace RegExpTester
{
    partial class frmRegExpTester
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegExpTester));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.cmdExecute = new System.Windows.Forms.Button();
            this.fraText = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.fraResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtReplacePattern = new System.Windows.Forms.TextBox();
            this.fraOptions = new System.Windows.Forms.GroupBox();
            this.chkSingleLine = new System.Windows.Forms.CheckBox();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.chkMultiLine = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdReplace = new System.Windows.Forms.Button();
            this.fraText.SuspendLayout();
            this.fraResult.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.fraOptions.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "正则表达式：";
            // 
            // txtPattern
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPattern, 2);
            this.txtPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPattern.Location = new System.Drawing.Point(105, 3);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(618, 21);
            this.txtPattern.TabIndex = 1;
            // 
            // cmdExecute
            // 
            this.cmdExecute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdExecute.Location = new System.Drawing.Point(738, 3);
            this.cmdExecute.Name = "cmdExecute";
            this.cmdExecute.Size = new System.Drawing.Size(75, 21);
            this.cmdExecute.TabIndex = 2;
            this.cmdExecute.Text = "执行(&E)";
            this.cmdExecute.UseVisualStyleBackColor = true;
            this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
            // 
            // fraText
            // 
            this.fraText.Controls.Add(this.txtText);
            this.fraText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fraText.Location = new System.Drawing.Point(0, 0);
            this.fraText.Name = "fraText";
            this.fraText.Size = new System.Drawing.Size(404, 420);
            this.fraText.TabIndex = 3;
            this.fraText.TabStop = false;
            this.fraText.Text = "待测试文本";
            // 
            // txtText
            // 
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Location = new System.Drawing.Point(3, 17);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(398, 400);
            this.txtText.TabIndex = 0;
            // 
            // fraResult
            // 
            this.fraResult.Controls.Add(this.txtResult);
            this.fraResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fraResult.Location = new System.Drawing.Point(0, 0);
            this.fraResult.Name = "fraResult";
            this.fraResult.Size = new System.Drawing.Size(412, 420);
            this.fraResult.TabIndex = 4;
            this.fraResult.TabStop = false;
            this.fraResult.Text = "匹配/替换 结果";
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 17);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(406, 400);
            this.txtResult.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.49733F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.50268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Controls.Add(this.txtReplacePattern, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fraOptions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPattern, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdExecute, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdReplace, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 533);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtReplacePattern
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtReplacePattern, 2);
            this.txtReplacePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplacePattern.Location = new System.Drawing.Point(105, 30);
            this.txtReplacePattern.Name = "txtReplacePattern";
            this.txtReplacePattern.Size = new System.Drawing.Size(618, 21);
            this.txtReplacePattern.TabIndex = 6;
            // 
            // fraOptions
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.fraOptions, 4);
            this.fraOptions.Controls.Add(this.chkSingleLine);
            this.fraOptions.Controls.Add(this.chkIgnoreCase);
            this.fraOptions.Controls.Add(this.chkMultiLine);
            this.fraOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fraOptions.Location = new System.Drawing.Point(3, 58);
            this.fraOptions.Name = "fraOptions";
            this.fraOptions.Size = new System.Drawing.Size(820, 46);
            this.fraOptions.TabIndex = 2;
            this.fraOptions.TabStop = false;
            this.fraOptions.Text = "选项";
            // 
            // chkSingleLine
            // 
            this.chkSingleLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSingleLine.AutoSize = true;
            this.chkSingleLine.Location = new System.Drawing.Point(229, 21);
            this.chkSingleLine.Name = "chkSingleLine";
            this.chkSingleLine.Size = new System.Drawing.Size(84, 16);
            this.chkSingleLine.TabIndex = 3;
            this.chkSingleLine.Text = "SingleLine";
            this.chkSingleLine.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Location = new System.Drawing.Point(116, 21);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(84, 16);
            this.chkIgnoreCase.TabIndex = 3;
            this.chkIgnoreCase.Text = "IgnoreCase";
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // chkMultiLine
            // 
            this.chkMultiLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkMultiLine.AutoSize = true;
            this.chkMultiLine.Location = new System.Drawing.Point(11, 21);
            this.chkMultiLine.Name = "chkMultiLine";
            this.chkMultiLine.Size = new System.Drawing.Size(78, 16);
            this.chkMultiLine.TabIndex = 2;
            this.chkMultiLine.Text = "MultiLine";
            this.chkMultiLine.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.splitContainer1, 4);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 110);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fraText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fraResult);
            this.splitContainer1.Size = new System.Drawing.Size(820, 420);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "替换表达式：";
            // 
            // cmdReplace
            // 
            this.cmdReplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdReplace.Location = new System.Drawing.Point(738, 30);
            this.cmdReplace.Name = "cmdReplace";
            this.cmdReplace.Size = new System.Drawing.Size(75, 21);
            this.cmdReplace.TabIndex = 2;
            this.cmdReplace.Text = "替换(&R)";
            this.cmdReplace.UseVisualStyleBackColor = true;
            this.cmdReplace.Click += new System.EventHandler(this.cmdReplace_Click);
            // 
            // frmRegExpTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegExpTester";
            this.Text = "正则表达式测试";
            this.fraText.ResumeLayout(false);
            this.fraText.PerformLayout();
            this.fraResult.ResumeLayout(false);
            this.fraResult.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.fraOptions.ResumeLayout(false);
            this.fraOptions.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button cmdExecute;
        private System.Windows.Forms.GroupBox fraText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.GroupBox fraResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox fraOptions;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.CheckBox chkMultiLine;
        private System.Windows.Forms.CheckBox chkSingleLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReplacePattern;
        private System.Windows.Forms.Button cmdReplace;
    }
}

