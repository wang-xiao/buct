namespace Calculator_1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_res = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_sin = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_tan = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_c = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_ce = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.showTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(12, 35);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(295, 30);
            this.textBox.TabIndex = 1;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_dot
            // 
            this.button_dot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_dot.Location = new System.Drawing.Point(89, 376);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(62, 30);
            this.button_dot.TabIndex = 0;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_dot_MouseClick);
            // 
            // button_res
            // 
            this.button_res.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_res.Location = new System.Drawing.Point(166, 376);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(138, 30);
            this.button_res.TabIndex = 0;
            this.button_res.Text = "=";
            this.button_res.UseVisualStyleBackColor = true;
            this.button_res.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_res_MouseClick);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_1.Location = new System.Drawing.Point(12, 335);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(62, 30);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_1_MouseClick);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_2.Location = new System.Drawing.Point(89, 335);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(62, 30);
            this.button_2.TabIndex = 0;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_2_MouseClick);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_3.Location = new System.Drawing.Point(166, 335);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(62, 30);
            this.button_3.TabIndex = 0;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_3_MouseClick);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_div.Location = new System.Drawing.Point(242, 335);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(62, 30);
            this.button_div.TabIndex = 0;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_div_MouseClick);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_4.Location = new System.Drawing.Point(12, 292);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(62, 30);
            this.button_4.TabIndex = 0;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_4_MouseClick);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_5.Location = new System.Drawing.Point(89, 292);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(62, 30);
            this.button_5.TabIndex = 0;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_5_MouseClick);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_7.Location = new System.Drawing.Point(12, 251);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(62, 30);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_7_MouseClick);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_6.Location = new System.Drawing.Point(166, 292);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(62, 30);
            this.button_6.TabIndex = 0;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_6_MouseClick);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_8.Location = new System.Drawing.Point(89, 251);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(62, 30);
            this.button_8.TabIndex = 0;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_8_MouseClick);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_9.Location = new System.Drawing.Point(166, 251);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(62, 30);
            this.button_9.TabIndex = 0;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_9_MouseClick);
            // 
            // button_mul
            // 
            this.button_mul.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_mul.Location = new System.Drawing.Point(242, 292);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(62, 30);
            this.button_mul.TabIndex = 0;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_mul_MouseClick);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_sub.Location = new System.Drawing.Point(242, 251);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(62, 30);
            this.button_sub.TabIndex = 0;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_sub_MouseClick);
            // 
            // button_sin
            // 
            this.button_sin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_sin.Location = new System.Drawing.Point(12, 209);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(62, 30);
            this.button_sin.TabIndex = 0;
            this.button_sin.Text = "sin";
            this.button_sin.UseVisualStyleBackColor = true;
            this.button_sin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_sin_MouseClick);
            // 
            // button_cos
            // 
            this.button_cos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cos.Location = new System.Drawing.Point(89, 209);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(62, 30);
            this.button_cos.TabIndex = 0;
            this.button_cos.Text = "cos";
            this.button_cos.UseVisualStyleBackColor = true;
            this.button_cos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_cos_MouseClick);
            // 
            // button_left
            // 
            this.button_left.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_left.Location = new System.Drawing.Point(12, 168);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(62, 30);
            this.button_left.TabIndex = 0;
            this.button_left.Text = "(";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_left_MouseClick);
            // 
            // button_tan
            // 
            this.button_tan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_tan.Location = new System.Drawing.Point(166, 209);
            this.button_tan.Name = "button_tan";
            this.button_tan.Size = new System.Drawing.Size(62, 30);
            this.button_tan.TabIndex = 0;
            this.button_tan.Text = "tan";
            this.button_tan.UseVisualStyleBackColor = true;
            this.button_tan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_tan_MouseClick);
            // 
            // button_right
            // 
            this.button_right.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_right.Location = new System.Drawing.Point(89, 168);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(62, 30);
            this.button_right.TabIndex = 0;
            this.button_right.Text = ")";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_right_MouseClick);
            // 
            // button_c
            // 
            this.button_c.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_c.Location = new System.Drawing.Point(166, 168);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(62, 30);
            this.button_c.TabIndex = 0;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = true;
            this.button_c.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_c_MouseClick);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add.Location = new System.Drawing.Point(242, 209);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(62, 30);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_add_MouseClick);
            // 
            // button_ce
            // 
            this.button_ce.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ce.Location = new System.Drawing.Point(242, 168);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(62, 30);
            this.button_ce.TabIndex = 0;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = true;
            this.button_ce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_ce_MouseClick);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_0.Location = new System.Drawing.Point(12, 376);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(62, 30);
            this.button_0.TabIndex = 0;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_0_MouseClick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_time.Location = new System.Drawing.Point(12, 86);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(71, 12);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "CurrentTime";
            // 
            // showTime
            // 
            this.showTime.Tick += new System.EventHandler(this.showTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 445);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_ce);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_tan);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_cos);
            this.Controls.Add(this.button_res);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_sin);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_dot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_sin;
        private System.Windows.Forms.Button button_cos;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_tan;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_ce;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer showTime;
    }
}

