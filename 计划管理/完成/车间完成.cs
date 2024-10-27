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
using WinFormsApp1.仓库管理.移库界面;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using WinFormsApp1.计划管理.三级;

namespace WinFormsApp1.计划管理.完成
{
    public partial class 车间完成 : Form
    {
        string MRP = 车间作业.chejian1.MRP_number;
        public 车间完成()
        {
            InitializeComponent();
            this.textBox1.Text = MRP;
        }
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
                string sql = "UPDATE MRP SET 状态 = '已完成',完成日期 = CONVERT(VARCHAR, GETDATE(), 23) WHERE MRP编号 = @MRP编号";

                // 创建SqlCommand对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // 添加参数化查询以防止SQL注入
                    cmd.Parameters.AddWithValue("@MRP编号", MRP);

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
                SysLogService.AddSysLog(new SysLog("完成车间作业计划数据", "触发", LogTye.操作记录, login.login1.userid));
                车间作业.chejian1.GetDataGridView();
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
