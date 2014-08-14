using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace recognize_world
{
    class Program
    {
        static void Main(string[] args)
        {
            P p = new P();
            p.whatami();
            System.Threading.Thread.Sleep(500);
            C c = new C();
            c.whatami();
            c.write();

            ND nd = new ND();
            nd.test();

            float floatvalue = 2e3f;
            Console.WriteLine(floatvalue.ToString());
        }
    }


    class P  //子类的复杂程度一定>=父类，即向上转换时，即使不丢失数据，也会导致某些子类作用域函数于父类引用变量无法使用
    {        //向下转换之前，父类必须先引用子类
        internal void InteralMethod()
        {

        }
        public void whatami()
        {
            Console.WriteLine("I am a shape");
        }

        public string returnstring()
        {
            return "This is class P";
        }
    }

    class C:P
    {
        public void TestMethod()
        {
            InteralMethod();
        }
        new public void whatami()
        {
            Console.WriteLine("I am a oval");
        }

        new public string returnstring()
        {
            return "This is class C";
        }
        public void write()
        {
            Console.WriteLine(base.returnstring());

            Console.WriteLine(returnstring());
        }

    }

    class ND
    {
        public void test()
        {
            string input = Console.ReadLine();  //接受键盘（缓存）
            try
            {
                Byte number = Byte.Parse(input);  //类型转换：string-->Byte
                Console.WriteLine("Result:{0}",2*number);
            }
            catch(FormatException e)  //类型不匹配,接收错误后，除了显示程序员所要求的字符串，还会显示堆栈跟踪记录
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine(e.StackTrace);
            }
            catch(OverflowException)  //出界
            {
                Console.WriteLine("The number you entered exceeded");
            }

        }
    }
}
