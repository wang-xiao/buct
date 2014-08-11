using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF_snake02
{
    
    class S_body
    {
        public int x, y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
    }
    class Snake
    {
        List<S_body> snake;
        S_body laststep;
        public int S_Direct;
        public Snake()
        {
            snake = new List<S_body>();
            laststep = new S_body();

            int i;
            
            for(i=0;i<3;i++)
            {
                S_body s1 = new S_body();
                s1.Y = 150 + i * 30;
                s1.X = 210;
                snake.Add(s1);
            }
        }

         public List<S_body> GetSnake()
        {
            return snake;
        }

        public S_body GetStep()
         {
             return laststep;
         }

        public bool Move()
        {
            if(S_Direct==0)
            return false;

            laststep = new S_body();
            laststep.x = snake[snake.Count() - 1].x;
            laststep.y = snake[snake.Count() - 1].y;
            int i;
            for (i = snake.Count() - 1; i > 0;i-- )
            {
                snake[i].x = snake[i - 1].x;
                snake[i].y = snake[i - 1].y;
            }
            switch(S_Direct)
            {
                case 1: snake[0].y -= 30; break;
                case 2: snake[0].y += 30; break;
                case 3: snake[0].x -= 30; break;
                case 4: snake[0].x += 30; break;                    
            }
                return false;
        }
    }

}
