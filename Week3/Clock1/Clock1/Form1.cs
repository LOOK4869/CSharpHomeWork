using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock1
{
    public partial class Form1 : Form
    {
        DateTime m_TodayDate;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            for(int i=0;i<lstList.Items.Count; i++)
            {
                if(m_TodayDate .ToString("yyyyMMdd") != DateTime.Now.ToString("yyyyMMdd"))
                {
                    for (int n = 0; n < lstList.Items.Count; n++)
                    {
                        lstList.Items[i].SubItems[2].Text = "";
                    }
                    m_TodayDate = DateTime.Now;
                }
                if(DateTime.Parse(lstList.Items[i].SubItems[0].Text) <= DateTime.Now)
                {
                    if(lstList.Items[i].SubItems[2].Text != "Y")
                    {
                        lstList.Items[i].SubItems[2].Text = "Y";
                        MessageBox.Show(lstList.Items[i].SubItems[1].Text);
                    }
                   
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( txtmsg .Text.Trim ().Replace(" ","") =="")
            {
                return;
            }
            ListViewItem listItem = lstList.Items.Add(dtboxTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            listItem.SubItems.Add(txtmsg.Text);
            listItem.SubItems.Add("");
            txtmsg.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtboxTime.Value = DateTime.Now;
            timer2.Enabled = true;
            m_TodayDate = DateTime.Now;
        }
    }
}
