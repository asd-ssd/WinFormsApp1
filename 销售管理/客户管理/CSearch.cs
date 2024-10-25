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
using WinFormsApp1.工作界面;

namespace WinFormsApp1.销售管理.客户管理
{
    public partial class CSearch : Form
    {
        public DataGridView dataGridView1 = clientform.Clientform.dataGridView1;

        public CSearch()
        {
            InitializeComponent();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=xlh;Persist Security Info=True;User ID=xlh;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        private void cs_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 客户 where 1=1";
            if (c12textBox1.Text != "")
            {
                selectsql += "and 客户编号 like'%" + c12textBox1.Text + "%'";
            }
            if (c12textBox2.Text != "")
            {
                selectsql += "and 客户名称 like'%" + c12textBox2.Text + "%'";
            }
            if (c12textBox3.Text != "")
            {
                selectsql += "and 联系电话 like'%" + c12textBox3.Text + "%'";
            }
            if (c12textBox4.Text != "")
            {
                selectsql += "and 公司电话 like'%" + c12textBox4.Text + "%'";
            }
            if (c12textBox5.Text != "")
            {
                selectsql += "and 地址 like'%" + c12textBox5.Text + "%'";
            }

            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            MessageBox.Show("查询成功！");
            this.Close();
        }

        private void cscancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前查询未完成，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
