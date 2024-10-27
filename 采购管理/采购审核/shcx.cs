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
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using WinFormsApp1.采购管理.采购;

namespace WinFormsApp1.采购管理.采购审核
{
    public partial class shcx : Form
    {
        public DataGridView dataGridView2 = shx.shx1.dataGridView2;
        public DataGridView dataGridView1 = shx.shx1.dataGridView1;
        public shcx()
        {
            InitializeComponent();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 审核表 where 1=1";
            string selectsq2 = "select * from 驳回表 where 1=1";
            if (textBox10.Text != "")
            {
                selectsql += "and 订单编号 like'%" + textBox10.Text + "%'";
            }
            if (textBox1.Text != "")
            {
                selectsql += "and 申请人员 like'%" + textBox1.Text + "%'";
            }
            if (textBox9.Text != "")
            {
                selectsql += "and 员工编码 like'%" + textBox9.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 采购商品 like'%" + textBox3.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsql += "and 商品编码 like'%" + textBox4.Text + "%'";
            }
            if (textBox7.Text != "")
            {
                selectsql += "and 供应商 like'%" + textBox7.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 审核人员 like'%" + textBox2.Text + "%'";
            }
            if (textBox8.Text != "")
            {
                selectsql += "and 审核编码 like'%" + textBox8.Text + "%'";
            }



            if (textBox10.Text != "")
            {
                selectsq2 += "and 订单编号 like'%" + textBox10.Text + "%'";
            }
            if (textBox1.Text != "")
            {
                selectsq2 += "and 申请人员 like'%" + textBox1.Text + "%'";
            }
            if (textBox9.Text != "")
            {
                selectsq2 += "and 员工编码 like'%" + textBox9.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsq2 += "and 采购商品 like'%" + textBox3.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsq2 += "and 商品编码 like'%" + textBox4.Text + "%'";
            }
            if (textBox7.Text != "")
            {
                selectsq2 += "and 供应商 like'%" + textBox7.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsq2 += "and 审核人员 like'%" + textBox2.Text + "%'";
            }
            if (textBox8.Text != "")
            {
                selectsq2 += "and 审核编码 like'%" + textBox8.Text + "%'";
            }




            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt);
            conn.Close();
            dataGridView2.DataSource = dt;
            dataGridView1.DataSource = dt;
            MessageBox.Show("查询成功！");
            this.Close();
            SysLogService.AddSysLog(new SysLog("查询审核表数据", "触发", LogTye.操作记录, login.login1.userid));
            SysLogService.AddSysLog(new SysLog("查询驳回表数据", "触发", LogTye.操作记录, login.login1.userid));
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
