using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器测试1
{
    public partial class Form1 : Form
    {

        double Num1 = 0;
        double Num2 = 0;
        int pos = 0;  //计算方法
        int flag = 0;//“=”信号量，判断重复等于
        bool point=false;//判断小数点，避免多次输入
        bool waitSingle = false;//判断是否在使用“=”之后输入
        bool subSingle = false;//负号信号量

        public Form1()
        {
            InitializeComponent();
        }


        public void addNum(int num)
        {
            if (waitSingle == false)
            {
                textBox1.Text = textBox1.Text + num.ToString();
                flag = 0;
                subSingle = false;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            addNum(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNum(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNum(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNum(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNum(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addNum(5);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            addNum(7);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            addNum(8);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            addNum(9);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNum(6);
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.Length != 0)
            {
                pos = 4;
                textBox2.Text = textBox1.Text + "/";
                Num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                point = false;
                waitSingle = false;
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.Length != 0)
            {
                pos = 3;
                textBox2.Text = textBox1.Text + "*";
                Num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                point = false;
                waitSingle = false;
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.Length != 0&&subSingle==false)
            {
                pos = 2;
                textBox2.Text = textBox1.Text + "-";
                Num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                point = false;//小数点信号量
                waitSingle = false;//等号信号量
            }
            else
            {
                if (textBox1.Text.Length == 0 && subSingle == false)
                {
                    textBox1.Text = textBox1.Text + "-";
                    subSingle = true;
                }
            }
            
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != null && textBox1.Text.Length != 0)
            {
                pos = 1;
                textBox2.Text = textBox1.Text + "+";
                Num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                point = false;
                waitSingle = false;
            }
            
        }

        private void answer_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                Num2 = Convert.ToDouble(textBox1.Text);
                point = false;
                waitSingle = true;
                switch (pos)
                {
                    case 1:
                        textBox1.Text = (Num1 + Num2).ToString();
                        textBox2.Text = textBox2.Text + Num2;
                        flag = 1;
                        break;
                    case 2:
                        textBox1.Text = (Num1 - Num2).ToString();
                        textBox2.Text = textBox2.Text + Num2;
                        flag = 1;
                        break;
                    case 3:
                        textBox1.Text = (Num1 * Num2).ToString();
                        textBox2.Text = textBox2.Text + Num2;
                        flag = 1;
                        break;
                    case 4:
                        textBox1.Text = (Num1 / Num2).ToString();
                        textBox2.Text = textBox2.Text + Num2;
                        flag = 1;
                        break;
                    case 0:
                        textBox2.Text = textBox1.Text;
                        break;
                }
            }
            


        }

        private void AC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            pos = 0;
            Num1 = 0;
            textBox2.Text = "";
            waitSingle = false;
            point = false;
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (point == false && textBox1.Text.Length != 0 && waitSingle != true)
            {
                textBox1.Text = textBox1.Text + ".";
                point = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=null&&textBox1.Text!="")
            addNum(0);
        }

 

    }
}
