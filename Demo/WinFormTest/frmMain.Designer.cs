namespace WinFormTest
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbrToolbar = new System.Windows.Forms.ToolStrip();
            this.cmdLoad = new System.Windows.Forms.ToolStripButton();
            this.tbrToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbrToolbar
            // 
            this.tbrToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdLoad});
            this.tbrToolbar.Location = new System.Drawing.Point(0, 0);
            this.tbrToolbar.Name = "tbrToolbar";
            this.tbrToolbar.Size = new System.Drawing.Size(622, 25);
            this.tbrToolbar.TabIndex = 0;
            this.tbrToolbar.Text = "toolStrip1";
            // 
            // cmdLoad
            // 
            this.cmdLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdLoad.Image = ((System.Drawing.Image)(resources.GetObject("cmdLoad.Image")));
            this.cmdLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(41, 22);
            this.cmdLoad.Text = "&Load";
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 377);
            this.Controls.Add(this.tbrToolbar);
            this.Name = "frmMain";
            this.Text = "DrawImage Demo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnForm_Paint);
            this.tbrToolbar.ResumeLayout(false);
            this.tbrToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tbrToolbar;
        private System.Windows.Forms.ToolStripButton cmdLoad;

    }
}

