using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.销售管理.销售订单管理.收款单
{
    public partial class ReceiptSearch : Form
    {
        public DataGridView rfdataGridView1 = ReceiptForm.receiptForm.rfdataGridView1;
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=xlh;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        public ReceiptSearch()
        {
            InitializeComponent();
        }

        private void r2save_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 收款单 where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 收款单编号 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 客户 like'%" + textBox2.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 收款人 like'%" + textBox3.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsql += "and 收款金额 like'%" + textBox4.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsql += "and 订单编号 like'%" + textBox4.Text + "%'";
            }


            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt);
            conn.Close();
            rfdataGridView1.DataSource = dt;
            MessageBox.Show("查询成功！");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前查询未完成，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ReceiptSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
