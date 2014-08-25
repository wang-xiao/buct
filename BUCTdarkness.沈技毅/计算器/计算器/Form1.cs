using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器{
    //看了下彭城同学的计算器完整版，整体做的还不错，但彭sir说要找找彭城同学的问题...那么我就提出几个问题，不一定对，仅供彭城同学参考下了。。。
    //1，不支持连续运算。。（比如系统自带的计算器，算3+3+3+3 时，算连续的加法时，按+即会出来结果，不需要按=）
    //2，无法输入负数。。。
    //3，当按下一个运算符，如果发现刚刚原来按错了。。。修改时会出问题。。这点不符合用户的习惯。。。
    //(比如 要计算3/3，我不小心把/号按成*号了，如果是系统自带的计算器再按一下/即可，但彭同学的似乎不太行。。那样不太符合用户的使用习惯。。)
    

    //本来想用栈来写一个的，不过由于网络赛将至，时间比较紧张，就先用这个水一下了。。。  Q_Q
    //lab1 记录先前的输入 lab2 记录符号 lab3记录当前的输入
    //支持键盘输入
    //支持连续运算
    //支持数字错误修改，支持符号错误修改，比如一开始按的*，发现按错了应该按+才对，按一下即可修改。
    //能够处理负数
    //这个程序是模拟系统的计算器搞的，在没有输入任何值的情况下，输入-5，值为-5
    public partial class Form1 : Form{

        Button btn;
        int cnt = 0;
        public Form1(){
            InitializeComponent();
        }

        public void CLR() {
            lab1.Text = ""; lab2.Text = ""; lab3.Text = ""; cnt = 0; 
        }

        private void Form1_Load(object sender, EventArgs e){
            CLR();
        }

        private void init_Click(object sender, EventArgs e){
            CLR();
        }

        private void buttond_Click(object sender, EventArgs e) {
            btn = (Button)sender;
            if (lab3.Text == "") cnt++;
            lab3.Text = lab3.Text + btn.Text;

        }

        public void caculate(Double x,Double y) {
            switch (lab2.Text)
            {
                case "+": y += x; break;
                case "-": y -= x; break;
                case "*": y *= x; break;
                case "/":
                    if (x == 0) MessageBox.Show("input error!");
                    else y /= x;
                    break;
                case "%":
                    if (x == 0) MessageBox.Show("input error!");
                    else if (x - (int)(x) != 0 || y - (int)(y) != 0) MessageBox.Show("input error!");
                    else {
                        int tmp = (int)y % (int)x;
                        y = (Double)tmp;
                    }
                    break;
                default: break;
            }
            lab1.Text = y.ToString();
            lab3.Text = "";
        }
        
        private void buttonp_Click(object sender, EventArgs e) {
            btn = (Button)sender;
            Double x, y;
            if (lab3.Text == "") {
                lab2.Text = btn.Text; return;
            }
            x = Convert.ToDouble(lab3.Text);
            if (btn.Text != "="){            
                if (cnt == 2) {
                    y = Convert.ToDouble(lab1.Text);
                    cnt = 1;
                    lab2.Text = btn.Text;
                    caculate(x, y);
                    return;
                }
                if (lab1.Text == "" && lab2.Text == "-") x = -x;
                lab2.Text = btn.Text;
                lab1.Text = x.ToString();
                lab3.Text = "";
            }
            else {
                if (lab1.Text != "") y = Convert.ToDouble(lab1.Text);
                else y = 0;
                caculate(x, y);
                lab2.Text = ""; cnt = 1;
            }
        }

        private void del(object sender, EventArgs e){
            if(lab3.Text==""&&lab2.Text=="") return;
            lab3.Text = lab3.Text.Substring(0, lab3.Text.Length - 1);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e){
            char key = e.KeyChar;
            if ((key >= '0' && key <= '9') || key == '.') {
                if (lab3.Text == "") cnt++;
                lab3.Text = lab3.Text + key.ToString();                
            }
            else if(key=='+'||key=='-'||key=='*'||key=='/'||key=='%'||key=='='){
                Double x, y;
                if (lab3.Text == "")
                {
                    lab2.Text = key.ToString(); return;
                }
                x = Convert.ToDouble(lab3.Text);
                if (key == '+' || key == '-' || key == '*' || key == '/' || key == '%')
                {
                    if (cnt == 2)
                    {
                        y = Convert.ToDouble(lab1.Text);
                        cnt = 1;
                        lab2.Text = key.ToString();
                        caculate(x, y);
                        return;
                    }
                    if (lab1.Text == "" && lab2.Text == "-") x = -x;
                    lab2.Text = key.ToString();
                    lab1.Text = x.ToString();
                    lab3.Text = "";
                }
                else if (key == '=')
                {
                    if (lab1.Text != "") y = Convert.ToDouble(lab1.Text);
                    else y = 0;
                    caculate(x, y);
                    lab2.Text = ""; cnt = 1;
                }
            }
            else if (key == 'c') {
                CLR();
            }
            else if (key == '\b') {
                if (lab3.Text == "" && lab2.Text == "") return;
                lab3.Text = lab3.Text.Substring(0, lab3.Text.Length - 1);               
            }
        }

        private void negative_Click(object sender, EventArgs e){
            if (lab3.Text == "") return;
            Double x = Convert.ToDouble(lab3.Text);
            x = -x;
            lab3.Text = x.ToString();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            if (cnt > 0 && lab3.Text != ""){
                lab3.Text = ""; cnt--;
            }
        }
    }
}
