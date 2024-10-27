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
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1.采购管理.采购
{
    public partial class cgxz : Form
    {
        private int n;
        private string[] strcomm;
        private string cgxz_number;
        public TextBox cgxz_item_textBox1 = sgsqy.sgsqy1.textBox3;//商品
        private string cgxz_number2;
        public TextBox cgxz_item_textBox2 = sgsqy.sgsqy1.textBox9;//编号
        private string cgxz_number3;
        public TextBox cgxz_item_textBox3 = sgsqy.sgsqy1.textBox4;//单价
        public cgxz()
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
        private void cgxz_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from BOM表 where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 物料编码 like'%" + textBox2.Text + "%'";
            }


            SqlConnection conn = connection();
            conn.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt1);
            conn.Close();
            dataGridView1.DataSource = dt1;
            MessageBox.Show("查询成功！");
            SysLogService.AddSysLog(new SysLog("查询BOM表数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cgxz_item_textBox1.Text = cgxz_number;
            cgxz_item_textBox2.Text = cgxz_number2;
            cgxz_item_textBox3.Text = cgxz_number3;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cgxz_number = dataGridView1.Rows[e.RowIndex].Cells["物料名称"].Value.ToString();
            cgxz_number2 = dataGridView1.Rows[e.RowIndex].Cells["物料编码"].Value.ToString();
            cgxz_number3 = dataGridView1.Rows[e.RowIndex].Cells["单价"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
