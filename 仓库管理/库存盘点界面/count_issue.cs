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

namespace WinFormsApp1.仓库管理.库存盘点界面
{
    public partial class count_issue : Form
    {
        private static readonly DateTime DefaultStartDate = new DateTime(2000, 1, 1);
        public count_issue()
        {
            InitializeComponent();
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
                string strda = "select * from 库存盘点表";
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
        private void button7_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 库存盘点表 where 1=1";
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
                selectsql += "and 盘点单编号 like'%" + textBox3.Text + "%'";
            }

            string start1 = dateTimePicker4.Value.Date.ToString("yyyy-MM-dd");
            //取开始时间的0点，大于等于开始日期的0点；
            string end1 = dateTimePicker3.Value.AddDays(1).Date.ToString("yyyy-MM-dd");
            //取结束时间第二天的0点，小于（没有等于）结束第二天的0点；

            var paras = new Dictionary<string, string> { { "start1", start1 }, { "end1", end1 } };


            selectsql += "and 盘点日期 >= @start1 AND 盘点日期 <@end1";


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

        private void count_issue_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

                    dateTimePicker4.Value = startDate;

                    dateTimePicker3.Value = endDate;

                    break;

                case "当天":
                    startDate = now.Date;
                    endDate = startDate.AddDays(1).AddTicks(-1); // 当天结束时间（23:59:59.999...）  
                    dateTimePicker4.Value = startDate;
                    dateTimePicker3.Value = endDate;
                    break;

                case "本周":
                    // 获取本周的开始和结束日期（假设周一是周的第一天）  
                    int startOfWeek = (7 + (now.DayOfWeek - DayOfWeek.Monday)) % 7;
                    startDate = now.AddDays(-startOfWeek).Date;
                    endDate = startDate.AddDays(6).AddTicks(-1); // 本周结束时间  
                    dateTimePicker4.Value = startDate;
                    dateTimePicker3.Value = endDate;
                    break;

                case "本月":
                    startDate = new DateTime(now.Year, now.Month, 1);
                    endDate = startDate.AddMonths(1).AddDays(-1); // 本月结束时间  
                    dateTimePicker4.Value = startDate;
                    dateTimePicker3.Value = endDate;
                    break;

                case "本年":
                    startDate = new DateTime(now.Year, 1, 1);
                    endDate = startDate.AddYears(1).AddDays(-1); // 本年结束时间  
                    dateTimePicker4.Value = startDate;
                    dateTimePicker3.Value = endDate;
                    break;

                default:
                    // 处理未知选项（理论上不应该发生，除非ComboBox被外部修改）  
                    dateTimePicker4.Value = DateTime.MinValue;
                    dateTimePicker3.Value = DateTime.MaxValue;
                    break;
            }
        }
    }
}
