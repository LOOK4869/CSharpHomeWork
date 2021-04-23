using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class Program
    {
        static void Main(string[] args)
        {
            AllOrder a = new AllOrder(); 
            bool judge = true;
            while (judge)
            {
                Console.WriteLine("输入1增加订单，输入2删除订单，输入3查询订单，输入4显示所有订单，输入5根据订单号为订单排序，输入6退出");
                string choose1 = Console.ReadLine();
                switch (choose1)
                {
                    case "1": a.addOrder(); break;
                    case "2": a.removeOrder(); break;
                    case "3": Console.WriteLine("输入1根据订单金额查询订单，输入2根据客户名查询订单"); int i = Convert.ToInt32(Console.ReadLine()); a.searchOrder(i); break;
                    case "4": a.ShowOrder(); break;
                    case "5": a.order.Sort(); break;
                    case "6": judge = false; break;
                    default: Console.WriteLine("输入错误"); break;
                }
            }

        }
    }
}
