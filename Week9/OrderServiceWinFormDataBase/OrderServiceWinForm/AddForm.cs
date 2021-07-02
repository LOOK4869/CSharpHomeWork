using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrderServiceWinForm
{
    public partial class AddForm : Form
    {
        Form mainw;
        Dictionary<string, OrderDetails> OrderDic2 = new Dictionary<string, OrderDetails>();
        public AddForm(Form1 form1)
        {
            mainw = form1;
            
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
            //if (OrderDic2.ContainsKey(textBoxname.Text))
            //{
            //    MessageBox.Show("您要添加的订单存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //OrderDetails o = new OrderDetails();
            //o.Number = Convert.ToInt32(textBoxnumber.Text);
            //o.Name = textBoxname.Text;
            //o.Price = Convert.ToInt32(textBoxprice.Text);
            //OrderDic2.Add(o.Name, o);

            string constr = "server=localhost;user id=root;password=aptx4869;database=db_order;SslMode=none";
            //设置连接字符串
            MySqlConnection mycon = new MySqlConnection(constr);  //实例化连接对象
            mycon.Open();
            string s1 = "insert into table_order values (" + textBoxnumber.Text + ", '" + textBoxname.Text + "', " + textBoxprice.Text +  ")";
            MySqlCommand cmd = new MySqlCommand(s1, mycon);
            cmd.ExecuteNonQuery();
            mycon.Close();
            mainw.Show();
            this.Close();

        }
    }
}
