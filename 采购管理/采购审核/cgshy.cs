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
using WinFormsApp1.采购管理.采购;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.采购管理.采购审核
{
    public partial class cgshy : Form
    {
        public string MRP1;
        public DataGridView dataGridView2 = shx.shx1.dataGridView2;
        public static cgshy cgshy1;
        public ST ST1;
        public SHR SHR1;
        public cgshy()
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
                string strda = "select * from 采购表";
                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strda, conn);
                da.Fill(dt);
                conn.Close();
                //dataGridView1.AutoGenerateColumns = true;//自动创建列
                //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                //dataGridView2.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        private void cgshy_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            cgshy1 = this;
        }

        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 审核表(订单编号,申请人员,员工编号,采购商品,商品编号,商品单价,采购数量,采购总价,供应商,审核人员,审核编号,备注) values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox10.Text + "','" + textBox3.Text + "','" + textBox11.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox12.Text + "','" + textBox9.Text +"')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();

        }
        private void addDataGridView1()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 驳回表(订单编号,申请人员,员工编号,采购商品,商品编号,商品单价,采购数量,采购总价,供应商,审核人员,审核编号,备注) values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox10.Text + "','" + textBox3.Text + "','" + textBox11.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox12.Text + "','" + textBox9.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("已通过。");
            this.Close();
            try
            {
                // 创建并打开数据库连接
                SqlConnection conn = connection();
                conn.Open();
                // 定义SQL更新语句
                string sql = "UPDATE MRP SET 状态 = @完成, 完成日期 = @当前时间 WHERE MRP编号 = @MRP编号";
                // 创建SqlCommand对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // 添加参数化查询以防止SQL注入
                    cmd.Parameters.AddWithValue("@完成", "已完成");
                    cmd.Parameters.AddWithValue("@当前时间", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@MRP编号", MRP1);

                    // 执行更新操作
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // 检查是否有行被更新
                    //if (rowsAffected > 0)
                    //{
                    //    MessageBox.Show("状态已更新");
                    //}
                    //else
                    //{
                    //   MessageBox.Show("没有找到对应的记录。");
                    //}
                }

                // 关闭数据库连接
                conn.Close();
            }
            catch (Exception ex)
            {
                // 显示异常信息
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SHR1 = new SHR();
            SHR1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ST1 = new ST();
            ST1.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            addDataGridView1();
            MessageBox.Show("已驳回。");
            this.Close();

        }
    }
}
