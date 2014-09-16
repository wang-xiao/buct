using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }
        
        float[] a = new float[20];
        int len = 0; 
        public float vry(float []a,int len){
	        if(len <= 1){
		        //cout<<a[0]<<"wang"<<endl;
		        return a[0];
	        }
	        else {
		        int pp = 0;
		        for(int i = 0;i < len;i++)
                {
			        if(a[i] == -5){
				        float[] c = new float[100];
				        int cc = 0;
				        for(int j = i+1;a[j] != -6 || pp != 0;j++)
                        {
					        if(a[j] == -5)
                            {
						        pp++;
					        }
					        if(a[j] == -6)
                            {
						        pp--;
					        }
					        c[cc++] = a[j];
				        }
				        len -= (cc+1);
				        a[i] = vry(c,cc);
				        //cout<<"a[i]"<<a[i]<<endl;
				        for(int k = i+1;k < len;k++){
					        a[k] = a[k+cc+1];
				        }
			        }
		        }//解决所有的括号 
		        for(int i = 1;i < len;){
			        if(a[i] == -3 || a[i] == -4){
				        if(a[i] == -3){
					        a[i-1] = a[i-1] * a[i+1];
					        len -= 2;
				        }
				        else{
					        a[i-1] = a[i-1] / a[i+1];
					        len -= 2;
				        }
				        for(int j = i;j < len;j++){
					        a[j] = a[j+2];
				        }
			        }
			        else
			            i++;
		        }//解决所有的乘除
		        float sum = a[0];
			    for(int i = 1;i < len;i += 2){
			        if(a[i] == -1){
			            sum += a[i+1];
			        }
		            else{
				        sum -= a[i+1];
			        }   
			    }
			    //cout<<sum<<"wang"<<endl;
			    return sum;
		        //最后解决加减 
	        }
        }//将转化好的数组计算并得到最后的答案 


        private void button16_Click(object sender, EventArgs e)
        {
            string bb = textBox1.Text;
            int len1 =bb.Length;
	        int s = 0;
	        for(int i = 0;i < len1;)
            {
		        switch(bb[i]){
			        case '+':a[len] = -1;len++;i++;break;
			        case '-':a[len] = -2;len++;i++;break;
			        case '*':a[len] = -3;len++;i++;break;
			        case '/':a[len] = -4;len++;i++;break;
			        case '(':a[len] = -5;len++;i++;break;
			        case ')':a[len] = -6;len++;i++;break;
		        }
		        s = 0;
		        int t = 0,ki = 0;
                string ppp = "";
                while (i < len1 && bb[i] != '(' && bb[i] != ')' && bb[i] != '+' && bb[i] != '-' && bb[i] != '*' && bb[i] != '/')
                {
                    ppp += bb[i];
                    ki++;
                    i++;
			        t = 1;
		        }
                if (t == 1)
                    a[len++] = float.Parse(ppp);
	        } 
            float ans ;
            ans = vry (a,len );
            textBox2.Text = ans.ToString();
        }






    }
}
