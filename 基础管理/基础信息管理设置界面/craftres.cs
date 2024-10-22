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
using WinFormsApp1.基础信息管理工作界面;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class craftres : Form
    {
        public DataGridView dataGridView1 = craftplat.craftplat1.dataGridView2;
        public craftres()
        {
            InitializeComponent();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 工艺路线表 where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 工序 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 工序名称 like'%" + textBox2.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 工作中心编号 like'%" + textBox3.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsql += "and 工作中心名称 like'%" + textBox4.Text + "%'";
            }
            if (textBox5.Text != "")
            {
                selectsql += "and 准备时间 like'%" + textBox5.Text + "%'";
            }
            if (textBox6.Text != "")
            {
                selectsql += "and 加工时间 like'%" + textBox6.Text + "%'";
            }
            if (textBox7.Text != "")
            {
                selectsql += "and 机器台时 like'%" + textBox7.Text + "%'";
            }
            if (textBox8.Text != "")
            {
                selectsql += "and [排队时间（天）] like'%" + textBox8.Text + "%'";
            }
            if (textBox9.Text != "")
            {
                selectsql += "and [传送时间（天）] like'%" + textBox9.Text + "%'";
            }
            if (textBox10.Text != "")
            {
                selectsql += "and 准备工人数 like'%" + textBox10.Text + "%'";
            }
            if (textBox11.Text != "")
            {
                selectsql += "and 加工工人数 like'%" + textBox11.Text + "%'";
            }
            if (textBox12.Text != "")
            {
                selectsql += "and 外协费 like'%" + textBox12.Text + "%'";
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
