using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumArea = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("第"+(i+1)+"个图形是：");
                // Console.WriteLine("1.长方形");
                // Console.WriteLine("2.正方形");
                // Console.WriteLine("3.三角形");
                // string s = Console.ReadLine();
                Random rd = new Random(i);
                int s = rd.Next(0, 3);
                Shape shape = null;

                if (s == 0)
                {
                    /*
                     double h;
                     double w;
                     Console.WriteLine("请输入长方形的高");
                     h = Convert.ToDouble(Console.ReadLine());
                     Console.WriteLine("请输入长方形的宽");
                     w = Convert.ToDouble(Console.ReadLine());
                     Rectangle r = new Rectangle(w, h);
                     double a = r.GetArea();
                     Console.WriteLine("长方形的面积是：" + a);
                    */
                    shape  = new Rectangle(rd.NextDouble() + rd.Next(1, 10), rd.NextDouble() + rd.Next(1, 10));
                    Console.WriteLine("长方形");
                    sumArea += shape.GetArea();
                    Console.WriteLine("这个图形的面积是：" + shape.GetArea());
                    Console.WriteLine("目前图形面积总和为" + sumArea);
                }
                else if (s == 1)
                {
                    /*
                    double a;
                    Console.WriteLine("请输入正方形的边长");
                    a = Convert.ToDouble(Console.ReadLine());
                    Square sq = new Square(a);
                    double sa = sq.GetArea();
                    Console.WriteLine("正方形的面积是：" + sa);
                */
                    shape = new Square(rd.NextDouble() + rd.Next(1, 10));
                    Console.WriteLine("正方形");
                    sumArea += shape.GetArea();
                    Console.WriteLine("这个图形的面积是：" + shape.GetArea());
                    Console.WriteLine("目前图形面积总和为" + sumArea);
                }
                else if (s == 2)
                {
                    /*
                    double h;
                    double t;
                    Console.WriteLine("请输入三角形的底长");
                    t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("请输入三角形的高");
                    h = Convert.ToDouble(Console.ReadLine());
                    Triangle r = new Triangle(t, h);
                    double a = r.GetArea();
                    Console.WriteLine("三角形的面积是：" + a);
                    */
                    shape = new Triangle(rd.NextDouble() + rd.Next(1, 10), rd.NextDouble() + rd.Next(1, 10));
                    Console.WriteLine("三角形");
                    sumArea += shape.GetArea();
                    Console.WriteLine("这个图形的面积是：" + shape.GetArea());
                    Console.WriteLine("目前图形面积总和为" + sumArea);

                }
                else
                {
                    Console.WriteLine("随机数生成出现问题");
                    // Console.WriteLine("请输入上述图形的序号来选择");
                }

            }
            Console.ReadKey();
        }
    }

    public interface Shape
    {


        double GetArea();

    }

    class Rectangle : Shape
    {
        public double width;
        public double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

        }

        public double GetArea()
        {
            return width * height;
        }
    }

    class Triangle : Shape
    {
        public double bottom;
        public double height;
        public Triangle(double bottom, double height)
        {
            this.bottom = bottom;
            this.height = height;

        }

        public double GetArea()
        {
            return bottom * height / 2;
        }


    }
    class Square : Shape
    {
        public double length;
        public Square(double length)
        {
            this.length = length;

        }

        public double GetArea()
        {
            return length * length;
        }
    
    }
}
