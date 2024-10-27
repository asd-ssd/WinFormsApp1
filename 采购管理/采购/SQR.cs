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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WinFormsApp1.采购管理.采购
{
    public partial class SQR : Form
    {
        
        private string[] strcomm;
        private string SQR_number;
        private string SQR_number1;
        public TextBox SQR_item_textBox1 = PL.PL1.textBox1;//申请人员
        public TextBox SQR_item_textBox2 = PL.PL1.textBox8;//员工编号
        public SQR()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SQR_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQR_item_textBox1.Text = SQR_number;
            SQR_item_textBox2.Text = SQR_number1;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 员工信息表 where 1=1";
            if (textBox2.Text != "")
            {
                selectsql += "and 员工编号 like'%" + textBox2.Text + "%'";
            }
            if (textBox1.Text != "")
            {
                selectsql += "and 员工姓名 like'%" + textBox1.Text + "%'";
            }


            SqlConnection conn = connection();
            conn.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt1);
            conn.Close();
            dataGridView1.DataSource = dt1;
            MessageBox.Show("查询成功！");
            SysLogService.AddSysLog(new SysLog("查询员工信息表数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQR_number = dataGridView1.Rows[e.RowIndex].Cells["员工姓名"].Value.ToString();
            SQR_number1 = dataGridView1.Rows[e.RowIndex].Cells["员工编号"].Value.ToString();
        }
    }
}
