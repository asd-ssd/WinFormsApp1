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

namespace WinFormsApp1.销售管理.销售订单管理.订单审批
{
    public partial class EXSerch : Form
    {
        private int n;
        private string[] strcomm;
        private string RTselect_people_number1;
        private string RTselect_people_number2;
        private string RTselect_people_number3;
        private string RTselect_people_number4;
       
        private string RTselect_people_number6;
        private string RTselect_people_number7;
        private string RTselect_people_number8;
        private string RTselect_people_number9;
        private string RTselect_people_number10;
        private string RTselect_people_number11;
        public TextBox RTselect_people_textBox1 = Examine2nd.examine2Nd.textBox1;
        public TextBox RTselect_people_textBox2 = Examine2nd.examine2Nd.textBox2;
        public TextBox RTselect_people_textBox3 = Examine2nd.examine2Nd.textBox3;
        public TextBox RTselect_people_textBox4 = Examine2nd.examine2Nd.textBox4;
        
        public TextBox RTselect_people_textBox6 = Examine2nd.examine2Nd.textBox6;
        public TextBox RTselect_people_textBox7 = Examine2nd.examine2Nd.textBox7;
        public TextBox RTselect_people_textBox8 = Examine2nd.examine2Nd.textBox8;
        public TextBox RTselect_people_textBox9 = Examine2nd.examine2Nd.textBox9;
        public TextBox RTselect_people_textBox10 = Examine2nd.examine2Nd.textBox10;
        public TextBox RTselect_people_textBox11 = Examine2nd.examine2Nd.textBox13;
        public EXSerch()
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
                string strda = "select * from 订单";
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
            RTselect_people_textBox1.Text = RTselect_people_number1;
            RTselect_people_textBox2.Text = RTselect_people_number2;
            RTselect_people_textBox3.Text = RTselect_people_number3;
            RTselect_people_textBox4.Text = RTselect_people_number4;
            
            RTselect_people_textBox6.Text = RTselect_people_number6;
            RTselect_people_textBox7.Text = RTselect_people_number7;
            RTselect_people_textBox8.Text = RTselect_people_number8;
            RTselect_people_textBox9.Text = RTselect_people_number9;
            RTselect_people_textBox10.Text = RTselect_people_number10;
            RTselect_people_textBox11.Text = RTselect_people_number11;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RTselect_people_number1 = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
            RTselect_people_number2 = dataGridView1.Rows[e.RowIndex].Cells["客户"].Value.ToString();
            RTselect_people_number3 = dataGridView1.Rows[e.RowIndex].Cells["销售员"].Value.ToString();
            RTselect_people_number4 = dataGridView1.Rows[e.RowIndex].Cells["商品名称"].Value.ToString();
            
            RTselect_people_number6 = dataGridView1.Rows[e.RowIndex].Cells["商品单价"].Value.ToString();
            RTselect_people_number7 = dataGridView1.Rows[e.RowIndex].Cells["商品数量"].Value.ToString();
            RTselect_people_number8 = dataGridView1.Rows[e.RowIndex].Cells["总价"].Value.ToString();
            RTselect_people_number9 = dataGridView1.Rows[e.RowIndex].Cells["送货地址"].Value.ToString();
            RTselect_people_number10 = dataGridView1.Rows[e.RowIndex].Cells["商品编码"].Value.ToString();
            RTselect_people_number11 = dataGridView1.Rows[e.RowIndex].Cells["订单日期"].Value.ToString();
        }

        private void EXSerch_Load(object sender, EventArgs e)
        {

        }
    }
}
