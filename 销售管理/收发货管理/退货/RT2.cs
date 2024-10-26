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
using WinFormsApp1.销售管理.收发货管理.发货;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.销售管理.收发货管理.退货
{
    public partial class RT2 : Form
    {
        public DataGridView dataGridView1 = ReturnForm.returnForm.dataGridView1;
        private string Is_number;
        public static RT2 rT2;
        public RTSelect RTSelect;
        public RTPeople RTPeople;

        public RT2()
        {
            InitializeComponent();
            rT2 = this;
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
                string strda = "select * from 退货单";
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
        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 退货单(退回编号,退回日期,收货人,订单编号,客户编号) values('" + textBox1.Text + "','" + textBox2.Value + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("添加成功！");
            this.Close();
        }

        private void RT2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connection();
            conn.Open();
            string query = "SELECT 退回编号 FROM 退货单 ORDER BY 退回编号 DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            SqlCommand comm = new SqlCommand(query, conn);
            object result = comm.ExecuteScalar();
            Is_number = result.ToString();
            textBox1.Text = Numberplus(Is_number);
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

        private void button2_Click(object sender, EventArgs e)
        {
            RTSelect = new RTSelect();
            RTSelect.Show();   //将窗体一进行显示
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RTPeople = new RTPeople();
            RTPeople.Show();
        }
    }
}
