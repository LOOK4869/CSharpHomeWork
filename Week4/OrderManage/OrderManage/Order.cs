using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class Order : IComparable
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public double Money { get; set; }
        public string Date { get; set; }

        public List<OrderDetails> orderDetails = new List<OrderDetails>();

        public Order()
        {
            this.Id = 0;
            this.Customer = string.Empty;
            this.Money = 0;
            this.Date = string.Empty;
        }

        public int CompareTo(object obj)
        {
            Order a = obj as Order;
            return this.Id.CompareTo(a.Id);

        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Id);
        }

        public Order(int id,string customer,string date)
        {
            this.Id = id;
            this.Customer = customer;
            this.Date = date;

        }
        public void getAllPrice()
        {
            double i = 0;
            foreach(OrderDetails a in this.orderDetails)
            {
                i = i + a.getPrice();
            }
            this.Money = i;
        }

        public void addOrderDetails(string name,int number,double price)
        {
            OrderDetails a = new OrderDetails(name, number, price);
            this.orderDetails.Add(a);
        }

        public void RemoveOrderDetails()
        {
            try
            {
                Console.WriteLine("请输入订单序号删除相应订单");
                int a = Convert.ToInt32(Console.ReadLine());
                this.orderDetails.RemoveAt(a);
                Console.WriteLine("删除成功");

            }catch
            {
                Console.WriteLine("未找到输入序号的订单");

            }
        }

        public void showOrderDetails()
        {
            Console.WriteLine("序号 名称 数量 单价");
            foreach (OrderDetails a in this.orderDetails)
            {
                Console.WriteLine("{0} {1} {2} {3}",this.orderDetails.IndexOf(a),a.Name,a.Number,a.Price);

            }
        }
       
    }
   

}
