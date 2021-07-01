using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderServiceWinForm
{
    public partial class AddForm : Form
    {
        Form mainw;
        Dictionary<string, OrderDetails> OrderDic2 = new Dictionary<string, OrderDetails>();
        public AddForm(Form1 form1,Dictionary<string, OrderDetails> dic)
        {
            mainw = form1;
            OrderDic2 = dic;
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            mainw.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OrderDic2.ContainsKey(textBoxname.Text))
            {
                MessageBox.Show("您要添加的订单存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OrderDetails o = new OrderDetails();
            o.Number = Convert.ToInt32(textBoxnumber.Text);
            o.Name = textBoxname.Text;
            o.Price = Convert.ToInt32(textBoxprice.Text);
            OrderDic2.Add(o.Name, o);
            mainw.Show();
            this.Close();

        }
    }
}
