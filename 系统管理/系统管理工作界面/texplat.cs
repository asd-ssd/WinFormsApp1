using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1.系统管理工作界面
{
    public partial class texplat : UserControl
    {
        public texplat()
        {
            InitializeComponent();
            LoadData();
            ConfigureDataGridView();
        }

        private void texplat_Load(object sender, EventArgs e)
        {
            // 可以在这里做一些加载时的设置
        }

        private void ConfigureDataGridView()
        {
            dgv_data.Columns.Clear(); // 清空之前的列
            dgv_data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LogID", HeaderText = "日志编号" });
            dgv_data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LogTime", HeaderText = "操作时间" });
            dgv_data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LogInfo", HeaderText = "日志内容" });
            dgv_data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LogAlarmState", HeaderText = "报警状态" });
            dgv_data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LogType", HeaderText = "日志类型" });
            dgv_data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "User", HeaderText = "执行人" });
            this.dgv_data.AutoGenerateColumns = false;
            this.dgv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 设置列宽
            this.dgv_data.Columns[0].Width = 130;
            this.dgv_data.Columns[1].Width = 170;
            this.dgv_data.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_data.Columns[3].Width = 150;
            this.dgv_data.Columns[4].Width = 150;
            this.dgv_data.Columns[5].Width = 150;

            // 设置列标题居中
            foreach (DataGridViewColumn column in dgv_data.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void LoadData()
        {
            try
            {
                // 从数据库获取所有日志记录，并返回 List<SysLog>
                List<SysLog> logList = SysLogService.GetAllSysLogs();

                // 检查返回的日志列表是否为空
                if (logList == null || logList.Count == 0)
                {
                    MessageBox.Show("没有找到任何日志记录。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // 如果没有数据，则返回
                }

                // 绑定 List<SysLog> 到 DataGridView
                dgv_data.DataSource = null; // 清除现有数据源
                dgv_data.DataSource = logList; // 设置新的数据源

                // 可选：刷新 DataGridView 以确保显示更新
                dgv_data.Refresh();
            }
            catch (Exception ex)
            {
                // 弹出消息框显示错误信息
                MessageBox.Show($"加载日志记录时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerformQuery(this.dtp_start.Value.ToString("yyyy-MM-dd HH:mm:ss"), this.dtp_end.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerformQuery(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void PerformQuery(string start, string end)
        {
            Task.Run(() => 
            {
                this.Invoke(new Action(() =>
                {
                    QueryProcess(start, end, GetLogType(), GetLogAlarmState());
                }));
            });
        }

        private List<string> GetLogType()
        {
            List<string> result = new List<string>();
            if (chk_logInfo.Checked) result.Add(chk_logInfo.Text);
            if (chk_alarmInfo.Checked) result.Add(chk_alarmInfo.Text);
            if (chk_operationInfo.Checked) result.Add(chk_operationInfo.Text);
            return result;
        }

        private string GetLogAlarmState()
        {
            return "触发"; // 或者根据需求进行调整
        }

        private void QueryProcess(string start, string end, List<string> logtype, string logAlarmState)
        {
            if (!DateTime.TryParse(start, out DateTime t1) || !DateTime.TryParse(end, out DateTime t2))
            {
                MessageBox.Show("日期格式不正确", "日志查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (t1 > t2)
            {
                MessageBox.Show("开始时间不能大于结束时间", "日志查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"开始时间: {start}\n结束时间: {end}\n日志类型: {string.Join(", ", logtype)}\n报警状态: {logAlarmState}",
                 "查询参数", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // 使用日志状态的逻辑
            var logAlarmStateParam = logAlarmState == "全部" ? string.Empty : logAlarmState;
            var logList = new List<SysLog>();

            if (logtype.Count > 0)
            {
                foreach (var item in logtype)
                {
                    var results = SysLogService.GetSysLogByCondiiton(start, end, item, logAlarmStateParam);
                    logList.AddRange(results);
                    MessageBox.Show($"查询 '{item}' 的结果数量: {results.Count}",
                           "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // 排序日志
            logList.Sort((p1, p2) => DateTime.Compare(Convert.ToDateTime(p1.LogTime), Convert.ToDateTime(p2.LogTime)));

            MessageBox.Show($"总日志记录数量: {logList.Count}", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Invoke(new Action(() =>
            {
                dgv_data.DataSource = null; // 清空
                dgv_data.DataSource = logList; // 绑定新数据
                dgv_data.Refresh(); // 刷新显示
            }));
        }
    }
}
