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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1.系统管理工作界面
{
    public partial class userconplat : UserControl
    {
        public static userconplat userconplat1;
        public userconres userconres1;
        public userconplat()
        {
            InitializeComponent();
            userconplat1 = this;
            this.dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
        }

        private void userconplat_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 用户信息表";
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
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userconres1 = new userconres();
            userconres1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView2.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    // 获取要删除行的用户名
                    string userName = row.Cells["用户名"].Value.ToString();

                    // SQL 语句：删除 UserRole 表中与该用户相关的记录
                    string deleteUserRoleSql = "DELETE FROM UserRole WHERE 用户编号 = @用户编号";
                    // SQL 语句：删除 用户信息表 中的记录
                    string deleteUserSql = "DELETE FROM 用户信息表 WHERE 用户名 = @用户名";

                    using (SqlConnection conn = connection())
                    {
                        try
                        {
                            conn.Open();

                            // 删除 UserRole 表中与该用户相关的记录
                            using (SqlCommand deleteUserRoleCommand = new SqlCommand(deleteUserRoleSql, conn))
                            {
                                deleteUserRoleCommand.Parameters.AddWithValue("@用户编号", userName);
                                deleteUserRoleCommand.ExecuteNonQuery();
                            }

                            // 删除 用户信息表 中的记录
                            using (SqlCommand deleteUserCommand = new SqlCommand(deleteUserSql, conn))
                            {
                                deleteUserCommand.Parameters.AddWithValue("@用户名", userName);
                                deleteUserCommand.ExecuteNonQuery();
                            }

                            // 从 DataGridView 中删除该行
                            dataGridView2.Rows.Remove(row);

                            // 记录删除操作到日志
                            SysLogService.AddSysLog(new SysLog("删除用户信息表及其关联的用户角色数据", "触发", LogTye.操作记录, login.login1.userid));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"删除数据时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = false;//整个表格只读
            button2.Visible = true;
            button6.Visible = true;
        }
        string[] strcomm = new string[100];
        int n = 0;
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView2.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView2.Rows[e.RowIndex].Cells["用户名"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView2.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = $"UPDATE 用户信息表 SET {strcolumn} = '{value}' WHERE 用户名 = '{strrow}'";
            n++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要修改数据吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection conn = connection();
                for (int i = 0; i < n; i++)
                {
                    using (SqlCommand comm = new SqlCommand(strcomm[i], conn))
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                SysLogService.AddSysLog(new SysLog("修改用户信息表数据", "触发", LogTye.操作记录, login.login1.userid));
                GetDataGridView();
                n = 0;

                button6.Visible = false;
                button2.Visible = false;
                dataGridView2.ReadOnly = true;//整个表格只读
                strcomm = new string[100];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button6.Visible = false;
                button2.Visible = false;
                dataGridView2.ReadOnly = true;//整个表格只读
                strcomm = new string[100];
            }
        }
    }
}
