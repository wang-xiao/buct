using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public float Ans = 0;
        public int fla = 0;  //计算状态
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            fla = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += "(";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (fla == 1)
            {
                richTextBox1.Text = "";
                fla = 0;
            }
            richTextBox1.Text += ")";
        }

        public string Cal;

        public struct Enqation   //转化后的数据
        {
            public int type;   //类型
            public char ch;    //运算符
            public float fi;     //运算数
        }

       

        public float jisuan(float a, float b, char s)
        {
            switch (s)
            {
                case 'a': return a + b;
                case 'b': return a - b;
                case 'c': return a * b;
                case 'd': return a / b;
                default: return 1000;
            }

        }

        public void jsgc()
        {
            if (fla == 0)
            {
                Stack<float> czs = new Stack<float>();   //数字栈
                Stack<char> czf = new Stack<char>();  //运算符栈

                float[] Figure = new float[100];
                int t = 0, k = 0, w = 0, y = 0;

                Enqation[] enq = new Enqation[100];
                int[,] zcg = new int[7, 7];            //运算符优先表
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        zcg[i, j] = 0;
                    }
                }
                zcg[4, 0] = zcg[4, 1] = zcg[6, 0] = zcg[6, 1] = 1;
                zcg[0, 2] = zcg[0, 3] = zcg[1, 2] = zcg[1, 3] = 1;
                zcg[4, 2] = zcg[4, 3] = zcg[6, 2] = zcg[6, 3] = 1;
                for (int i = 0; i < 7; i++)
                {
                    zcg[i, 4] = 1;
                }
                zcg[4, 5] = zcg[6, 6] = 2;
                Cal = richTextBox1.Text;
                string[] strtest2 = System.Text.RegularExpressions.Regex.Split(Cal, @"[+ - - * / (  ) ]");//截取数字
                string[] strarry = new string[strtest2.Length];
                for (int i = 0; i < strtest2.Length; i++)
                {
                    if (strtest2[i] != "")
                    {
                        Figure[t] = float.Parse(strtest2[i]);
                        t++;
                        //MessageBox.Show(" " + Figure[t]);
                    }
                }
                for (int i = 0; i < Cal.Length; )   //最终运算的数据保存 
                {
                    if (Cal[i] <= '0' || Cal[i] >= '9')
                    {
                        enq[k].type = 0;
                        //enq[k].ch = Cal[i];
                        switch (Cal[i])
                        {
                            case '+': enq[k].ch = 'a'; break;
                            case '-': enq[k].ch = 'b'; break;
                            case '*': enq[k].ch = 'c'; break;
                            case '/': enq[k].ch = 'd'; break;
                            case '(': enq[k].ch = 'e'; break;
                            case ')': enq[k].ch = 'f'; break;
                            case '#': enq[k].ch = 'g'; break;
                        }
                        //MessageBox.Show(enq[k].ch + "dch");
                        k++;
                        i++;
                    }
                    else
                    {
                        enq[k].type = 1;
                        enq[k].fi = Figure[w];
                        //MessageBox.Show(enq[k].fi + "df");
                        w++;
                        k++;
                        i++;
                        if (i >= Cal.Length)
                        {
                            break;
                        }
                        while (((Cal[i] >= '0' && Cal[i] <= '9') || Cal[i] == '.') && i < Cal.Length)
                        {
                            i++;
                            if (i >= Cal.Length)
                            {
                                break;
                            }
                        }
                    }
                }
                enq[k].type = 0;
                enq[k].ch = 'g';
                czf.Push('g');
                while (czf.Count != 0)
                {
                    if (enq[y].type == 1)
                    {
                        czs.Push(enq[y].fi);
                        y++;
                        //continue;
                    }
                    else
                    {
                        if (zcg[czf.Peek() - 'a', enq[y].ch - 'a'] == 1)
                        {
                            czf.Push(enq[y].ch);
                            y++;
                        }
                        else if (zcg[czf.Peek() - 'a', enq[y].ch - 'a'] == 2)
                        {
                            y++;
                            czf.Pop();
                        }
                        else
                        {
                            float wer2 = czs.Pop();
                            float wer1 = czs.Pop();
                            char fuhao = czf.Pop();
                            czs.Push(jisuan(wer1, wer2, fuhao));
                        }
                    }
                }
                Ans = czs.Peek();
                fla = 1;
                richTextBox1.Text += "\n" + Ans;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            jsgc();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (fla == 0)
            {
                richTextBox1.Text +=  Ans;
            }
            else
            {
                richTextBox1.Text = Ans.ToString();
                fla = 0;
            }
        }
    }
}
