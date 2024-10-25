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

    public partial class xjy : Form
    {
        public DataGridView dataGridView1 = gys.gys1.dataGridView1;
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=zyx;Persist Security Info=True;User ID=zyx;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 供应商表";
                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strda, conn);
                da.Fill(dt);
                conn.Close();
                //dataGridView1.AutoGenerateColumns = true;//自动创建列
                //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        public xjy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 供应商表(供应商名称,地址,联系人,联系方式,供应商类型,评级,备注) values('" + textBox7.Text + "','" + textBox1.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedIndex + "','" + comboBox2.SelectedIndex + "','" + textBox4.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("添加成功!");
            this.Close();
        }

        private void xjy_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
