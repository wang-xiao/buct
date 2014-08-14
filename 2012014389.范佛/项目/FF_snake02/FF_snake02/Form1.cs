using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FF_snake02
{
    
    public partial class Form1 : Form
    {
        int Direct;
        Snake C_Snake;
        S_body S_Apple;
        bool exit = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Create);
            thread.Start();
        }

        void Create()
        {
            C_Snake = new Snake();
            S_Apple = new S_body();
            CreateApple();
            Drawplate();
            DrawOthers();

            int E_count;

            while (true)
            {
                linelimit();
                bodylimit();
                E_count = C_Snake.GetSnake().Count();
                if (exit)
                {
                    resume();
                    Update();
                    Drawplate();
                    DrawOthers();
                    break;
                }

                if (C_Snake.GetSnake()[0].x == S_Apple.x && C_Snake.GetSnake()[0].y == S_Apple.y)
                {
                    EatApple();
                    Update();
                    Drawplate();
                    DrawOthers();
                    continue;
                }

                System.Threading.Thread.Sleep(500);

                if (!DirectCheck())
                {
                    C_Snake.S_Direct = Direct;
                }

                C_Snake.Move();
                 
                Update();
                Drawplate();
                DrawOthers();
            }
            MessageBox.Show("哦也！");
            
        }


    

        public void Drawplate()
        {
            Pen blackpen = new Pen(Color.Black, 2);
            Graphics graphics = this.CreateGraphics();
            int i;

            graphics.FillRectangle(new SolidBrush(Color.Blue), 0, 0, 450, 450);
            for (i = 0; i <= 450; i += 30)
            {
                graphics.DrawLine(blackpen, 0, i, 450, i);
            }
            for (i = 0; i <= 450; i += 30)
            {
                graphics.DrawLine(blackpen, i, 0, i, 450);
            }
        }

        void DrawOthers()
        {
            Graphics graphics = this.CreateGraphics();
            int i;
            int a = C_Snake.GetSnake().Count();

            for(i=0;i<a;i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.Green), C_Snake.GetSnake()[i].X, C_Snake.GetSnake()[i].Y, 30, 30);
            }

            graphics.FillRectangle(new SolidBrush(Color.Red), S_Apple.x, S_Apple.y, 30, 30);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W: Direct = 1; break;
                case Keys.S: Direct = 2; break;
                case Keys.A: Direct = 3; break;
                case Keys.D: Direct = 4; break;
            }      
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exit = true;
        }


        public void linelimit()
        {
            if(C_Snake.GetSnake()[0].x<0||C_Snake.GetSnake()[0].x>=450||C_Snake.GetSnake()[0].y<0||C_Snake.GetSnake()[0].y>=450)
            {
                exit = true;
            }
        }

        public void bodylimit()
        {
            S_body B_body = C_Snake.GetSnake()[0];
            int i;
            for(i=1;i<C_Snake.GetSnake().Count();i++)
            {
                if(B_body.x==C_Snake.GetSnake()[i].x&&B_body.y==C_Snake.GetSnake()[i].y)
                {
                    exit = true;
                }
            }
        }

       
        public void CreateApple()
        {
            Random r = new Random();
            S_Apple.x = r.Next(0, 15)*30;
            S_Apple.y = r.Next(0, 15)*30;
            while(CheckApple())
            {
                S_Apple.x = r.Next(0, 15)*30;
                S_Apple.y = r.Next(0, 15)*30;
            }
        }
        public bool CheckApple()
        {
            int i = 0;
            for (; i < C_Snake.GetSnake().Count();i++ )
            {
                  if(S_Apple.x==C_Snake.GetSnake()[i].x&&S_Apple.y==C_Snake.GetSnake()[i].y)
                  {
                      return true;
                  }
            }
                return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(C_Snake.GetSnake().Count().ToString());
        }

        public void EatApple()
        {   
    
            C_Snake.GetSnake().Add(C_Snake.GetStep());
            CreateApple();
        }

        public void resume()
        {
            int i;
            for(i=0;i<C_Snake.GetSnake().Count()-1;i++)
            {
                C_Snake.GetSnake()[i] = C_Snake.GetSnake()[i + 1];
            }
            int Count = C_Snake.GetSnake().Count();
            C_Snake.GetSnake()[Count - 1] = C_Snake.GetStep();
        }

        public bool DirectCheck()
        {
            if ((C_Snake.S_Direct == 1 && Direct == 2) || (C_Snake.S_Direct == 2 && Direct == 1)) return true;
            else if ((C_Snake.S_Direct == 3 && Direct == 4) || (C_Snake.S_Direct == 4 && Direct == 3)) return true;
            else if (C_Snake.S_Direct == 0 && Direct == 2) return true;
            return false;
        }
    }

    

    
}
