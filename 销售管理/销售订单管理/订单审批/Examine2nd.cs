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
using WinFormsApp1.销售管理.销售订单管理.订单审批;

namespace WinFormsApp1.销售管理
{
    public partial class Examine2nd : Form
    {
        public static Examine2nd examine2Nd;
        public EXSerch EXSerch;
        public EXPeople EXPeople;
        public DataGridView dataGridView1 = ExamineForm.examineForm.dataGridView1;
        public DataGridView dataGridView2 = ExamineForm.examineForm.dataGridView2;
        public Examine2nd()
        {
            InitializeComponent();
            examine2Nd = this;
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
                string strda = "select * from 订单审核通过表";
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
        private void GetDataGridView2()
        {
            try
            {
                string strda = "select * from 订单审核不通过表";
                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strda, conn);
                da.Fill(dt);
                conn.Close();
                //dataGridView1.AutoGenerateColumns = true;//自动创建列
                //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                dataGridView2.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 订单审核通过表(订单编号,订单日期,客户,销售员,商品名称,商品编码,商品单价,商品数量,送货地址,总价,审核员) values('" + textBox1.Text + "','" + textBox13.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox10.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox12.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void addDataGridView2()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 订单审核不通过表(订单编号,订单日期,客户,销售员,商品名称,商品编码,商品单价,商品数量,送货地址,总价,审核员) values('" + textBox1.Text + "','" + textBox13.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox10.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox12.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EXSerch = new EXSerch();
            EXSerch.Show();
        }

        private void Examine2nd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("添加成功！");
            this.Close();
            SysLogService.AddSysLog(new SysLog("新增订单审核通过表数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EXPeople = new EXPeople();
            EXPeople.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addDataGridView2();
            GetDataGridView2();
            MessageBox.Show("添加成功！");
            this.Close();
            SysLogService.AddSysLog(new SysLog("新增订单审核不通过表数据", "触发", LogTye.操作记录, login.login1.userid));
        }
    }
}
