using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.计划管理.三级;

namespace WinFormsApp1.计划管理.完成
{
    public partial class MPS完成 : Form
    {
        public MPS完成()
        {
            InitializeComponent();
            this.textBox1.Text = MPS;
        }
        string MPS = 生产计划及MRP.shengchan1.MPS_number;

        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建并打开数据库连接
                SqlConnection conn = connection();
                conn.Open();

                // 定义SQL更新语句
                string sql = "UPDATE MPS SET 状态 = '已完成' ,完成日期 = CONVERT(VARCHAR, GETDATE(), 23)  WHERE 主计划编号 = @主计划编号";

                // 创建SqlCommand对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // 添加参数化查询以防止SQL注入
                    cmd.Parameters.AddWithValue("@主计划编号", MPS);

                    // 执行更新操作
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // 检查是否有行被更新
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("状态已更新为'已完成'。");
                    }
                    else
                    {
                        MessageBox.Show("没有找到对应的记录。");
                    }
                }

                // 关闭数据库连接
                conn.Close();
                生产计划及MRP.shengchan1.GetDataGridView();
                this.Close();
            }
            catch (Exception ex)
            {
                // 显示异常信息
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
