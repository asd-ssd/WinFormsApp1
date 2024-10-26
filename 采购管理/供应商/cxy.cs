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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.采购管理.供应商
{
    public partial class cxy : Form
    {
        public DataGridView dataGridView1 = gys.gys1.dataGridView1;
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        public cxy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cxy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 供应商表 where 1=1";
            if (textBox2.Text != "")
            {
                selectsql += "and 供应商编号 like'%" + textBox2.Text + "%'";
            }
            if (textBox1.Text != "")
            {
                selectsql += "and 地址 like'%" + textBox1.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 联系方式 like'%" + textBox3.Text + "%'";
            }
            if (textBox6.Text != "")
            {
                selectsql += "and 联系人 like'%" + textBox6.Text + "%'";
            }
            if (textBox7.Text != "")
            {
                selectsql += "and 供应商 like'%" + textBox7.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsql += "and 供应商类型 like'%" + textBox4.Text + "%'";
            }
            if (textBox5.Text != "")
            {
                selectsql += "and 评级 like'%" + textBox5.Text + "%'";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
