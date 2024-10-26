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

namespace WinFormsApp1.采购管理.采购
{
    public partial class PL : Form
    {
        public SQR SQR1;
        public gys1 gys12;
        public PLT PLT1;
        public static PL PL1;
        public VA VA1;
        public DataGridView dataGridView1 = cgsqy.cgsqy1.dataGridView1;
        public PL()
        {
            InitializeComponent();
            GetDataGridView();
            textBox4.TextChanged += TextBox_TextChanged;
            textBox5.TextChanged += TextBox_TextChanged;
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
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
        private void button3_Click(object sender, EventArgs e)
        {
            SQR1 = new SQR();
            SQR1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gys12 = new gys1();
            gys12.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PLT1 = new PLT();
            PLT1.Show();
        }

        private void PL_Load(object sender, EventArgs e)
        {
            PL1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("添加成功!");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VA1 = new VA();
            VA1.Show();
        }
    }
}
