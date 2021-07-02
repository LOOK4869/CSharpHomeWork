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
    public partial class Form1 : Form
    {

/*
        Dictionary<string, OrderDetails> OrderDic = new Dictionary<string, OrderDetails>();
        private void FillGrid(Dictionary<string, OrderDetails> dic)
        {
            //string constr = "server=localhost;user id=root;password=aptx4869;database=db_order;SslMode=none";
            ////设置连接字符串
            //MySqlConnection mycon = new MySqlConnection(constr);  //实例化连接对象
            //mycon.Open();


            if (dataGridViewOrder.ColumnCount == 0)
            {
                DataGridViewTextBoxColumn col_number = new DataGridViewTextBoxColumn();
                col_number.HeaderText = "订单编号";//设置标题
                col_number.DataPropertyName = "Number";//设置数据绑定文本
                col_number.Name = "number";//设置该列名字
                
                DataGridViewTextBoxColumn col_name = new DataGridViewTextBoxColumn();
                col_name.HeaderText = "商品名称";//设置标题
                col_name.DataPropertyName = "Name";//设置数据绑定文本
                col_name.Name = "name";//设置该列名字

                DataGridViewTextBoxColumn col_price = new DataGridViewTextBoxColumn();
                col_price.HeaderText = "商品价格";//设置标题
                col_price.DataPropertyName = "Price";//设置数据绑定文本
                col_price.Name = "price";//设置该列名字

                //向数据网络控件中加入我们刚才定义的列
                dataGridViewOrder.Columns.Add(col_number);
                dataGridViewOrder.Columns.Add(col_name);
                dataGridViewOrder.Columns.Add(col_price);

            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dic.Values;
            dataGridViewOrder.DataSource = bs;
        }
*/
        public Form1()
        {
            InitializeComponent();
            //this.Text = "订单管理系统";
            //OrderDetails order1 = new OrderDetails("巧克力", 001, 3);
            //OrderDetails order2 = new OrderDetails("香蕉", 002, 1);

            //OrderDic.Add(order1.Name, order1);
            //OrderDic.Add(order2.Name, order2);

            //FillGrid(OrderDic);
            string constr = "server=localhost;user id=root;password=aptx4869;database=db_order;SslMode=none";
            //设置连接字符串
            MySqlConnection mycon = new MySqlConnection(constr);  //实例化连接对象
            mycon.Open();
            MySqlCommand mycom = mycon.CreateCommand();         //创建SQL命令执行对象
            string s1 = "select* from table_order";                                            //编写SQL命令
            DataSet myDS = new DataSet();
            mycom.CommandText = s1;                           //执行SQL命令
            MySqlDataAdapter myDA = new MySqlDataAdapter();       //实例化数据适配器
            myDA.SelectCommand = mycom;                       //让适配器执行SELECT命令
                                                              //实例化结果数据集
            myDA.Fill(myDS, "event");              //将结果放入数据适配器，返回元祖个数
            dataGridViewOrder.DataSource = myDS.Tables["event"];

            mycon.Close();

        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }
           
        //查询数据的方法
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            string constr = "server=localhost;user id=root;password=aptx4869;database=db_order;SslMode=none";
            //设置连接字符串
            MySqlConnection mycon = new MySqlConnection(constr);  //实例化连接对象
            mycon.Open();
            MySqlCommand mycom = mycon.CreateCommand();         //创建SQL命令执行对象
            string s1 = "select* from table_order where name='" + textBoxQuery.Text + "'";                                            //编写SQL命令
            DataSet myDS = new DataSet();
            mycom.CommandText = s1;                           //执行SQL命令
            MySqlDataAdapter myDA = new MySqlDataAdapter();       //实例化数据适配器
            myDA.SelectCommand = mycom;                       //让适配器执行SELECT命令
                                                              //实例化结果数据集
            myDA.Fill(myDS, "event");              //将结果放入数据适配器，返回元祖个数
            dataGridViewOrder.DataSource = myDS.Tables["event"];

            mycon.Close();

            //if (textBoxQuery.Text == "")
            //{
            //    FillGrid(OrderDic);
            //    return;
            //}
            ////若找不到用户要查询的订单，则弹出错误提示
            //if (!OrderDic.ContainsKey(textBoxQuery.Text))
            //{
            //    MessageBox.Show("查无此订单", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //OrderDetails o = OrderDic[textBoxQuery.Text];//找出对应的订单信息
            //Dictionary<string, OrderDetails> dic = new Dictionary<string, OrderDetails>();
            //dic.Add(o.Name, o);
            //FillGrid(dic);
        }

        //信息删除的方法
        private void buttonDele_Click(object sender, EventArgs e)
        {
            //if (!OrderDic.ContainsKey(textBoxQuery.Text))
            //{
            //    MessageBox.Show("您要删除的订单不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //OrderDic.Remove(textBoxQuery.Text);
            //return;

            string constr = "server=localhost;user id=root;password=aptx4869;database=db_order;SslMode=none";
            //设置连接字符串
            MySqlConnection mycon = new MySqlConnection(constr);  //实例化连接对象
            mycon.Open();
            string s1 = "delete from table_order where name='" + textBoxQuery.Text + "'";

            MySqlCommand cmd = new MySqlCommand(s1, mycon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("删除成功");

            mycon.Close();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditForm ed = new EditForm(this);
            ed.ShowDialog();
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm ad = new AddForm(this);
            ad.ShowDialog();
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
