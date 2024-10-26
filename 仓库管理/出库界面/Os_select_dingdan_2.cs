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

namespace WinFormsApp1.仓库管理.出库界面
{
    public partial class Os_select_dingdan_2 : Form
    {
        private string Os_select_dingdan_2_wunumber;
        private string Os_select_dingdan_2_number;
        private string Os_select_dingdan_2_name;
        private string Os_select_dingdan_2_shuliang;
        public TextBox Os_select_dingdan_2_textBox2 = Os_add.Os_Add1.textBox2;//绑定is_add的入库人格
        public TextBox Os_select_dingdan_2_textBox5 = Os_add.Os_Add1.textBox5;
        public TextBox Os_select_dingdan_2_textBox16 = Os_add.Os_Add1.textBox16;
        public TextBox Os_select_dingdan_2_textBox1 = Os_add.Os_Add1.textBox1;
        public Os_select_dingdan_2()
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
                string strda = "select * from Issue";
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
            string selectsql = "select * from Issue where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 物料编号 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 领料单编号 like'%" + textBox2.Text + "%'";
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
                Os_select_dingdan_2_number = row.Cells["领料单编号"].Value.ToString();
                Os_select_dingdan_2_wunumber = row.Cells["物料编号"].Value.ToString();
                Os_select_dingdan_2_name = row.Cells["物料名称"].Value.ToString();
                Os_select_dingdan_2_shuliang = row.Cells["领料数量"].Value.ToString();

            }
            Os_select_dingdan_2_textBox2.Text = Os_select_dingdan_2_number;
            Os_select_dingdan_2_textBox1.Text = Os_select_dingdan_2_wunumber;
            Os_select_dingdan_2_textBox5.Text = Os_select_dingdan_2_name;
            Os_select_dingdan_2_textBox16.Text = Os_select_dingdan_2_shuliang;

            this.Close();

        }



        private void Os_select_dingdan_2_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         

        }
    }
}
