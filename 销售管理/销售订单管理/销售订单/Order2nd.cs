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
using WinFormsApp1.销售管理.收发货管理.退货;
using WinFormsApp1.销售管理.销售订单管理.收款单;
using WinFormsApp1.销售管理.销售订单管理.销售订单;

namespace WinFormsApp1.销售管理
{
    public partial class Order2nd : Form
    {
        public DataGridView dataGridView1 = orderform.Orderform.dataGridView1;
        private string Is_number;
        public static Order2nd order2Nd;
        public OSClient OSClient;
        public OSItem OSItem;
        public OSPeople OSPeople;


        public Order2nd()
        {
            InitializeComponent();
            order2Nd = this;
            textBox6.TextChanged += TextBox_TextChanged;
            textBox7.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // 尝试从 textBox1 和 textBox2 中获取整数值  
            if (int.TryParse(textBox6.Text, out int number1) && int.TryParse(textBox7.Text, out int number2))
            {
                // 计算乘积并更新 textBox3 的文本  
                int product = number1 * number2;
                textBox8.Text = product.ToString();
            }
            else
            {
                // 如果转换失败，清空 textBox3 或显示错误信息（可选）  
                textBox8.Text = string.Empty; // 清空 textBox3  
                // 或者显示错误消息（不推荐在 TextChanged 事件中频繁使用）  
                // MessageBox.Show("请输入有效的整数。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }
        private void o2button1_Click(object sender, EventArgs e)
        {

        }

        private void o2button2_Click(object sender, EventArgs e)
        {

        }

        private void o2button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("添加成功！");
            this.Close();
            SysLogService.AddSysLog(new SysLog("新增订单数据", "触发", LogTye.操作记录, login.login1.userid));
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
                string strda = "select * from 订单";
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
            string strda = "insert into 订单(订单编号,订单日期,客户,销售员,商品名称,商品单价,商品数量,总价,送货地址,商品编码) values('" + textBox1.Text + "','" + dateTimePicker1.Value + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
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

        private void Order2nd_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connection();
            conn.Open();
            string query = "SELECT 订单编号 FROM 订单 ORDER BY 订单编号 DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            SqlCommand comm = new SqlCommand(query, conn);
            object result = comm.ExecuteScalar();
            Is_number = result.ToString();
            textBox1.Text = Numberplus(Is_number);
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OSPeople = new OSPeople();
            OSPeople.Show();   //将窗体一进行显示
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OSClient = new OSClient();
            OSClient.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OSItem = new OSItem();
            OSItem.Show();
        }

    }
}
