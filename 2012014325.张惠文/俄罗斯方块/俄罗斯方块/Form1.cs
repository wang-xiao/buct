using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace 俄罗斯方块
{
    public partial class Form1 : Form
    {
        public int zt = 0;
        private Image theImage;
        public int[,] area = new int[21, 14];   //游戏区域
        public int x, y;                         //坐标
        public int type;                        //类型
        public int Flag;                        //当前状态
        public string[] yanse = new string[5];  //颜色数组
        int []line = new int [20];              //判断行满依据

        public class dia
        {
            public int[,] loca = new int[3, 2];
            public int next,colour;
        }

        public dia[] dias = new dia[15];
       // List<dia> dias = new List<dia>();
        public Form1()
        {
            InitializeComponent();
            
            SetStyle(ControlStyles.Opaque, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("游戏说明：按w、s、a、d键分别实现转换状态、快速下移、左移右移；游戏难度共10档，可随时改变");
            for(int i = 0;i < 20;i++)
            {
                line[i] = 0;
            }
            for (int i = 1; i < 20; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    area[i, j] = 0;
                }
            }
            for (int i = 0; i < 14; i++)
            {
                area[0,i] = area[20,i] = 2;
            }
            for (int i = 0; i < 21; i++)
            {
                area[i, 0] = area[i, 13] = 2;
            }
            textBox1.Text = "     " + 0;
            Flag = 0;
            csh();
        }

        public void csh()             //构建不同图形数据
        {
            for (int i = 0; i < 15; i++)
            {
                dias[i] = new dia();
            }
            dias[0].loca[0, 0] = -1;   dias[0].loca[0, 1] = -1;
            dias[0].loca[1, 0] = -1;   dias[0].loca[1, 1] = 0;
            dias[0].loca[2, 0] = 1;    dias[0].loca[2, 1] = 0;
            dias[0].next = 1; ; dias[0].colour = 0;    
            dias[1].loca[0, 0] = -1;   dias[1].loca[0, 1] = 1;
            dias[1].loca[1, 0] = 0;    dias[1].loca[1, 1] = 1;
            dias[1].loca[2, 0] = 0;    dias[1].loca[2, 1] = -1;
            dias[1].next = 2; dias[1].colour = 0;
            dias[2].loca[0, 0] = -1;   dias[2].loca[0, 1] = 0;
            dias[2].loca[1, 0] = 1;    dias[2].loca[1, 1] = 0;
            dias[2].loca[2, 0] = 1;    dias[2].loca[2, 1] = 1;
            dias[2].next = 3; dias[2].colour = 0;
            dias[3].loca[0, 0] = 1;    dias[3].loca[0, 1] = -1;
            dias[3].loca[1, 0] = 0;    dias[3].loca[1, 1] = -1;
            dias[3].loca[2, 0] = 0;    dias[3].loca[2, 1] = 1;
            dias[3].next = 0; dias[3].colour = 0;
            dias[4].loca[0, 0] = -1;   dias[4].loca[0, 1] = 1;
            dias[4].loca[1, 0] = -1;   dias[4].loca[1, 1] = 0;
            dias[4].loca[2, 0] = 1;    dias[4].loca[2, 1] = 0;
            dias[4].next = 5; dias[4].colour = 1;
            dias[5].loca[0, 0] = 0;    dias[5].loca[0, 1] = -1;
            dias[5].loca[1, 0] = 0;    dias[5].loca[1, 1] = 1;
            dias[5].loca[2, 0] = 1;    dias[5].loca[2, 1] = 1;
            dias[5].next = 6; dias[5].colour = 1;
            dias[6].loca[0, 0] = -1;   dias[6].loca[0, 1] = 0;
            dias[6].loca[1, 0] = 1;    dias[6].loca[1, 1] = 0;
            dias[6].loca[2, 0] = 1;    dias[6].loca[2, 1] = -1;
            dias[6].next = 7; dias[6].colour = 1;
            dias[7].loca[0, 0] = -1;   dias[7].loca[0, 1] = -1;
            dias[7].loca[1, 0] = 0;    dias[7].loca[1, 1] = -1;
            dias[7].loca[2, 0] = 0;    dias[7].loca[2, 1] = 1;
            dias[7].next = 4; dias[7].colour = 1;
            dias[8].loca[0, 0] = 0;    dias[8].loca[0, 1] = -1;
            dias[8].loca[1, 0] = 0;    dias[8].loca[1, 1] = 1;
            dias[8].loca[2, 0] = 0;    dias[8].loca[2, 1] = 2;
            dias[8].next = 9; dias[8].colour = 2;
            dias[9].loca[0, 0] = -1;   dias[9].loca[0, 1] = 0;
            dias[9].loca[1, 0] = 1;    dias[9].loca[1, 1] = 0;
            dias[9].loca[2, 0] = 2;    dias[9].loca[2, 1] = 0;
            dias[9].next = 8; dias[9].colour = 2;
            dias[10].loca[0, 0] = -1;  dias[10].loca[0, 1] = 0;
            dias[10].loca[1, 0] = -1;  dias[10].loca[1, 1] = -1;
            dias[10].loca[2, 0] = 0;   dias[10].loca[2, 1] = -1;
            dias[10].next = 10; dias[10].colour = 3;
            dias[11].loca[0, 0] = 0;   dias[11].loca[0, 1] = -1;
            dias[11].loca[1, 0] = -1;  dias[11].loca[1, 1] = 0;
            dias[11].loca[2, 0] = 0;   dias[11].loca[2, 1] = 1;
            dias[11].next = 12; dias[11].colour = 4;
            dias[12].loca[0, 0] = -1;  dias[12].loca[0, 1] = 0;
            dias[12].loca[1, 0] = 0;   dias[12].loca[1, 1] = 1;
            dias[12].loca[2, 0] = 1;   dias[12].loca[2, 1] = 0;
            dias[12].next = 13; dias[12].colour = 4;
            dias[13].loca[0, 0] = 0;   dias[13].loca[0, 1] = -1;
            dias[13].loca[1, 0] = 0;   dias[13].loca[1, 1] = 1;
            dias[13].loca[2, 0] = 1;   dias[13].loca[2, 1] = 0;
            dias[13].next = 14; dias[13].colour = 4;
            dias[14].loca[0, 0] = -1;  dias[14].loca[0, 1] = 0;
            dias[14].loca[1, 0] = 1;   dias[14].loca[1, 1] = 0;
            dias[14].loca[2, 0] = 0;   dias[14].loca[2, 1] = -1;
            dias[14].next = 11; dias[14].colour = 4;
            yanse[0] = "blue.png";
            yanse[1] = "red.png";
            yanse[2] = "yellow.png";
            yanse[3] = "green.png";
            yanse[4] = "purple.png";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(10, 10, 360, 570);
            g.FillRectangle(Brushes.Black, r);
        }
        public int score;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (zt==1)
            {
                if (Flag == 0)
                {
                    Random rd = new Random();
                    type = rd.Next(0, 18);
                    if (type == 10 || type == 11)
                    {
                        type -= 2;
                    }
                    else if (type == 12 || type == 13 || type == 14)
                    {
                        type = 10;
                    }
                    else if (type > 14)
                    {
                        type -= 4;
                    }
                    //type = 8;
                    x = 2;
                    y = 5;
                    if (area[x, y] == 2)
                    {
                        MessageBox.Show("此局游戏结束，您的最终得分为：" + score);
                        //imer1.Enabled = false;
                        timer1.Enabled = false;
                        timer1.Stop();

                    }
                    print();

                    Flag = 1;
                }
                else
                {
                    int xx = x + 1;
                    if (panduan(xx, y))
                    {
                        dele();
                        x++;
                        print();
                    }
                    else
                    {
                        area[x, y] = 2;
                        line[x]++;
                        for (int i = 0; i < 3; i++)
                        {
                            line[x + dias[type].loca[i, 0]]++;
                            area[x + dias[type].loca[i, 0], y + dias[type].loca[i, 1]] = 2;
                        }
                        Flag = 0;
                        int kk = 0;
                        for (int i = 1; i < 20; i++)
                        {
                            if (line[i] >= 12)
                            {
                                hanman(i);
                                kk++;
                                //Thread.Sleep(500);
                            }
                        }
                        if (kk == 1)
                        {
                            score += 1;
                            textBox1.Text = "     " + score;
                        }
                        else if (kk == 2)
                        {
                            score += 3;
                            textBox1.Text = "     " + score;
                        }
                        else if (kk == 3)
                        {
                            score += 6;
                            textBox1.Text = "     " + score;
                        }
                        else if (kk == 4)
                        {
                            score += 10;
                            textBox1.Text = "     " + score;
                        }
                        else
                        {
                        }
                    }

                }
            }

        }

        public void print()
        {
            int[,] zs = new int[4, 2];
            zs[0, 0] = (y-1)*30+10; zs[0, 1] = (x-1)*30+10;
            area[x, y] = 1;

            for (int i = 1; i < 4; i++)
            {
                area[x + dias[type].loca[i - 1, 0], y + dias[type].loca[i - 1, 1]] = 1;
                zs[i,1] = (x + dias[type].loca[i-1, 0] - 1)*30 + 10;
                zs[i,0] = (y + dias[type].loca[i-1, 1] - 1) * 30 + 10;
            }
            theImage = new Bitmap(yanse[dias[type].colour]);
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < 4; i++)
            {
                g.DrawImage(theImage, zs[i,0],zs[i,1]);
            }
        }

        public void dele()
        {
           // theImage = new Bitmap(yanse[dias[type].colour]);
            int[,] zs = new int[4, 2];
            zs[0, 0] = (y-1)*30+10; zs[0, 1] = (x-1)*30+10;
            area[x, y] = 0;

            for (int i = 1; i < 4; i++)
            {
                area[x + dias[type].loca[i - 1, 0], y + dias[type].loca[i - 1, 1]] = 0;
                zs[i,1] = (x + dias[type].loca[i-1, 0] - 1)*30 + 10;
                zs[i,0] = (y + dias[type].loca[i-1, 1] - 1) * 30 + 10;
            }
            Rectangle r;
            Graphics g = this.CreateGraphics();
            //g.FillRectangle(Brushes.Black, r);
            for (int i = 0; i < 4; i++)
            {
                r = new Rectangle(zs[i,0],zs[i,1],30,30);
                g.FillRectangle(Brushes.Black, r);
            }
        }
        public bool panduan(int a, int b)
        {
            if(area[a,b] == 2)
            {
                return false;
            }
            for (int i = 0; i < 3; i++)
            {
                if (area[a + dias[type].loca[i, 0], b + dias[type].loca[i, 1]] == 2)
                {
                    return false;
                }
            }
            return true;
        }
        public bool panduan1(int a, int b,int k)
        {
            if (area[a, b] == 2)
            {
                return false;
            }
            for (int i = 0; i < 3; i++)
            {
                if (area[a + dias[k].loca[i, 0], b + dias[k].loca[i, 1]] == 2)
                {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          //timer1.Enabled = true;
            timer1.Start();
            zt = 1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        public void hanman(int a)
        {
            Rectangle r = new Rectangle(10,(a-1)*30+10,360,30);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(Brushes.Black, r);
            Bitmap bit = new Bitmap(360, 30*(a-1));
            Graphics g1 = Graphics.FromImage(bit);
            g1.CompositingQuality = CompositingQuality.HighQuality;
            g1.CopyFromScreen(this.Left + 18,this.Top + 41, 0, 0, bit.Size);
            g = this.CreateGraphics();
            g.DrawImage(bit, 10, 40);
            System.Media.SystemSounds.Hand.Play();
            for (int i = a; i > 1; i--)
            {
                for (int j = 1; j < 13; j++)
                {
                    area[i, j] = area[i - 1, j];
                }
                line[i] = line[i - 1];
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'd'&&zt == 1)
            {
                int yy = y + 1;
                if (panduan(x, yy) && Flag == 1)
                {
                    dele();
                    y++;
                    print();
                }
            }
            else if (e.KeyChar == 'a' && zt == 1)
            {
                int yy = y - 1;
                if (panduan(x, yy) && Flag == 1)
                {
                    dele();
                    y--;
                    print();
                }
            }
            else if (e.KeyChar == 'w' && zt == 1)
            {
                if (panduan1(x, y, dias[type].next) && Flag == 1)
                {
                    dele();
                    type = dias[type].next;
                    print();
                }
            }
            else if (e.KeyChar == 's' && zt == 1)
            {
                if (Flag == 1)
                {
                    int xx = x + 1;
                    if (panduan(xx, y))
                    {
                        dele();
                        x = x + 1;
                        print();
                    }
                    else
                    {
                        area[x, y] = 2;
                        line[x]++;
                        for (int i = 0; i < 3; i++)
                        {
                            line[x + dias[type].loca[i, 0]]++;
                            area[x + dias[type].loca[i, 0], y + dias[type].loca[i, 1]] = 2;
                        }
                        int kk = 0;
                        Flag = 0;
                        for (int i = 1; i < 20; i++)
                        {
                            if (line[i] >= 12)
                            {
                                hanman(i);
                                kk++;
                            }
                        }
                        if (kk == 1)
                        {                            
                            score += 1;
                            textBox1.Text = "     " + score;
                        }
                        else if (kk == 2)
                        {
                            score += 3;
                            textBox1.Text = "     " + score;
                        }
                        else if (kk == 3)
                        {
                            score += 6;
                            textBox1.Text = "     " + score;
                        }
                        else if (kk == 4)
                        {
                            score += 10;
                            textBox1.Text ="     " + score;
                        }
                        else
                        {
                        }
                    }
                }
                
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / Convert.ToInt32(this.numericUpDown1.Value) ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zt = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                line[i] = 0;
            }
            for (int i = 1; i < 20; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    area[i, j] = 0;
                }
            }
            for (int i = 0; i < 14; i++)
            {
                area[0,i] = area[20,i] = 2;
            }
            for (int i = 0; i < 21; i++)
            {
                area[i, 0] = area[i, 13] = 2;
            }
            Flag = 0;
            zt = 1;
            score = 0;
            Graphics g = this.CreateGraphics();
            Rectangle r = new Rectangle(10, 10, 360, 570);
            g.FillRectangle(Brushes.Black, r);
            textBox1.Text = "     " + 0;
        }

    }
}