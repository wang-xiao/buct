using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace hello_world_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1<<a;

            /*
            for (int i = 0; i < 3; i++)
            {
                switch(i)
                {
                    case 0: Console.WriteLine("0");
                        break;
                    case 1: Console.WriteLine("1");
                        break;
                    case 2: Console.WriteLine("2");
                        break;
                }
                Console.Beep();
               
                Thread.Sleep(500);
            }*/

            string s1 = "hello world!";    //C#中任何一样东西都需要对象
            s1=s1.ToUpper();  //返回值操作，需要变量接收
            Console.WriteLine(s1);

            string s2 = "string number" + 3;  //隐式类型转换
            Console.WriteLine(s2);

            string[] s3 = new string[10];  //string并非字符串，而是串类，这种声明方法表示此类由10个不连续的串类构成
            s3[0] = "a";
            //s3[1] = "bcdsef";
           // Console.Write(s3);

            Console.ReadKey();
            Console.ReadLine();

            

        }
    }
}

namespace ff_test
{
    class test01
    {
        public test01()
        {
           
        }
        public static void test02()
        {
             Console.WriteLine("1");
        }

    }

    class test2
    {

        public test2()
        {
           
        }

        public void test3()
        {
            test01.test02();
        }
    }

    
}


namespace ff_test2
{
    using ff_test;
    

    

}