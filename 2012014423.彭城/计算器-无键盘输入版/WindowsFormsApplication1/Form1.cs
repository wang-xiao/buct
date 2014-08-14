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

        public int intNumPoint;//1=douNum1,2=douNum2，输入和处理的焦点
        public int intNumOperation;//0=无，1=+，2=-，3=*，4=/
        public double douNum1;
        public string strNum1;
        public double douNum2;
        public string strNum2;
        public int intReset;
        
        public Form1()
        {
            InitializeComponent();

            intNumPoint = 1;
            intNumOperation = 0;
            douNum1 = 0;
            douNum2 = 0;
            strNum1 = "0";
            strNum2 = "0";
            intReset = 0;
        }

        public bool checkPoint(string str)
        {
            for (int i = 0; i < str.Length;i++ )
            {
                if (str[i] == '.')
                    return true;
            }
            return false;
        }

        public void autoReset()
        {
            intNumPoint = 1;
            intNumOperation = 0;
            douNum1 = 0;
            douNum2 = 0;
            strNum1 = "0";
            strNum2 = "0";
            textBox1.Text = "0";
            label1.Text = "NULL";
        }

        public void go()
        {
            if (intNumPoint == 1)
            {
                intNumOperation = 0;
                textBox1.Text = strNum1;
                label1.Text = "NULL";
            }
            else
            {
                switch(intNumOperation)
                {
                    case 1:
                        {
                            douNum1 = douNum1 + douNum2;
                            break; 
                        }
                    case 2:
                        {
                            douNum1 = douNum1 - douNum2;
                            break; 
                        }
                    case 3:
                        { 
                            douNum1 = douNum1 * douNum2;
                            break; 
                        }
                    case 4:
                        { 
                            douNum1 = douNum1 / douNum2;
                            break; 
                        }
                }
                douNum2 = 0;
                strNum2 = "";
                strNum1 = Convert.ToString(douNum1);
                intNumOperation = 0;
                intNumPoint = 1;
                textBox1.Text = strNum1;
                label1.Text = "NULL";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = "0";
            label1.Text = "NULL";
        }

        private void button1_Click(object sender, EventArgs e)//按1
        {
            if(intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if(intNumPoint==1)
            {
                if (strNum1.Length == 1&&strNum1[0]=='0')
                    strNum1 = "";
                strNum1 += "1";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1&&strNum2[0]=='0')
                    strNum2 = "";
                strNum2 += "1";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button11_Click(object sender, EventArgs e)// +
        {
            intReset = 0;
            if(intNumPoint==2)//有需要预处理的操作
            {
                go();
            }
            intNumPoint = 2;
            intNumOperation = 1;
            label1.Text = "+";
            textBox1.Text = strNum2;
        }

        private void button12_Click(object sender, EventArgs e)// -
        {
            intReset = 0;
            if(intNumPoint==2)//有需要预处理的操作
            {
                go();
            }
            intNumPoint = 2;
            intNumOperation = 2;
            label1.Text = "-";
            textBox1.Text = strNum2;
        }

        private void button13_Click(object sender, EventArgs e)// *
        {
            intReset = 0;
            if(intNumPoint==2)//有需要预处理的操作
            {
                go();
            }
            intNumPoint = 2;
            intNumOperation = 3;
            label1.Text = "×";
            textBox1.Text = strNum2;
        }

        private void button14_Click(object sender, EventArgs e)// /
        {
            intReset = 0;
            if(intNumPoint==2)//有需要预处理的操作
            {
                go();
            }
            intNumPoint = 2;
            intNumOperation = 4;
            label1.Text = "÷";
            textBox1.Text = strNum2;
        }

        private void button10_Click(object sender, EventArgs e)//按0
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "";
                strNum1 += "0";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "";
                strNum2 += "0";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button7_Click(object sender, EventArgs e)//按7
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "";
                strNum1 += "7";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "";
                strNum2 += "7";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button4_Click(object sender, EventArgs e)//按4
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "";
                strNum1 += "4";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "";
                strNum2 += "4";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button2_Click(object sender, EventArgs e)//按2
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "";
                strNum1 += "2";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "";
                strNum2 += "2";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button5_Click(object sender, EventArgs e)//按5
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "";
                strNum1 += "5";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "";
                strNum2 += "5";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button8_Click(object sender, EventArgs e)//按8
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "";
                strNum1 += "8";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "";
                strNum2 += "8";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button16_Click(object sender, EventArgs e)//小数点
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (checkPoint(strNum1) == true)
                    return;
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "0";
                strNum1 += ".";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (checkPoint(strNum2) == true)
                    return;
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "0";
                strNum2 += ".";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button15_Click(object sender, EventArgs e)//计算
        {
            intReset = 1;
            go();
        }

        private void button9_Click(object sender, EventArgs e)//按9
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "";
                strNum1 += "9";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "";
                strNum2 += "9";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button6_Click(object sender, EventArgs e)//按6
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "";
                strNum1 += "6";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "";
                strNum2 += "6";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button3_Click(object sender, EventArgs e)//按3
        {
            if (intReset == 1)
            {
                autoReset();
                intReset = 0;
            }
            if (intNumPoint == 1)
            {
                if (strNum1.Length == 1 && strNum1[0] == '0')
                    strNum1 = "";
                strNum1 += "3";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                if (strNum2.Length == 1 && strNum2[0] == '0')
                    strNum2 = "";
                strNum2 += "3";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        private void button17_Click(object sender, EventArgs e)//退格
        {
            if(intNumPoint==1)
            {
                strNum1 = strNum1.Substring(0, strNum1.Length - 1);
                if (strNum1.Length == 0)
                    strNum1 = "0";
                douNum1 = Convert.ToDouble(strNum1);
                textBox1.Text = strNum1;
            }
            else
            {
                strNum2 = strNum2.Substring(0, strNum2.Length - 1);
                if (strNum2.Length == 0)
                    strNum2 = "0";
                douNum2 = Convert.ToDouble(strNum2);
                textBox1.Text = strNum2;
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)//清空，还原
        {
            intNumPoint = 1;
            intNumOperation = 0;
            douNum1 = 0;
            douNum2 = 0;
            strNum1 = "0";
            strNum2 = "0";
            textBox1.Text = "0";
            label1.Text = "NULL";
        }
    }
}
