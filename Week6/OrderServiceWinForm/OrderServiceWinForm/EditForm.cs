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
    public partial class EditForm : Form
    {
        Form mainw;
        Dictionary<string, OrderDetails> OrderDic2 = new Dictionary<string, OrderDetails>();
        public EditForm(Form form1,Dictionary<string,OrderDetails> dic)
        {
            mainw = form1;
          
            OrderDic2 = dic;
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
            if (!OrderDic2.ContainsKey(textBoxQuery.Text))
            {
                MessageBox.Show("您要修改的订单不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OrderDetails o = OrderDic2[textBoxQuery.Text];
            o.Name = textBoxname.Text;
            o.Price= Convert.ToDouble( textBoxprice.Text);
            mainw.Show();
            this.Close();
        }
    }
}
