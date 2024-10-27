using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using WinFormsApp1.采购管理.采购;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.采购管理.供应商
{

    public partial class xjy : Form
    {
        public string Is_number;
        public DataGridView dataGridView1 = gys.gys1.dataGridView1;
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
                string strda = "select * from 供应商表";
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
        public xjy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 供应商表(供应商编号,供应商名称,地址,联系人,联系方式,供应商类型,评级,备注) values('" + textBox2.Text + "','" + textBox7.Text + "','" + textBox1.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("添加成功!");
            SysLogService.AddSysLog(new SysLog("新增供应商表数据", "触发", LogTye.操作记录, login.login1.userid));
            this.Close();
        }

        private void xjy_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connection();
            conn.Open();
            string query = "SELECT 供应商编号 FROM 供应商表 ORDER BY 供应商编号 DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            SqlCommand comm = new SqlCommand(query, conn);
            object result = comm.ExecuteScalar();
            Is_number = result.ToString();
            textBox2.Text = Numberplus(Is_number);
            conn.Close();
        }
        public static string Numberplus(string str)
        {
            // 使用正则表达式找到字符串中的数字部分  
            Match match = Regex.Match(str, @"\d+");
            if (!match.Success)
            {
                // 如果没有找到数字部分，直接返回原字符串  
                return str;
            }

            // 将找到的数字部分转换为整数并加一  
            string numberPart = match.Value;
            int number = int.Parse(numberPart);
            number++;

            // 将加一的数字部分转换回字符串，并确保其长度与原数字部分相同（使用前导零）  
            string incrementedNumberPart = number.ToString(new string('0', numberPart.Length));

            // 使用正则表达式替换原字符串中的数字部分为加一的数字部分  
            return Regex.Replace(str, @"\d+", incrementedNumberPart);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
