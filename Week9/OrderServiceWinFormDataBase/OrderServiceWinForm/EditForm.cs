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
    public partial class EditForm : Form
    {
        Form mainw;
        
        public EditForm(Form form1)
        {
            mainw = form1;
          
            
            InitializeComponent();
            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            mainw.Show();
            this.Close();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            //if (!OrderDic2.ContainsKey(textBoxQuery.Text))
            //{
            //    MessageBox.Show("您要修改的订单不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //OrderDetails o = OrderDic2[textBoxQuery.Text];
            //o.Name = textBoxname.Text;
            //o.Price= Convert.ToDouble( textBoxprice.Text);
            string constr = "server=localhost;user id=root;password=aptx4869;database=db_order;SslMode=none";
            //设置连接字符串
            MySqlConnection mycon = new MySqlConnection(constr);  //实例化连接对象
            mycon.Open();
            string s1 = "update table_order set name = '" + textBoxname.Text + "' where name = '" + textBoxQuery.Text + "'";
            string s2 = "update table_order set price = '" + textBoxprice.Text + "' where name = '" + textBoxQuery.Text + "'";
            MySqlCommand cmd1 = new MySqlCommand(s1, mycon);
            cmd1.ExecuteNonQuery();
            MySqlCommand cmd2 = new MySqlCommand(s2, mycon);
            cmd2.ExecuteNonQuery();
            mycon.Close();
            mainw.Show();
            this.Close();
        }
    }
}
