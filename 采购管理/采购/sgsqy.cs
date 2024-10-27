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
using WinFormsApp1.仓库管理.入库界面;
using WinFormsApp1.工作界面;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using WinFormsApp1.采购管理.采购;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.采购管理
{
    public partial class sgsqy : Form
    {
        public string Is_number;
        public cgxz cgxz1;
        public gys1 gys12;
        public GY GY1;
        public SQR SQR1;
        public SQRE SQRE1;
        public static sgsqy sgsqy1;

        public DataGridView dataGridView1 = cgsqy.cgsqy1.dataGridView1;

        public sgsqy()
        {
            InitializeComponent();
            GetDataGridView();
            textBox4.TextChanged += TextBox_TextChanged;
            textBox5.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // 尝试从 textBox1 和 textBox2 中获取整数值  
            if (int.TryParse(textBox4.Text, out int number1) && int.TryParse(textBox5.Text, out int number2))
            {
                // 计算乘积并更新 textBox3 的文本  
                int product = number1 * number2;
                textBox6.Text = product.ToString();
            }
            else
            {
                // 如果转换失败，清空 textBox3 或显示错误信息（可选）  
                textBox6.Text = string.Empty; // 清空 textBox3  
                // 或者显示错误消息（不推荐在 TextChanged 事件中频繁使用）  
                // MessageBox.Show("请输入有效的整数。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
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
                string strda = "select * from 采购表";
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
            string strda = "insert into 采购表(订单编号,申请人员,员工编号,申请日期,采购商品,商品编号,商品单价,采购数量,采购总价,供应商) values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox8.Text + "','" + dateTimePicker1.Value + "','" + textBox3.Text + "','" + textBox9.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("添加成功!");
            SysLogService.AddSysLog(new SysLog("新增采购表表数据", "触发", LogTye.操作记录, login.login1.userid));
            this.Close();
        }
        private void sgsqy_Load(object sender, EventArgs e)
        {
            sgsqy1 = this;
            GetDataGridView();
            SqlConnection conn = connection();
            conn.Open();
            string query = "SELECT 订单编号 FROM 采购表 ORDER BY 订单编号 DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            cgxz1 = new cgxz();
            cgxz1.Show();   //将窗体一进行显示
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GY1 = new GY();
            GY1.Show();   //将窗体一进行显示
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQRE1 = new SQRE();
            SQRE1.Show();   //将窗体一进行显示
        }
    }
}
