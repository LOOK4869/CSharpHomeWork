using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManage2._0
{
    class AllOrder : OrderService
    {
        public List<Order> order = new List<Order>();

        public AllOrder()
        {

        }

        public void export()
        {
            XmlSerializer a = new XmlSerializer(typeof(List<Order>));
            using(FileStream b=new FileStream("order.xml", FileMode.Create))
            {
                a.Serialize(b, this.order);
            }
            Console.WriteLine("序列化完成");
        }

        public void import()
        {
            try
            {
                XmlSerializer a = new XmlSerializer(typeof(List<Order>));
                using(FileStream b=new FileStream("order.xml", FileMode.Open))
                {
                    List<Order> c = (List<Order>)a.Deserialize(b);
                    Console.WriteLine("反序列化结果：");
                    foreach (Order d in c)
                    {
                        Console.WriteLine("订单号 客户 日期 总金额");
                        Console.WriteLine("{0} {1} {2} {3}", d.Id, d.Customer, d.Date, d.Money);
                        d.showOrderDetails();
                    }

                }
            }
            catch
            {
                Console.WriteLine("序列化系列操作错误");
            }

        }
        public void ShowOrder()
        {
            foreach (Order a in this.order)
            {
                Console.WriteLine("订单号 客户 日期 总金额");
                Console.WriteLine("{0} {1} {2} {3}", a.Id, a.Customer, a.Date, a.Money);
            }

        }
        public void addOrder()
        {
            try
            {
                Console.WriteLine("请输入订单编号：");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入客户名称：");
                string customer = Console.ReadLine();
                Console.WriteLine("请输入时间：");
                string date = Console.ReadLine();
                Order a = new Order(id, customer, date);
                Console.WriteLine("输入订单项");
                bool judge = true;
                bool same = false;
                foreach (Order m in this.order)
                {
                    if (m.Equals(a)) same = true;
                }
                if (same) Console.WriteLine("订单号重复");
                else
                {
                    while (judge && !same)
                    {
                        Console.WriteLine("请输入物品名称：");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入购买数量：");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入单价：");
                        double price = Convert.ToDouble(Console.ReadLine());
                        a.addOrderDetails(name, number, price);
                        Console.WriteLine("是否继续添加订单（是/否）：");
                        string x = Console.ReadLine();
                        if (x == "否") judge = false;
                        else if (x == "是") continue;
                        else if (x != "否" && x != "是")
                        {
                            Exception e = new Exception();
                            throw e;
                        }

                    }

                    order.Add(a);
                    a.getAllPrice();
                    Console.WriteLine("创建成功");
                }

            }
            catch
            {
                Console.WriteLine("输入错误");
            }
        }

        public void removeOrder()
        {
            try
            {
                Console.WriteLine("请输入需要进行删除操作的订单的订单号");
                int id = Convert.ToInt32(Console.ReadLine());
                int index = 0;
                foreach (Order a in this.order)
                {
                    if (a.Id == id) index = this.order.IndexOf(a);
                    Console.WriteLine("输入1删除订单，输入2继续删除订单明细");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1: this.order.RemoveAt(index); Console.WriteLine("删除成功"); break;
                        case 2: this.order[index].showOrderDetails(); this.order[index].RemoveOrderDetails(); break;
                        default: Console.WriteLine("输入错误"); break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
        }
        public void searchOrder(int i)
        {
            try
            {
                switch (i)
                {
                    case 1:
                        int minNum, maxNum;
                        Console.WriteLine("输入要查询的最小金额：");
                        minNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("输入要查询的最大金额：");
                        maxNum = Convert.ToInt32(Console.ReadLine());


                        var query1 = from s1 in order
                                     where maxNum > s1.Money
                                     orderby s1.Money
                                     select s1;
                        var query3 = from s3 in query1
                                     where s3.Money > minNum
                                     orderby s3.Money
                                     select s3;

                        List<Order> a1 = query3.ToList();

                        foreach (Order b1 in a1)
                        {
                            Console.WriteLine("订单号 客户 日期 总金额");
                            Console.WriteLine("{0} {1} {2} {3}", b1.Id, b1.Customer, b1.Date, b1.Money);
                            b1.showOrderDetails();
                        }

                        break;
                    case 2:
                        Console.WriteLine("输入客户名称：");
                        string name1 = Console.ReadLine();

                        var query2 = from s2 in order
                                     where s2.Customer == name1
                                     orderby s2.Money
                                     select s2;
                        List<Order> a2 = query2.ToList();

                        foreach (Order b2 in a2)
                        {
                            Console.WriteLine("订单号 客户 日期 总金额");
                            Console.WriteLine("{0} {1} {2} {3}", b2.Id, b2.Customer, b2.Date, b2.Money);
                            b2.showOrderDetails();
                        }
                        break;


                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
        }
    }
}
