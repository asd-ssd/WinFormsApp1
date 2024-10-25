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
using WinFormsApp1.采购管理.采购;

namespace WinFormsApp1.采购管理.采购审核
{
    public partial class shcx : Form
    {
        public DataGridView dataGridView2 = shx.shx1.dataGridView2;
        public shcx()
        {
            InitializeComponent();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=zyx;Persist Security Info=True;User ID=zyx;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 审核表 where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 申请人员 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 审核人员 like'%" + textBox2.Text + "%'";
            }
            if (textBox8.Text != "")
            {
                selectsql += "and 审核 like'%" + textBox8.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 采购商品 like'%" + textBox3.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsql += "and 商品单价 like'%" + textBox4.Text + "%'";
            }
            if (textBox5.Text != "")
            {
                selectsql += "and 采购数量 like'%" + textBox5.Text + "%'";
            }
            if (textBox6.Text != "")
            {
                selectsql += "and 采购总价 like'%" + textBox6.Text + "%'";
            }
            if (textBox7.Text != "")
            {
                selectsql += "and 供应商 like'%" + textBox7.Text + "%'";
            }


            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt);
            conn.Close();
            dataGridView2.DataSource = dt;
            MessageBox.Show("查询成功！");
            this.Close();
        }

        private void shcx_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
