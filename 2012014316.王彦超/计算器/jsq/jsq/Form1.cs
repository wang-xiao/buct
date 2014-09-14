using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jsq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float temp1;
        int pos = 0;

        public void addNum(int num)
        {
            textBox1.Text = textBox1.Text + num.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)// 键盘信息
        {
        }

        private void button1_Click(object sender, EventArgs e)//7
        {
            addNum(7);
        }

        private void button2_Click(object sender, EventArgs e)//8
        {
            addNum(8);
        }

        private void button3_Click(object sender, EventArgs e)//9
        {
            addNum(9);
        }

        private void button4_Click(object sender, EventArgs e)//4
        {
            addNum(4);
        }

        private void button5_Click(object sender, EventArgs e)//5
        {
            addNum(5);
        }

        private void button6_Click(object sender, EventArgs e)//6
        {
            addNum(6);
        }

        private void button7_Click(object sender, EventArgs e)//1
        {
            addNum(1);
        }

        private void button8_Click(object sender, EventArgs e)//2
        {
            addNum(2);
        }

        private void button9_Click(object sender, EventArgs e)//3
        {
            addNum(3);
        }

        private void button10_Click(object sender, EventArgs e)//0
        {
            addNum(0);
        }

        private void button16_Click(object sender, EventArgs e)///
        {
            pos = 4;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)//*
        {
            pos = 3;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)//-
        {
            pos = 2;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)//+
        {
            pos = 1;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)//=
        {
            float temp2 = Convert.ToInt64(textBox1.Text);
            switch(pos)
            {
                case 1:
                    textBox1.Text = (temp1 + temp2).ToString();
                    break;
                case 2:
                    textBox1.Text = (temp1 - temp2).ToString();
                    break;
                case 3:
                    textBox1.Text = (temp1 * temp2).ToString();
                    break;
                case 4:
                    textBox1.Text = (temp1 / temp2).ToString();
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)//CE
        {
            textBox1.Text = "";
            temp1 = 0;
            pos = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar))&&e.KeyChar!=(char)8)
            {
                e.Handled = true;
            }
        }

    }
}