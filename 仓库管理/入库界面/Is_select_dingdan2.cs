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

namespace WinFormsApp1.仓库管理.入库界面
{
    public partial class Is_select_dingdan2 : Form
    {
        private string Is_select_dingdan2_wunumber;
        private string Is_select_dingdan2_number;
        private string Is_select_dingdan2_name;
        private string Is_select_dingdan2_shuliang;
        public TextBox Is_select_dingdan2_textBox2 = Is_add.is_Add1.textBox2;//绑定is_add的入库人格
        public TextBox Is_select_dingdan2_textBox5 = Is_add.is_Add1.textBox5;
        public TextBox Is_select_dingdan2_textBox16 = Is_add.is_Add1.textBox16;
        public TextBox Is_select_dingdan2_textBox1 = Is_add.is_Add1.textBox1;
        public Is_select_dingdan2()
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


        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from MRP where 1=1 AND 状态='已完成'";
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
            string selectsql = "select * from Workorder where 1=1 AND 状态='已完成'";
            if (textBox1.Text != "")
            {
                selectsql += "and 物料编码 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 派工单编号 like'%" + textBox2.Text + "%'";
            }


            SqlConnection conn = connection();
            conn.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt1);

            conn.Close();
            dataGridView1.DataSource = dt1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //获取要选中行的ID值
                Is_select_dingdan2_number = row.Cells["MRP编号"].Value.ToString();
                Is_select_dingdan2_wunumber = row.Cells["物料编号"].Value.ToString();
                Is_select_dingdan2_name = row.Cells["物料名称"].Value.ToString();
                Is_select_dingdan2_shuliang = row.Cells["需求量"].Value.ToString();
            }
            Is_select_dingdan2_textBox2.Text = Is_select_dingdan2_number;
            Is_select_dingdan2_textBox5.Text = Is_select_dingdan2_wunumber;
            Is_select_dingdan2_textBox1.Text = Is_select_dingdan2_name;
            Is_select_dingdan2_textBox16.Text = Is_select_dingdan2_shuliang;

            this.Close();

        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Is_select_dingdan2_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }
    }
}
