using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器_Bate1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreatNumBut();
            this.ClientSize = new System.Drawing.Size(But_size * 4 + 24, But_size * 4 + 105);
            //改变窗口大小
            this.textBox1.Size = new System.Drawing.Size(But_size * 4, 34);
            //改变textbox大小
            this.C.Size = new System.Drawing.Size(But_size * 2, 26);
            //改变C键大小
            this.Back.Size = new System.Drawing.Size(But_size * 2, 26);
            this.Back.Location = new System.Drawing.Point(12+But_size*2, 50);
            //改变退格键大小及位置
        }


        int But_size = 60;//按钮大小.
        int inputnum1 = 0, inputnum2 = 0;//标识正在输入num1/2
        int clean = 0;//0标识未清零。清零了重新输入num1，未清零继续输入num2且进行计算
        double num1 = 0, num2 = 0;//第一个数和第二个数
        string strnum1 = "0", strnum2;//显示屏显示num1和num2.
        int op;

        private System.Windows.Forms.Button[] NumBut;
        private System.Windows.Forms.Button[] OpeBut;
        private System.Windows.Forms.Button Point;

        void CreatNumBut()
        {
            NumBut = new System.Windows.Forms.Button[10];
            OpeBut = new System.Windows.Forms.Button[5];

            for (int i = 0; i < 10; i++)//添加数字键
            {
                NumBut[i] = new System.Windows.Forms.Button();
                if (i == 0)
                    NumBut[i].Location = new System.Drawing.Point(12 + 1 * But_size, 80 + 3 * But_size);
                else
                    NumBut[i].Location = new System.Drawing.Point(12 + (i - 1) % 3 * But_size, 80 + (i - 1) / 3 * But_size);
                NumBut[i].Size = new System.Drawing.Size(But_size, But_size);
                NumBut[i].Click += new System.EventHandler(NumButClick);
                NumBut[i].Text = i.ToString();
                NumBut[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                NumBut[i].BackColor = System.Drawing.Color.Transparent;
                Controls.Add(NumBut[i]);
            }
            for (int i = 0; i < 5; i++)//添加运算符 及 = 号
            {
                OpeBut[i] = new System.Windows.Forms.Button();
                OpeBut[i].Size = new System.Drawing.Size(But_size, But_size);
                OpeBut[i].Location = new System.Drawing.Point(12 + 3 * But_size, 80 + i * But_size);
                OpeBut[i].BackColor = System.Drawing.Color.Transparent;
                OpeBut[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                switch(i)
                {
                    case 0:
                        OpeBut[i].Text = "+";
                        OpeBut[i].Click += new System.EventHandler(OpeButClick);
                        break;
                    case 1:
                        OpeBut[i].Text = "-";
                        OpeBut[i].Click += new System.EventHandler(OpeButClick);
                        break;
                    case 2:
                        OpeBut[i].Text = "*";
                        OpeBut[i].Click += new System.EventHandler(OpeButClick);
                        break;
                    case 3:
                        OpeBut[i].Text = "/";
                        OpeBut[i].Click += new System.EventHandler(OpeButClick);
                        break;
                    case 4:
                        OpeBut[i].Text = "=";
                        OpeBut[i].Location = new System.Drawing.Point(12 + 2 * But_size, 80 + 3 * But_size);
                        OpeBut[i].Click += new System.EventHandler(SumClick);
                        break;
                }
                Controls.Add(OpeBut[i]);
            }

            Point = new System.Windows.Forms.Button();
            Point.Size = new System.Drawing.Size(But_size, But_size);
            Point.Location = new System.Drawing.Point(12, 80 + 3 * But_size);
            Point.Text = ".";
            Point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Point.Click += new System.EventHandler(NumButClick);
            Point.BackColor = System.Drawing.Color.Transparent;
            Controls.Add(Point);
        }//添加各种按钮

        bool CheckPoint()//查看是否存在小数点
        {
            string temp;
            if (inputnum1 == 0)
                temp = strnum1;
            else
                temp = strnum2;
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] == '.')
                    return true;
            return false;
        }

        private void NumButClick(object sender, EventArgs e)
        {
            string point = ".";
            if (inputnum1 == 0)//输入num1
            {
                if (((Button)sender).Text == point)//输入小数点
                {
                    if (CheckPoint() == false)
                        strnum1 += ((Button)sender).Text;
                }
                else if(strnum1 == "0")
                {
                    strnum1 = ((Button)sender).Text;
                }
                else
                    strnum1 += ((Button)sender).Text;
                textBox1.Text = strnum1;
            }
            else//输入num2
            {
                if (strnum2 == "0")
                    strnum2 = ((Button)sender).Text;
                else
                {
                    if (((Button)sender).Text == point)//输入小数点
                    {
                        if (CheckPoint() == false)
                            strnum2 += ((Button)sender).Text;
                    }
                    else
                        strnum2 += ((Button)sender).Text;
                }
                textBox1.Text = strnum2;
                
            }
            
        }//数字按钮响应
        Button preBtu;
        private void OpeButClick(object sender, EventArgs e)
        {
            if (inputnum1 == 0)
            {
                inputnum1 = 1;
                preBtu = (Button)sender;
            }
            else
                inputnum2++;
            if (inputnum2 > 0)
                //SumClick(null, null);
                GetSum();
            if (((Button)sender).Text != "=")
            {
                char temp = Convert.ToChar(((Button)sender).Text);
                op = Convert.ToInt32(temp);
            }
            preBtu.ForeColor = ((Button)sender).ForeColor;
            ((Button)sender).ForeColor = System.Drawing.Color.OrangeRed;
            preBtu = (Button)sender;
        }

        private void SumClick(object sender, EventArgs e)
        {
            GetSum();
            preBtu.ForeColor = ((Button)sender).ForeColor;
            inputnum1 = 0;
            inputnum2 = 0;
        }

        void GetSum()
        {
            num1 = Convert.ToDouble(strnum1);
            num2 = Convert.ToDouble(strnum2);
            //MessageBox.Show(num1.ToString() + (char)op + num2.ToString());
            //MessageBox.Show(op.ToString());
            switch(op)
            {
                case 43:
                    num1 = num1 + num2;
                    break;
                case 45:
                    num1 = num1 - num2;
                    break;
                case 42:
                    num1 = num1 * num2;
                    break;
                case 47:
                    num1 = num1 / num2;
                    break;
            }
            num2 = 0;
            strnum1 = num1.ToString();
            strnum2 = num2.ToString();
            textBox1.Text = strnum1;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon!");
        }

        private void C_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon!");
        }
    }
}
