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
    public partial class OSItem : Form
    {
        private int n;
        private string[] strcomm;
        private string RTselect_people_number4;
        private string RTselect_people_number6;
        private string RTselect_people_number10;
        public TextBox RTselect_people_textBox4 = Order2nd.order2Nd.textBox4;
        public TextBox RTselect_people_textBox6 = Order2nd.order2Nd.textBox6;
        public TextBox RTselect_people_textBox10 = Order2nd.order2Nd.textBox10;

        public OSItem()
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
                string strda = "select * from BOM表";
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
            string selectsql = "select * from BOM表 where 1=1";
            /*if (textBox1.Text != "")
            {
                selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
            }*/
            if (textBox1.Text != "")
            {
                selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 物料编码 like'%" + textBox1.Text + "%'";
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
            RTselect_people_textBox4.Text = RTselect_people_number4;
            RTselect_people_textBox6.Text = RTselect_people_number6;
            RTselect_people_textBox10.Text = RTselect_people_number10;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RTselect_people_number4 = dataGridView1.Rows[e.RowIndex].Cells["物料名称"].Value.ToString();
            RTselect_people_number6 = dataGridView1.Rows[e.RowIndex].Cells["单价"].Value.ToString();
            RTselect_people_number10 = dataGridView1.Rows[e.RowIndex].Cells["物料编码"].Value.ToString();
        }

        private void OSItem_Load(object sender, EventArgs e)
        {

        }
    }
}
