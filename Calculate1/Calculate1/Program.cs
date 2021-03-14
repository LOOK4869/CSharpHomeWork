using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            string a = Console.ReadLine();
            double c = Convert.ToDouble(a);
            Console.WriteLine("请输入第二个数字：");
            string b = Console.ReadLine();
            double d = Convert.ToDouble(b);
            Console.WriteLine("请输入运算符：");
            string e = Console.ReadLine();
            double result;
            if (e == "+")
            {
                 result = c + d;
                Console.WriteLine("运算结果是：" + result);
            }
            else if(e=="-")
            {
               result = c - d;
                Console.WriteLine("运算结果是：" + result);
            }
            else if (e == "*")
            {
                result = c * d;
                Console.WriteLine("运算结果是：" + result);
            }
            else if (e == "/")
            {
                result = c / d;
                Console.WriteLine("运算结果是：" + result);
            }
            else if (e == "%")
            {
                result = c % d;
                Console.WriteLine("运算结果是：" + result);
            }
            else 
            {
                Console.WriteLine("没有这个运算符");
            }

            Console.ReadKey();




        }
    }
}
