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

namespace WinFormsApp1.仓库管理.移库界面
{
    public partial class Ms_select_people : Form
    {
        private string Ms_select_people_name;
        private string Ms_select_people_number;
        public TextBox Ms_select_people_textBox1 = Ms_add.Ms_Add1.textBox15;//绑定is_add的移库人格
        public TextBox Ms_select_people_textBox2 = Ms_add.Ms_Add1.textBox3;
        public Ms_select_people()
        {
            InitializeComponent();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=lwx;Password=luowenxin";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ms_select_people_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 员工信息表";
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

        private void button7_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 员工信息表 where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 员工姓名 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 员工编号 like'%" + textBox2.Text + "%'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //获取要选中行的ID值
                Ms_select_people_number = row.Cells["员工编号"].Value.ToString();
                Ms_select_people_name = row.Cells["员工姓名"].Value.ToString();

            }
            Ms_select_people_textBox1.Text = Ms_select_people_name;
            Ms_select_people_textBox2.Text = Ms_select_people_number;
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  Ms_select_people_name=dataGridView1.Rows[e.RowIndex].Cells["员工姓名"].Value.ToString();
              Ms_select_people_number = dataGridView1.Rows[e.RowIndex].Cells["员工编号"].Value.ToString();*/

        }
    }
}
