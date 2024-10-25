using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.系统管理工作界面;

namespace WinFormsApp1
{
    public partial class userconres : Form
    {
        public DataGridView dgvResults = userconplat.userconplat1.dataGridView2;
        public userconres()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 获取用户输入的查询条件
            string username = txtUsername.Text.Trim();
            string employeeId = txtEmployeeId.Text.Trim();
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // 检查时间范围
            if (startDate > endDate)
            {
                MessageBox.Show("开始时间不能晚于结束时间", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 使用 SqlSugar 进行查询
                var users = SqlSugarHelper.SqlSugarClient.Queryable<User>()
                    .WhereIF(!string.IsNullOrEmpty(username), u => u.UserName.Contains(username))
                    .WhereIF(!string.IsNullOrEmpty(employeeId), u => u.EmployeeId.Contains(employeeId))
                    .Where(u => u.CreatedAt >= startDate && u.CreatedAt <= endDate)
                    .ToList();

                // 显示查询结果到 DataGridView
                dgvResults.DataSource = users;
                MessageBox.Show("查询成功！");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
