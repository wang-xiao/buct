using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace knowworld
{
    class Program
    {
        private string firstname;

        public string Firstname   //由变量firstname封装字段而来
        {
            get { return firstname; }
            set { firstname = value; }
        }
        static void Main(string[] args)
        {
            ArrayList productcode = new ArrayList();
            productcode.Add("ABC");
            productcode.Add(1);

            Console.WriteLine(productcode[0]);   //泛型ArrayList-->string无需手动转换
            Console.WriteLine(productcode[1]);

            Dictionary<int,string> flowers = new Dictionary<int,string>();  //Dictionary是键与值的集合，类似于页表结构
            class ObjectUtil<T> where T:IComparable   //类型限制
            {

            }
        }

        
    }

    public class ff_test
    {
       
    }

    interface ff_if  //接口并不是对应于类而言，相反，它和类是同一个等级的，类似于c++中.h的作用
    {

    }
    public class CanonDriver:ff_test
    {

    }

    
}
