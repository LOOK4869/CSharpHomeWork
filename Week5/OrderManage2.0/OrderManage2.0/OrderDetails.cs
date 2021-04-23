using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage2._0
{
    class OrderDetails
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value >= 0) number = value;
                else Console.WriteLine("数量不能小于0");
            }
        }
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public OrderDetails()
        {
            this.Name = string.Empty;
            this.Number = 0;
            this.Price = 0;
        }

        public OrderDetails(string name, int number, double price)
        {
            this.name = name;
            this.number = number;
            this.price = price;
        }
        public double getPrice()
        {
            return this.number * this.price;
        }
    }
}
