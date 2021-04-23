using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage2._0
{
    interface OrderService
    {
        void addOrder();
        void removeOrder();
        void searchOrder(int i);
        void export();
        void import();
    }
}
