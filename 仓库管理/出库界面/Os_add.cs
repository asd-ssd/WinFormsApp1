using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.仓库管理.初始查询界面;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.仓库管理.出库界面
{
    public partial class Os_add : Form
    {
        public Os_select_item Os_item1;
        public Os_select_people Os_people1;
        public Os_select_dingdan Os_dingdan1;
        public Os_select_dingdan_2 Os_dingdan2;
        public DataGridView dataGridView1 = Os.Os1.dataGridView1;
        public static Os_add Os_Add1;
        private string Os_number;
        //public string Os_select_people_number;
        public Os_add()
        {
            InitializeComponent();
            Os_Add1 = this;
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=lwx;Password=luowenxin";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void change_2()
        {
            try
            {
                // 创建并打开数据库连接
                SqlConnection conn = connection();
                conn.Open();
                // 定义SQL更新语句
                string sql = "UPDATE Issue SET 领料单状态 = '已完成' WHERE 领料单编号 = @领料单编号";
                // 创建SqlCommand对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // 添加参数化查询以防止SQL注入
                    cmd.Parameters.AddWithValue("@领料单编号", textBox2.Text);

                    // 执行更新操作
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // 检查是否有行被更新
                    if (rowsAffected > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("没有找到对应的记录。");
                    }
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
        private void change_1()
        {
            try
            {
                // 创建并打开数据库连接
                SqlConnection conn = connection();
                conn.Open();
                // 定义SQL更新语句
                string sql = "UPDATE 订单审核通过表 SET 出库状态 = '已完成' WHERE 订单编号 = @订单编号";
                // 创建SqlCommand对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // 添加参数化查询以防止SQL注入
                    cmd.Parameters.AddWithValue("@订单编号", textBox2.Text);

                    // 执行更新操作
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // 检查是否有行被更新
                    if (rowsAffected > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("没有找到对应的记录。");
                    }
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
        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            //addDataGridView1();
            GetDataGridView();
            if (comboBox1.Text == "销售提货")
            {
                change_1();
            }
            if (comboBox1.Text == "生产领料")
            {
                change_2();
            }
            this.Close();
        }
        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();

            string strda = "INSERT INTO 出库单表 (出库单编号,库位号, 物料编码, 出库数量,出库人姓名,出库人编号,出库日期,出库类别,物料名称,销售订单编号) VALUES ('" + textBox4.Text.Trim() + "','" + comboBox2.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + textBox16.Text.Trim() + "','" + textBox15.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + dateTimePicker1.Value + "','" + comboBox1.Text + "','" + textBox5.Text.Trim() + "','" + textBox2.Text.Trim() + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            SysLogService.AddSysLog(new SysLog("新增出库单表表数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 出库单表";
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Os_item1 = new Os_select_item();
            Os_item1.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Os_people1 = new Os_select_people();
            Os_people1.Show();
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





        private void Os_add_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connection();
            conn.Open();
            string query = "SELECT 出库单编号 FROM 出库单表 ORDER BY 出库单编号 DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            SqlCommand comm = new SqlCommand(query, conn);
            object result = comm.ExecuteScalar();
            Os_number = result.ToString();
            textBox4.Text = Numberplus(Os_number);
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "其他出库")
            {
                textBox2.Visible = false;
                label8.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "销售提货")
            {
                Os_dingdan1 = new Os_select_dingdan();
                Os_dingdan1.Show();
            }
            if (comboBox1.Text == "生产领料")
            {
                Os_dingdan2 = new Os_select_dingdan_2();
                Os_dingdan2.Show();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string strda = "select * from 库存管理表 WHERE 物料编码='" + textBox5.Text.Trim() + "'";
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["库位号"].ToString() != "")
                {

                    if (int.TryParse(textBox16.Text, out int numberru))
                    {
                        // 获取库位库存量和库位容量，并转换为整数（假设它们已经是数字或可以转换为数字）  
                        int currentStock = int.Parse(dt.Rows[i]["库位库存量"].ToString());
                        int capacity = int.Parse(dt.Rows[i]["库位容量"].ToString());

                        // 检查是否满足条件：库位库存量加上 textBox16 中的数字小于库位容量  
                        if (currentStock - numberru >= 0)
                        {
                            // 将库位号添加到 comboBox2 的项中  
                            comboBox2.Items.Add(dt.Rows[i]["库位号"].ToString());
                        }

                    }


                }
            }
            conn.Close();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string strda = "select * from 库存管理表 WHERE 物料编码='" + textBox5.Text.Trim() + "'";
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["库位号"].ToString() != "")
                {

                    if (int.TryParse(textBox16.Text, out int numberru))
                    {
                        // 获取库位库存量和库位容量，并转换为整数（假设它们已经是数字或可以转换为数字）  
                        int currentStock = int.Parse(dt.Rows[i]["库位库存量"].ToString());
                        int capacity = int.Parse(dt.Rows[i]["库位容量"].ToString());

                        // 检查是否满足条件：库位库存量加上 textBox16 中的数字小于库位容量  

                        if (currentStock - numberru >= 0)
                        {
                            // 将库位号添加到 comboBox2 的项中  
                            comboBox2.Items.Add(dt.Rows[i]["库位号"].ToString());
                        }

                    }


                }
            }
            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
