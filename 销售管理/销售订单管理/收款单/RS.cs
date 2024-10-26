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
using WinFormsApp1.销售管理.收发货管理.退货;

namespace WinFormsApp1.销售管理.销售订单管理.收款单
{
    public partial class RS : Form
    {
        private int n;
        private string[] strcomm;
        private string RTselect_item_number1;
        private string RTselect_item_number2;
        private string RTselect_item_number3;
        public TextBox RTselect_people_textBox5 = Receipt2nd.receipt2Nd.textBox5;//订单
        public TextBox RTselect_people_textBox4 = Receipt2nd.receipt2Nd.textBox4;//金额
        public TextBox RTselect_people_textBox3 = Receipt2nd.receipt2Nd.textBox3;//客户
        public RS()
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
                string strda = "select * from 订单审核通过表";
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
            string selectsql = "select * from 订单审核通过表 where 1=1";
            /*if (textBox1.Text != "")
            {
                selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
            }*/
            if (textBox1.Text != "")
            {
                selectsql += "and 订单编号 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 总价 like'%" + textBox2.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 客户 like'%" + textBox3.Text + "%'";
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
            RTselect_people_textBox5.Text = RTselect_item_number1;
            RTselect_people_textBox4.Text = RTselect_item_number2;
            RTselect_people_textBox3.Text = RTselect_item_number3;
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void RS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RTselect_item_number1 = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
            RTselect_item_number2 = dataGridView1.Rows[e.RowIndex].Cells["总价"].Value.ToString();
            RTselect_item_number3 = dataGridView1.Rows[e.RowIndex].Cells["客户"].Value.ToString();
        }
    }
}
