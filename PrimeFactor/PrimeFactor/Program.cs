using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要求素数因子的数字：");
            long n = Convert.ToInt64(Console.ReadLine());
            getfactor(n);
            Console.ReadKey();
        }

        //primo方法判断x是不是素数
        static private bool primo(long x)
        {
            bool sp = true;
            for(long i = 2; 1 <= x / 2; i++)
            {
                if (x % i == 0)
                    sp = false;
            }
            return sp;
        }

        //得到数字的所有素数因数
        static private void getfactor(long n)
        {
            long sqt = (long)Math.Sqrt(n);
            for(int i = 2; i <= sqt; i++)
            {
                if (n % i == 0 && primo(i))
                    Console.WriteLine(i);
            }
            if (primo(n))
                Console.WriteLine(n);

        }
    }
}
