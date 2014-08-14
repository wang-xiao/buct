using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace FF_test02
{
    
    class F_struct
    {
        public int x, y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<F_struct> l1 = new List<F_struct>();

            int i = 0;
            F_struct fs = new F_struct();
            for(i=0;i<5;i++)
            {
                fs = new F_struct();    //你你你你你！！！！妹啊！！！！！
                fs.x = i;
                fs.y = i + 2;
                l1.Add(fs);
            }

            Console.WriteLine(l1[0].x);
            Console.WriteLine(l1.Count());
            for(i=0;i<l1.Count();i++)
            {
                Console.WriteLine("{0} {1}", l1[i].x, l1[i].y);
            }
        }
        

    }
}
