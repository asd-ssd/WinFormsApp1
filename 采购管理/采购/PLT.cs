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
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1.采购管理.采购
{
    public partial class PLT : Form
    {
        private string PLT_number1;
        private string PLT_number2;
        private string PLT_number3;
        private string PLT_number4;
        public System.Windows.Forms.TextBox PLT_item_textBox1 = PL.PL1.textBox2;
        public System.Windows.Forms.TextBox PLT_item_textBox2 = PL.PL1.textBox3;
        public System.Windows.Forms.TextBox PLT_item_textBox3 = PL.PL1.textBox9;
        public System.Windows.Forms.TextBox PLT_item_textBox4 = PL.PL1.textBox5;
        public PLT()
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
                string strda = "select * from MRP where 物料来源 = '采购'";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PLT_number1 = dataGridView1.Rows[e.RowIndex].Cells["MRP编号"].Value.ToString();
            PLT_number2 = dataGridView1.Rows[e.RowIndex].Cells["物料名称"].Value.ToString();
            PLT_number3 = dataGridView1.Rows[e.RowIndex].Cells["物料编号"].Value.ToString();
            PLT_number4 = dataGridView1.Rows[e.RowIndex].Cells["需求量"].Value.ToString();
        }

        private void PLT_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PLT_item_textBox1.Text = PLT_number1;
            PLT_item_textBox2.Text = PLT_number2;
            PLT_item_textBox3.Text = PLT_number3;
            PLT_item_textBox4.Text = PLT_number4;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from MRP where 1=1";
            
            if (textBox1.Text != "")
            {
                selectsql += "and MRP编号 like'%" + textBox1.Text + "%'";
            }


            SqlConnection conn = connection();
            conn.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt1);
            conn.Close();
            dataGridView1.DataSource = dt1;
            MessageBox.Show("查询成功！");
            SysLogService.AddSysLog(new SysLog("查询MRP数据", "触发", LogTye.操作记录, login.login1.userid));
        }
    }
}
