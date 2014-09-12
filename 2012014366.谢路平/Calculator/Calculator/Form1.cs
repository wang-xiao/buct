using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        Stack<double> OPND = new Stack<double>();
        Stack<string> OPTR = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
            timer_show.Start();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
            if (e.X >= 306 && e.X <= 340 && e.Y >= 0 && e.Y <= 18)
            {
                pictureBox_exit.Visible = true;
            }
            if (WhichLine(e.Y) == 6 && e.X > 177 && e.X < 307)
            {
                label_res.Visible = true;
            }
            else
            {
                switch (WhichPosition(e.X, e.Y))
                {
                    case 11: label_left.Visible = true; break;
                    case 12: label_right.Visible = true; break;
                    case 13: label_c.Visible = true; break;
                    case 14: pictureBox_back.Visible = true; break;
                    case 21: label_sin.Visible = true; break;
                    case 22: label_cos.Visible = true; break;
                    case 23: label_tan.Visible = true; break;
                    case 24: label_add.Visible = true; break;
                    case 31: label_7.Visible = true; break;
                    case 32: label_8.Visible = true; break;
                    case 33: label_9.Visible = true; break;
                    case 34: label_sub.Visible = true; break;
                    case 41: label_4.Visible = true; break;
                    case 42: label_5.Visible = true; break;
                    case 43: label_6.Visible = true; break;
                    case 44: label_mul.Visible = true; break;
                    case 51: label_1.Visible = true; break;
                    case 52: label_2.Visible = true; break;
                    case 53: label_3.Visible = true; break;
                    case 54: label_div.Visible = true; break;
                    case 61: label_0.Visible = true; break;
                    case 62: label_dot.Visible = true; break;
                }
            }
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void pictureBox_exit_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_exit.Visible = false;
        }

        int WhichLine(int y)
        {
            if (y > 231 && y < 263)
            {
                return 1;
            }
            else if (y > 277 && y < 309)
            {
                return 2;
            }
            else if(y > 322 && y < 354){
                return 3;
            }
            else if(y > 367 && y < 399)
            {
                return 4;
            }
            else if (y > 412 && y < 444)
            {
                return 5;
            }
            else if (y > 457 && y < 489)
            {
                return 6;
            }
            return -1;

        }

        int WhichRank(int x)
        {
            if (x > 11 && x < 82)
            {
                return 1;
            }
            else if (x > 94 && x < 165)
            {
                return 2;
            }
            else if (x > 177 && x < 236)
            {
                return 3;
            }
            else if(x > 260 && x < 307)
            {
                return 4;
            }
            return -1;
        }

        int WhichPosition(int x,int y)
        {
            return WhichLine(y) * 10 + WhichRank(x);
        }

        private void label_left_MouseLeave(object sender, EventArgs e)
        {
            label_left.Visible = false;
        }

        private void label_right_MouseLeave(object sender, EventArgs e)
        {
            label_right.Visible = false;
        }

        private void label_c_MouseLeave(object sender, EventArgs e)
        {
            label_c.Visible = false;
        }

        private void pictureBox_back_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_back.Visible = false;
        }

        private void label_sin_MouseLeave(object sender, EventArgs e)
        {
            label_sin.Visible = false;
        }

        private void label_cos_MouseLeave(object sender, EventArgs e)
        {
            label_cos.Visible = false;
        }

        private void label_tan_MouseLeave(object sender, EventArgs e)
        {
            label_tan.Visible = false;
        }

        private void label_add_MouseLeave(object sender, EventArgs e)
        {
            label_add.Visible = false;
        }

        private void label_7_MouseLeave(object sender, EventArgs e)
        {
            label_7.Visible = false;
        }

        private void label_8_MouseLeave(object sender, EventArgs e)
        {
            label_8.Visible = false;
        }

        private void label_9_MouseLeave(object sender, EventArgs e)
        {
            label_9.Visible = false;
        }

        private void label_sub_MouseLeave(object sender, EventArgs e)
        {
            label_sub.Visible = false;
        }

        private void label_4_MouseLeave(object sender, EventArgs e)
        {
            label_4.Visible = false;
        }

        private void label_5_MouseLeave(object sender, EventArgs e)
        {
            label_5.Visible = false;
        }

        private void label_6_MouseLeave(object sender, EventArgs e)
        {
            label_6.Visible = false;
        }

        private void label_mul_MouseLeave(object sender, EventArgs e)
        {
            label_mul.Visible = false;
        }

        private void label_1_MouseLeave(object sender, EventArgs e)
        {
            label_1.Visible = false;
        }

        private void label_2_MouseLeave(object sender, EventArgs e)
        {
            label_2.Visible = false;
        }

        private void label_3_MouseLeave(object sender, EventArgs e)
        {
            label_3.Visible = false;
        }

        private void label_div_MouseLeave(object sender, EventArgs e)
        {
            label_div.Visible = false;
        }

        private void label_0_MouseLeave(object sender, EventArgs e)
        {
            label_0.Visible = false;
        }

        private void label_dot_MouseLeave(object sender, EventArgs e)
        {
            label_dot.Visible = false;
        }

        private void label_res_MouseLeave(object sender, EventArgs e)
        {
            label_res.Visible = false;
        }

        private void label_left_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "(";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_right_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += ")";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_c_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_input.Clear();
        }

        private void pictureBox_back_MouseClick(object sender, MouseEventArgs e)
        {
            string old = textBox_input.Text;//取得当前的数据    
            if (old.Length > 0)
            {
                if (old.Length > 3 && (old[old.Length - 2] == 'n' || old[old.Length - 2] == 's'))
                {
                    textBox_input.Text = old.Remove(old.Length - 4);//删掉最后四个字符
                }
                else
                {
                    textBox_input.Text = old.Remove(old.Length - 1);//删掉最后一个字符
                }

            }
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_sin_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "sin(";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_cos_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "cos(";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_tan_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "tan(";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_add_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "+";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_7_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "7";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_8_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "8";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_9_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "9";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_sub_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "-";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "4";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_5_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "5";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_6_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "6";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_mul_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "*";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "1";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "2";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "3";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_div_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "/";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_0_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += "0";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_dot_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox_input.Clear();
                textBox_output.Clear();
            }
            textBox_input.Text += ".";
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        private void label_res_MouseClick(object sender, MouseEventArgs e)
        {
            
            OPTR.Push("#");
            if (!inputError())
            {
                textBox_output.Text = calculate().ToString();
            }
            else
            {
                textBox_output.Text = "error";
            }
            textBox_output.SelectionStart = textBox_output.Text.Length;
        }

        private void timer_show_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString();
        }

        double calculate()
        {
            double x, y;
            int i = 0;
            string number = "", op;
            string text = textBox_input.Text + "#";
            while (text[i].ToString() != "#" || OPTR.Peek() != "#")
            {
                if ((text[i] > 47 && text[i] < 58) || text[i] == '.' || (i == 0 && text[i] == '-') || (i != 0 && text[i] == '-' && text[i - 1] == '('))
                {
                    number += text[i].ToString();
                    i++;
                }
                else
                {
                    if (number != "")
                    {
                        OPND.Push(double.Parse(number)); //转换为数字入栈
                        number = ""; // 重置number字符串
                    }
                    if (text[i] == 's' || text[i] == 'c' || text[i] == 't') // 判断是否为三角函数
                    {
                        OPTR.Push(text[i].ToString()); // 是三角函数将首字母入栈
                        i += 3; // 跳过3个字符，如sin就不必操作i、n两个字符
                    }
                    switch (Precede(OPTR.Peek(), text[i].ToString()))
                    {
                        case "<": OPTR.Push(text[i].ToString()); i++; break;
                        case "=":
                            {
                                OPTR.Pop();
                                //去除一对括号后判断是否应计算三角函数
                                if (OPTR.Peek().Equals("s")) // 计算sin值
                                {

                                    OPND.Push(Math.Sin((Math.PI / 180) * OPND.Pop())); // 将弧度转化为角度计算后结果入栈
                                    OPTR.Pop();
                                }
                                else if (OPTR.Peek().Equals("c")) //计算cos值
                                {
                                    OPND.Push(Math.Cos((Math.PI / 180) * OPND.Pop()));
                                    OPTR.Pop();
                                }
                                else if (OPTR.Peek().Equals("t")) //计算tan值
                                {
                                    OPND.Push(Math.Tan((Math.PI / 180) * OPND.Pop()));
                                    OPTR.Pop();
                                }
                                i++;
                                break;
                            }
                        case ">":
                            {
                                //分别取出运算符和两个操作数计算
                                op = OPTR.Pop();
                                y = OPND.Pop();
                                x = OPND.Pop();
                                OPND.Push(Operate(x, op, y));
                                break;
                            }
                    }
                }
            }
            return OPND.Pop(); // 返回最终结果
        }

        string Precede(string op1, string op2)  //运算符间的优先关系
        {
            string[,] Prior = new string[7, 7]{ 
                { ">", ">", "<", "<", "<", ">", ">"},
                { ">", ">", "<", "<", "<", ">", ">"},
                { ">", ">", ">", ">", "<", ">", ">"},
                { ">", ">", ">", ">", "<", ">", ">"},
                { "<", "<", "<", "<", "<", "=", " "},
                { ">", ">", ">", ">", " ", ">", ">"},
                { "<", "<", "<", "<", "<", " ", "="},
            };
            return (Prior[Judge(op1), Judge(op2)]);
        }

        int Judge(string op) // 判断Prior数组中的位置
        {
            int temp = 0;
            switch (op)
            {
                case "+": temp = 0; break;
                case "-": temp = 1; break;
                case "*": temp = 2; break;
                case "/": temp = 3; break;
                case "(": temp = 4; break;
                case ")": temp = 5; break;
                case "#": temp = 6; break;
            }
            return temp;
        }
        double Operate(double x, string op, double y) // 具体加减乘除运算
        {
            if (op == "+")
            {
                return x + y;
            }
            else if (op == "-")
            {
                return x - y;
            }
            else if (op == "*")
            {
                return x * y;
            }
            else if (op == "/")
            {
                return x / y;
            }
            return -1;
        }

        bool inputError()
        {
            int count = 0;
            string text = textBox_input.Text + "#";
            //判断第一个字符是否为+ - * /如果是输入非法返回
            if (text[0] == '+' || text[0] == '*' || text[0] == '/' || text[0] == '.' || text[0] == ')')
            {
                return true;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(') // 用来判断括号是否匹配
                {
                    if (text[i + 1] == '+' || text[i + 1] == '*' || text[i + 1] == '/' || text[i + 1] == '.')
                    {
                        return true;
                    }
                    if (i != 0 && (text[i - 1] > 47 && text[i - 1] < 58))
                    {
                        return true;
                    }
                    count++;
                }
                else if (text[i] == ')')// 用来判断括号是否匹配
                {
                    if (i != 0 && text[i - 1] == '(')
                    {
                        return true;
                    }
                    count--;
                }
                else if (text[i] == '.' && (text[i + 1] > 58 || text[i + 1] < 47)) //判断小数点后是否为数字
                {
                    return true;
                }
                else if (text[i] > 41 && text[i] < 48 && text[i + 1] > 41 && text[i + 1] < 48) // 判断是否两个运算符连在一起如 1++2
                {
                    return true;
                }
            }
            if (count == 0) // count为0括号匹配
            {
                return false;
            }
            return true;
        }
    }
}
