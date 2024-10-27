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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using WinFormsApp1.数据库支持类;
using WinFormsApp1.仓库管理.初始查询界面;

namespace WinFormsApp1.仓库管理.库存盘点界面
{
    public partial class warehouse_count : UserControl
    {
        private readonly PermissionService _permissionService;
        public static count_push_new Count_push_new1;
        public static count_issue count_issue1;
        private static readonly DateTime DefaultStartDate = new DateTime(2000, 1, 1);
        public warehouse_count()
        {
            InitializeComponent();
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 5); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 库存管理表 where 1=1";
            if (textBox1.Text != "")

            {
                selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 物料编码 like'%" + textBox2.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 库位号 like'%" + textBox3.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsql += "and 所属库房 like'%" + textBox4.Text + "%'";
            }
            if (textBox5.Text != "")
            {
                selectsql += "and 物料分类 like'%" + textBox5.Text + "%'";
            }
            string start1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            //取开始时间的0点，大于等于开始日期的0点；
            string end1 = dateTimePicker2.Value.AddDays(1).Date.ToString("yyyy-MM-dd");
            //取结束时间第二天的0点，小于（没有等于）结束第二天的0点；

            var paras = new Dictionary<string, string> { { "start1", start1 }, { "end1", end1 } };


            selectsql += "and 最后盘点日期 >= @start1 AND 最后盘点日期 <@end1";

            SqlConnection conn = connection();
            conn.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            foreach (var par in paras)
            {
                //设置sqlCommand的参数
                da.SelectCommand.Parameters.AddWithValue(par.Key, par.Value);
            }
            da.Fill(dt1);
            conn.Close();
            dataGridView1.DataSource = dt1;
        }

        private void warehouse_count_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=lwx;Password=luowenxin";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 库存管理表";
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



        private void button2_Click(object sender, EventArgs e)
        {
            Count_push_new1 = new count_push_new();
            Count_push_new1.Show();
        }

        int n = 0;
        string[] strcomm = new string[100];
        private string latestUpdateCommand = ""; // 存储最新的更新命令  



        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)

        {

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "最后盘点日期") // 检查是否是“最后盘点日期”列  

            {

                string strrow = dataGridView1.Rows[e.RowIndex].Cells["库位号"].Value.ToString(); // 获取库位号  

                DateTime value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value; // 获取日期时间值  



                latestUpdateCommand = $"UPDATE 库存管理表 SET 最后盘点日期='{value:yyyy-MM-dd}' WHERE 库位号='{strrow}'";

            }

            // 注意：这里我们不再需要n和strcomm数组/列表  

        }



        private void button12_Click(object sender, EventArgs e)

        {

            if (MessageBox.Show("确定要修改数据吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {

                using (SqlConnection conn = connection()) // 使用using语句确保连接正确关闭  

                {

                    if (!string.IsNullOrEmpty(latestUpdateCommand)) // 检查是否有要执行的命令  

                    {

                        using (SqlCommand comm = new SqlCommand(latestUpdateCommand, conn))

                        {

                            conn.Open();

                            comm.ExecuteNonQuery();

                        }

                    }

                }



                GetDataGridView(); // 刷新DataGridView  

                // 注意：这里不再需要重置n，因为我们已经不再使用它  

                button12.Visible = false;

                button13.Visible = false;

                dataGridView1.ReadOnly = true; // 设置DataGridView为只读  

            }

        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button12.Visible = false;
                button13.Visible = false;
                dataGridView1.ReadOnly = true;//整个表格只读
                GetDataGridView();
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime startDate, endDate;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "全部":
                    // 对于“全部”，你可能需要设置特定的起始和结束日期，  
                    // 或者清空DateTimePicker的值以表示没有限制。  
                    // 这里我们假设清空DateTimePicker的值。  
                    // 使用默认的起始日期和当前日期作为结束日期  

                    startDate = DefaultStartDate;

                    endDate = now.Date;

                    dateTimePicker1.Value = startDate;

                    dateTimePicker2.Value = endDate;

                    break;

                case "当天":
                    startDate = now.Date;
                    endDate = startDate.AddDays(1).AddTicks(-1); // 当天结束时间（23:59:59.999...）  
                    dateTimePicker1.Value = startDate;
                    dateTimePicker2.Value = endDate;
                    break;

                case "本周":
                    // 获取本周的开始和结束日期（假设周一是周的第一天）  
                    int startOfWeek = (7 + (now.DayOfWeek - DayOfWeek.Monday)) % 7;
                    startDate = now.AddDays(-startOfWeek).Date;
                    endDate = startDate.AddDays(6).AddTicks(-1); // 本周结束时间  
                    dateTimePicker1.Value = startDate;
                    dateTimePicker2.Value = endDate;
                    break;

                case "本月":
                    startDate = new DateTime(now.Year, now.Month, 1);
                    endDate = startDate.AddMonths(1).AddDays(-1); // 本月结束时间  
                    dateTimePicker1.Value = startDate;
                    dateTimePicker2.Value = endDate;
                    break;

                case "本年":
                    startDate = new DateTime(now.Year, 1, 1);
                    endDate = startDate.AddYears(1).AddDays(-1); // 本年结束时间  
                    dateTimePicker1.Value = startDate;
                    dateTimePicker2.Value = endDate;
                    break;

                default:
                    // 处理未知选项（理论上不应该发生，除非ComboBox被外部修改）  
                    dateTimePicker1.Value = DateTime.MinValue;
                    dateTimePicker2.Value = DateTime.MaxValue;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count_issue1 = new count_issue();
            count_issue1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }
    }
}
