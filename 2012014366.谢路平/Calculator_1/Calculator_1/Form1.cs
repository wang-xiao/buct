using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_1
{
    public partial class Form1 : Form
    {
        Stack<double> OPND = new Stack<double>();
        Stack<string> OPTR = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
            showTime.Start(); //启动定时器
        }
        //在label中显示当前时间
        private void showTime_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString();
        }
        private void button_0_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "0";
            textBox.SelectionStart = textBox.Text.Length;  //使光标始终定位在最右边（以下都一样）
        }

        private void button_1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "1";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "2";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "3";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "4";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "5";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "6";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "7";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_8_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "8";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_9_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "9";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_dot_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += ".";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_res_MouseClick(object sender, MouseEventArgs e)
        {
            OPTR.Push("#");
            textBox.Text += "#"; // 在文本框最后加‘#’与上条语句中的‘#’方便判断优先关系
            if (!inputError())
            {
                textBox.Text = calculate().ToString();
            }
            else
            {
                textBox.Text = "error";
            }
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_div_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "/";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_mul_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "*";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_sub_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "-";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_add_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "+";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_sin_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "sin(";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_cos_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "cos(";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_tan_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "tan(";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_left_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += "(";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_right_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text += ")";
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void button_c_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Clear();
        }

        private void button_ce_MouseClick(object sender, MouseEventArgs e)
        {
            string old = textBox.Text;//取得当前的数据    

            if (old.Length > 0)
            {
                if (old.Length > 3 && (old[old.Length - 2] == 'n' || old[old.Length - 2] == 's'))
                {
                    textBox.Text = old.Remove(old.Length - 4);//删掉最后一个字符
                }
                else
                {
                    textBox.Text = old.Remove(old.Length - 1);//删掉最后一个字符
                }

            }
            textBox.SelectionStart = textBox.Text.Length;
        }
        double calculate()
        {
            double x, y;
            int i = 0;
            string number = "", op;
            string text = textBox.Text;
            while (text[i].ToString() != "#" || OPTR.Peek() != "#")      
            {
                if ((text[i] > 47 && text[i] < 58) || text[i] == '.' || (i == 0 && text[i] == '-') || (i != 0 && text[i] == '-' && text[i-1] == '('))            
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
            string text = textBox.Text;
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
                    if (i != 0 && text[i-1] == '(')
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
