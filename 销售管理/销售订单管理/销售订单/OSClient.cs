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

namespace WinFormsApp1.销售管理.销售订单管理.销售订单
{
    public partial class OSClient : Form
    {
        private int n;
        private string[] strcomm;
        private string RTselect_people_number;
        private string RTselect_people_number2;
        public TextBox RTselect_people_textBox2 = Order2nd.order2Nd.textBox2;
        public TextBox RTselect_people_textBox9 = Order2nd.order2Nd.textBox9;
        public OSClient()
        {
            InitializeComponent();
            GetDataGridView();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=xlh;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 客户";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 客户 where 1=1";
            /*if (textBox1.Text != "")
            {
                selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
            }*/
            if (textBox1.Text != "")
            {
                selectsql += "and 客户姓名 like'%" + textBox1.Text + "%'";
            }



            SqlConnection conn = connection();
            conn.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt1);
            conn.Close();
            dataGridView1.DataSource = dt1;
            MessageBox.Show("查询成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RTselect_people_textBox2.Text = RTselect_people_number;
            RTselect_people_textBox9.Text = RTselect_people_number2;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RTselect_people_number = dataGridView1.Rows[e.RowIndex].Cells["客户名称"].Value.ToString();
            RTselect_people_number2 = dataGridView1.Rows[e.RowIndex].Cells["地址"].Value.ToString();
        }

        private void OSClient_Load(object sender, EventArgs e)
        {

        }
    }
}
