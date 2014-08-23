using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF_Fractal01
{
    public partial class Form1 : Form
    {
        Bitmap background;   //内存位图
        double xl, xs;     //横向右边界，左边界（原尺寸）
        double yl, ys;     //纵向上边界，下边界（原尺寸）
        double x0, y0;     //当前公式运算中的x,y值
        double xb, yb;     //横纵向比率
        double xk, yk;     //公式衍推缓存量
        double r;          //逃逸半径
        double p, q;       //常数量，作为收敛点集的偏转量

        int H,K,k,m;       //k为当前阶数
        int Mx, My;        //绘图范围
        int nx, ny;        //坐标点x,y，用于指示绘图位置点
        int ho, lv, lan;   //红，绿，蓝三色整形指示值

        public Form1()
        {
            InitializeComponent();
        }
        
        void Create()
        {
            K = 100;    //逃逸时间
            m = 500;    //逃逸半径
            Mx = 800; My = 600;   //绘图范围
            xs = -1.5;
            xl = 1.5;
            ys = -1.5;
            yl = 1.5;
            p = 0.32;
            q = 0.043;

            background = new Bitmap(800, 600, System.Drawing.Imaging.PixelFormat.Format24bppRgb);//画在PictureBox上   
            Random r1 = new Random();
            


            xb = (xl - xs) / Mx;     //转为实际绘图尺寸的横纵比率
            yb = (yl - ys) / My;

            for (nx = 0; nx <Mx;nx++ )
            {
                for(ny=0;ny<My;ny++)
                {
                    x0 = xs + nx * xb;    //横向偏移量
                    y0 = ys + ny * yb;    //纵向偏移量
                    k = 0;
                    
                    loop1(nx,ny);                   
                }
            }
                pictureBox1.CreateGraphics().DrawImage(background, 0, 0);   //位图绘制于pictrueBox1上
        }

        void loop1(int a ,int b)
        {
            xk = x0 * x0 - y0 * y0 + p;   //核心：公式，x,y分别以此公式递推
            yk = 2 * x0 * y0 + q;

            k++;    //阶数晋级
            r = xk * xk + yk * yk;    //逃逸半径
            x0 = xk;
            y0 = yk;

            if (r > m)
            {
                H = k;
                loop2(a,b);
            }
            else if (k == K)
            {
                H = (int)r * 10;
                loop2(a,b);
            }
            else if (r <= m && k < K)
                loop1(a,b);
            else
                loop2(a,b);
        }

        void loop2(int a ,int b)
        {
            lan = H * 1000 / (256*256);    //将原C++中的整数H通过以下3个式子转换成蓝，绿，红三色的指示值
            lv = (H * 1000 - lan * 256 * 256) / 256;
            ho = (H * 1000 - lan * 256 * 256 - lv * 256);
            Color cl = Color.FromArgb(ho, lv, lan);   //三色统合

            background.SetPixel(a, b, cl);   //绘制于位图上
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Create();   //触发
        }

    }
}
