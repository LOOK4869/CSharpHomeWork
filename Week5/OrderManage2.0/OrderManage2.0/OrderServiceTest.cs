using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage2._0
{
    public class OrderServiceTest
    {
        AllOrder a = new AllOrder();

        public void addorderTest()
        {
            a.addOrder();
            if (a != null)
            {
                Console.WriteLine("添加订单成功");
            }
            else
            {
                Console.WriteLine("未成功添加订单");
            }

        }

        public void removeorderTest()
        {
            a.removeOrder();
            if (a == null)
            {
                Console.WriteLine("删除订单成功");
            }
            else
            {
                Console.WriteLine("未成功删除订单");
            }
        }
        public void searchorderTest()
        {
            a.searchOrder(2);
        }

        public void exportTest()
        {
            a.addOrder();
            a.export();
        }
        public void importTest()
        {
            a.import();
        }

    }
}
