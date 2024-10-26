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

namespace WinFormsApp1.销售管理.收发货管理.发货
{
    public partial class De3 : Form
    {
        public DataGridView dataGridView1 = Delievery.delievery.dataGridView1;

        public De3()
        {
            InitializeComponent();

        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=xlh;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 出库单表 where 1=1";
            
            if (textBox4.Text != "")
            {
                selectsql += "and 销售订单编号 like'%" + textBox4.Text + "%'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前查询未完成，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void De3_Load(object sender, EventArgs e)
        {

        }
    }
}
