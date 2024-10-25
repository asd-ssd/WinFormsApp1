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
using WinFormsApp1.仓库管理.入库界面;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.销售管理.收发货管理.发货
{
    public partial class Dselect : Form
    {
        private int n;
        private string[] strcomm;
        private string Dselect_item_number;
        private string Dselect_item_number2;
        private string Dselect_item_number3;
        public TextBox Dselect_item_textBox1 = De2.de2.textBox2;//仓库
        public TextBox Dselect_item_textBox2 = De2.de2.textBox4;//订单编号
        public TextBox Dselect_item_textBox3 = De2.de2.textBox5;//订单对应客户绑定is_add的入库人格
        public Dselect()
        {
            InitializeComponent();
            GetDataGridView();
        }

        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=xlh;Persist Security Info=True;User ID=xlh;Password=123456";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Dselect_item_textBox1.Text = Dselect_item_number;
            Dselect_item_textBox2.Text = Dselect_item_number2;
            Dselect_item_textBox3.Text = Dselect_item_number3;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 订单 where 1=1";
            /*if (textBox1.Text != "")
            {
                selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
            }*/
            if (textBox1.Text != "")
            {
                selectsql += "and 销售仓库 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 订单编号 like'%" + textBox2.Text + "%'";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Dselect_item_number = dataGridView1.Rows[e.RowIndex].Cells["销售仓库"].Value.ToString();
            Dselect_item_number2 = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
            Dselect_item_number3 = dataGridView1.Rows[e.RowIndex].Cells["客户"].Value.ToString();
        }

        private void Dselect_Load(object sender, EventArgs e)
        {

        }
    }
}
