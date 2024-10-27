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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1.采购管理.采购
{

    public partial class cgcxy : Form
    {
        public DataGridView dataGridView1 = cgsqy.cgsqy1.dataGridView1;
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        public cgcxy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private DateTimePicker GetDateTimePicker1()
        //{
        //    return dateTimePicker1;
       // }
        //private void button2_Click(object sender, EventArgs e, DateTimePicker dateTimePicker1)
        // {
        //    if (dateTimePicker1.Value != "")
        //    {
        //    }
        // }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 采购表 where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 申请人员 like'%" + textBox1.Text + "%'";
            }
            if (textBox8.Text != "")
            {
                selectsql += "and 员工编号 like'%" + textBox8.Text + "%'";
            }
            if (textBox9.Text != "")
            {
                selectsql += "and 商品编号 like'%" + textBox9.Text + "%'";
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
            dataGridView1.DataSource = dt;
            MessageBox.Show("查询成功！");
            this.Close();
            SysLogService.AddSysLog(new SysLog("查询采购表数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void cgcxy_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
