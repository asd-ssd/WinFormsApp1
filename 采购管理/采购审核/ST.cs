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

namespace WinFormsApp1.采购管理.采购审核
{
    public partial class ST : Form
    {
        
       // private string[] strcomm;
        private string ST_number1;
        private string ST_number2;
        private string ST_number3;
        private string ST_number4;
        private string ST_number5;
        private string ST_number6;
        private string ST_number7;
        private string ST_number8;
        private string ST_number9;
        public System.Windows.Forms.TextBox ST_item_textBox1 = cgshy.cgshy1.textBox1;//申请人员
        public System.Windows.Forms.TextBox ST_item_textBox2 = cgshy.cgshy1.textBox2;//单号
        public System.Windows.Forms.TextBox ST_item_textBox3 = cgshy.cgshy1.textBox3;//商品
        public System.Windows.Forms.TextBox ST_item_textBox4 = cgshy.cgshy1.textBox4;//单价
        public System.Windows.Forms.TextBox ST_item_textBox5 = cgshy.cgshy1.textBox5;//数量
        public System.Windows.Forms.TextBox ST_item_textBox6 = cgshy.cgshy1.textBox6;//总价
        public System.Windows.Forms.TextBox ST_item_textBox7 = cgshy.cgshy1.textBox7;//供应商
        public System.Windows.Forms.TextBox ST_item_textBox8 = cgshy.cgshy1.textBox11;//商品编号
        public System.Windows.Forms.TextBox ST_item_textBox9 = cgshy.cgshy1.textBox10;//员工编号
        public string mrp = cgshy.cgshy1.MRP1;
        public ST()
        {
            InitializeComponent();
            GetDataGridView();
        }

        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 采购表";
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
        private void button2_Click(object sender, EventArgs e)
        {
            cgshy.cgshy1.MRP1 = ST_number2;
            ST_item_textBox1.Text = ST_number1;
            ST_item_textBox2.Text = ST_number2;
            ST_item_textBox3.Text = ST_number3;
            ST_item_textBox4.Text = ST_number4;
            ST_item_textBox5.Text = ST_number5;
            ST_item_textBox6.Text = ST_number6;
            ST_item_textBox7.Text = ST_number7;
            ST_item_textBox8.Text = ST_number8;
            ST_item_textBox9.Text = ST_number9;
            this.Close();
        }

        private void ST_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ST_number1 = dataGridView1.Rows[e.RowIndex].Cells["申请人员"].Value.ToString();
            ST_number2 = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
            ST_number3 = dataGridView1.Rows[e.RowIndex].Cells["采购商品"].Value.ToString();
            ST_number4 = dataGridView1.Rows[e.RowIndex].Cells["商品单价"].Value.ToString();
            ST_number5 = dataGridView1.Rows[e.RowIndex].Cells["采购数量"].Value.ToString();
            ST_number6 = dataGridView1.Rows[e.RowIndex].Cells["采购总价"].Value.ToString();
            ST_number7 = dataGridView1.Rows[e.RowIndex].Cells["供应商"].Value.ToString();
            ST_number8 = dataGridView1.Rows[e.RowIndex].Cells["商品编号"].Value.ToString();
            ST_number9 = dataGridView1.Rows[e.RowIndex].Cells["员工编号"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 采购表 where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 申请人员 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 订单编号 like'%" + textBox2.Text + "%'";
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
            if (textBox8.Text != "")
            {
                selectsql += "and 商品编号 like'%" + textBox8.Text + "%'";
            }
            if (textBox9.Text != "")
            {
                selectsql += "and 员工编号 like'%" + textBox9.Text + "%'";
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
