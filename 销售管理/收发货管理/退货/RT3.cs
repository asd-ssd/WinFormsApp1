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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.销售管理.收发货管理.退货
{
    public partial class RT3 : Form
    {
        public DataGridView dataGridView1 = ReturnForm.returnForm.dataGridView1;
        public RT3()
        {
            InitializeComponent();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=xlh;Persist Security Info=True;User ID=xlh;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 退货单 where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 退回编号 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 仓库编号 like'%" + textBox2.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 收货人 like'%" + textBox3.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsql += "and 出库单据 like'%" + textBox4.Text + "%'";
            }
            if (textBox5.Text != "")
            {
                selectsql += "and 客户编号 like'%" + textBox4.Text + "%'";
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
    }
}
