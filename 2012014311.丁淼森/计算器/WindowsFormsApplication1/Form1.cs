using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double Num1, Num2, Result;
        string Rst;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textBox1.Text);
            Num2 = Convert.ToDouble(textBox2.Text);
            Result = Num1 + Num2;
            Rst=Convert .ToString (Result);
            textBox3.Text = Rst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textBox1.Text);
            Num2 = Convert.ToDouble(textBox2.Text);
            Result = Num1 - Num2;
            Rst = Convert.ToString(Result);
            textBox3.Text = Rst;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textBox1.Text);
            Num2 = Convert.ToDouble(textBox2.Text);
            Result = Num1 * Num2;
            Rst = Convert.ToString(Result);
            textBox3.Text = Rst;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textBox1.Text);
            Num2 = Convert.ToDouble(textBox2.Text);
            Result = Num1 / Num2;
            Rst = Convert.ToString(Result);
            textBox3.Text = Rst;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
