using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {1,5,7,4,9,12,34,15,16,67,128 };
            Console.WriteLine("数组内包含的数字是：");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
            Console.WriteLine("其中的最小值是："+ Min(a));
            Console.WriteLine("其中的最大值是："+ Max(a));
            Console.WriteLine("数字的总和是："+ Sum(a));
            Console.WriteLine("数字的平均值是："+ Sum(a)/a.Length);
            Console.ReadKey();
        }

        //求最小值
        public static int Min(int[] array)
        {
            if (array == null) throw new Exception("数组空异常");
            int value = 0;
            bool hasValue = false;
            foreach(int x in array)
            {
                if (hasValue)
                {
                    if (x < value)
                        value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue)
                return value;
            throw new Exception("没找到");
        }

        //求最大值
        public static int Max(int[] array)
        {
            if (array == null) throw new Exception("数组空异常");
            int value = 0;
            bool hasValue = false;
            foreach (int x in array)
            {
                if (hasValue)
                {
                    if (x > value)
                        value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue)
                return value;
            throw new Exception("没找到");
        }
        //求总和
        public static double Sum(int [] array)
        {
            int sum = 0;
            checked
            {
                foreach(int  v in array)
                {
                    if (v != null)
                    {
                        sum += v;
                    }
                }
            }
         
                return sum;

        }
    }
}
