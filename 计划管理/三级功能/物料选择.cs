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
using WinFormsApp1.Forth;
using WinFormsApp1.仓库管理.入库界面;

namespace WinFormsApp1.计划管理.三级功能
{
    public partial class 物料选择 : Form
    {
        public 物料选择()
        {
            InitializeComponent();
        }
        private string Item_number;
        private string Item_name;
        private string Item_type;
        public TextBox Item_textBox1 = 新增主生产计划.xin1.textBox1;
        public TextBox Item_textBox2 = 新增主生产计划.xin1.textBox2;
        public TextBox Item_textBox3 = 新增主生产计划.xin1.textBox4;
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=sa;Password=978123thy";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        string[] strcomm = new string[100];
        int n = 0;
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
        private void 物料选择_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Item_number = dataGridView1.Rows[e.RowIndex].Cells["物料编码"].Value.ToString();
            Item_name = dataGridView1.Rows[e.RowIndex].Cells["物料名称"].Value.ToString();
            Item_type = dataGridView1.Rows[e.RowIndex].Cells["物料来源"].Value.ToString();
            //Is_select_people_textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["员工编号"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item_textBox1.Text = Item_number;
            Item_textBox2.Text = Item_type;
            Item_textBox3.Text = Item_name;
            this.Close();
        }
    }
}
