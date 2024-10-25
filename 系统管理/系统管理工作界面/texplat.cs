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

namespace WinFormsApp1.系统管理工作界面
{
    public partial class texplat : UserControl
    {
        public texplat()
        {
            InitializeComponent();
            LoadData();
            //关闭自动创建列
            this.dgv_data.AutoGenerateColumns = false;

            //AutoSizeColumnsMode要设置为None,下面设置的固定宽度才有效果
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

            this.dgv_data.Columns[0].Width = 130;
            this.dgv_data.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//这一列设置自动填充显示的跨度
            this.dgv_data.Columns[1].Width = 170;
            this.dgv_data.Columns[3].Width = 150;
            this.dgv_data.Columns[4].Width = 150;
            this.dgv_data.Columns[5].Width = 150;
            foreach (DataGridViewColumn column in dgv_data.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void texplat_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 加载所有日志数据并显示在 DataGridView 中。
        /// </summary>
        private void LoadData()
        {
            // 从数据库中获取所有日志记录，返回 DataTable
            DataTable logTable = SysLogService.GetAllSysLogsAsDataTable();

            // 绑定 DataTable 到 DataGridView
            dgv_data.DataSource = logTable;

            // 设置 DataGridView 列标题

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                this.Invoke(new Action(() =>
                {
                    QueryProcess(DateTime.Now.ToString(this.dtp_start.Text), DateTime.Now.ToString(this.dtp_end.Text), GetLogType(), GetLogAlarmState());
                }));
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    QueryProcess(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), GetLogType(), GetLogAlarmState());
                }));
            });
        }

        private List<string> GetLogType()
        {
            List<string> result = new List<string>();
            if (chk_logInfo.Checked)
            {
                result.Add(this.chk_logInfo.Text);
            }
            if (chk_alarmInfo.Checked)
            {
                result.Add(this.chk_alarmInfo.Text);
            }

            if (chk_operationInfo.Checked)
            {
                result.Add(this.chk_operationInfo.Text);
            }
            return result;
        }
        private string GetLogAlarmState()
        {
            return "触发";
        }
        private void QueryProcess(string start, string end, List<string> logtype, string logAlarmState)
        {
            DateTime t1 = Convert.ToDateTime(start);
            DateTime t2 = Convert.ToDateTime(end);

            if (t1 > t2)
            {
                MessageBox.Show("开始时间不能大于结束时间", "日志查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (logAlarmState == "全部")
            {
                logAlarmState = string.Empty;
            }

            var List = new List<SysLog>();

            if (logtype.Count > 0)
            {
                foreach (var item in logtype)
                {
                    List.AddRange(SysLogService.GetSysLogByCondiiton(start, end, item, logAlarmState));
                }
            }

            //排序【这个排序很重要，因为是根据日志类型分组查询的，导致List是根据分组来排列显示的，要用这个排序方法来设置按照时间顺序显示】
            List.Sort((p1, p2) =>
            {
                if (Convert.ToDateTime(p1.LogTime) > Convert.ToDateTime(p2.LogTime))
                {
                    return 1;
                }
                else if (Convert.ToDateTime(p1.LogTime) < Convert.ToDateTime(p2.LogTime))
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            });

            this.dgv_data.DataSource = null;
            this.dgv_data.DataSource = List;
        }


    }
}
