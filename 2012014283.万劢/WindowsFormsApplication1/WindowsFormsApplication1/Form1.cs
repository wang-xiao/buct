using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float temp1 = 0;
        float temp2 = 0;
        float result = 0;
        int pos = 0;//加减乘除标记 + - 1；- - 2；* - 3；/ - 4
        int dot = 0;

        public void addNum(int num)
        {
            if (result != 0)
            {
                textBox1.Text = "0";
                result = 0;
            }
            float t = Convert.ToSingle(textBox1.Text);
            if (dot == 0)
            {
                t = t * 10 + num;
            }
            else
            {
                textBox1.Text = textBox1.Text + num.ToString();
                t = Convert.ToSingle(textBox1.Text);
            }
            textBox1.Text = t.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addNum(7);
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

        private void button6_Click(object sender, EventArgs e)
        {
            addNum(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addNum(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addNum(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pos = 1;
            temp1 = Convert.ToSingle(textBox1.Text);
            textBox1.Text = "0";
        }//+

        private void button11_Click(object sender, EventArgs e)
        {
            pos = 2;
            temp1 = Convert.ToSingle(textBox1.Text);
            textBox1.Text = "0";
        }//-

        private void button12_Click(object sender, EventArgs e)
        {
            pos = 3;
            temp1 = Convert.ToSingle(textBox1.Text);
            textBox1.Text = "0";
        }//*

        private void button13_Click(object sender, EventArgs e)
        {
            pos = 4;
            temp1 = Convert.ToSingle(textBox1.Text);
            textBox1.Text = "0";
        }//  /

        private void button14_Click(object sender, EventArgs e)
        {
            temp2 = Convert.ToSingle(textBox1.Text);
            switch (pos)
            {
                case 1:
                    result = temp1 + temp2;
                    textBox1.Text = (result).ToString();
                    break;
                case 2:
                    result = temp1 - temp2;
                    textBox1.Text = (result).ToString();
                    break;
                case 3:
                    result = temp1 * temp2;
                    textBox1.Text = (result).ToString();
                    break;
                case 4:
                    if (temp2 == 0)
                    {
                        result = 1;
                        textBox1.Text = "error";
                        break;
                    }
                    else
                    {
                        result = temp1 / temp2;
                        textBox1.Text = (result).ToString();
                        break;
                    }
            }
            pos = 0;
            dot = 0;
        }//=

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            pos = 0;
            dot = 0;
            temp1 = 0;
            temp2 = 0;
            result = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addNum(0);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dot = 1;
            textBox1.Text = textBox1.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
