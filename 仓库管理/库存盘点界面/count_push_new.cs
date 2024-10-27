//using NPOI.OpenXmlFormats.Spreadsheet;
//using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.仓库管理.入库界面;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WinFormsApp1.仓库管理.库存盘点界面
{
    public partial class count_push_new : Form
    {
        private readonly PermissionService _permissionService;
        public count_select_item count_item1;
        public count_select_people count_people1;
        public static count_push_new count_Add1;
        private static readonly DateTime DefaultStartDate = new DateTime(2000, 1, 1);
        public count_push_new()
        {
            InitializeComponent();
            //this.button1.Tag = "Create";
            //this.button3.Tag = "Delete";
            // this.button2.Tag = "Edit";
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 5); // 1是模块ID
            permissionManager.ApplyPermissions(this);
            count_Add1 = this;
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=lwx;Password=luowenxin";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            this.Close();
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
        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            int num1, num2, minus = 0;
            bool result1 = int.TryParse(textBox1.Text, out num1);
            bool result2 = int.TryParse(textBox2.Text, out num2);

            if (result1 && result2)
            {

                minus = num1 - num2;
                // 现在你可以安全地使用minus变量了  
            }
            else
            {
                // 处理转换失败的情况，比如显示一个错误消息  
                MessageBox.Show("请输入有效的整数。");
            }
            string locationCode = comboBox2.Text.Trim(); // 假设TextBox6是库位号的输入框  
            string inventoryQuantity = textBox6.Text.Trim(); // 假设TextBox7是库存量的输入框
              
            string strda = "INSERT INTO 库存盘点表 (盘点单编号,库位号, 物料编码, 物料名称,盘点前库位库存,盘点后库位库存,差异总数,盘点人员,盘点人编号,盘点日期,备注) VALUES ('" + textBox4.Text.Trim() + "','" + comboBox2.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox6.Text.Trim() + "',@差异,'" + textBox15.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + richTextBox1.Text.Trim() + "')";
            strda += "UPDATE 库存管理表 SET 库位库存量 = @InventoryQuantity WHERE 库位号 = @LocationCode";

            SqlCommand comm = new SqlCommand(strda, conn);
            comm.Parameters.AddWithValue("@差异", minus);
            comm.Parameters.AddWithValue("@LocationCode", locationCode);
            comm.Parameters.AddWithValue("@InventoryQuantity", Convert.ToInt32(inventoryQuantity)); // 假设库存量是整数
            comm.ExecuteNonQuery();
            conn.Close();
            GetDataGridView();
            SysLogService.AddSysLog(new SysLog("新增库存盘点单表数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 库存盘点表 where 1=1";

            if (textBox7.Text != "")

            {
                selectsql += "and 库位号 like'%" + textBox1.Text + "%'";
            }
            string start1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            //取开始时间的0点，大于等于开始日期的0点；
            string end1 = dateTimePicker2.Value.AddDays(1).Date.ToString("yyyy-MM-dd");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count_item1 = new count_select_item();
            count_item1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count_people1 = new count_select_people();
            count_people1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //获取要选中行的ID值

                textBox5.Text = row.Cells["物料编码"].Value.ToString();
                textBox1.Text = row.Cells["物料名称"].Value.ToString();
                textBox2.Text = row.Cells["库位库存量"].Value.ToString();
                textBox6.Text = row.Cells["库位库存量"].Value.ToString();
                comboBox2.Items.Add(row.Cells["库位号"].Value.ToString());

            }
        }

        private void count_push_new_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            number();
        }
        private void number()
        {
            SqlConnection conn = connection();
            conn.Open();
            string query = "SELECT 盘点单编号 FROM 库存盘点表 ORDER BY 盘点单编号 DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            SqlCommand comm = new SqlCommand(query, conn);
            object result = comm.ExecuteScalar();
            string Os_number = result.ToString();
            textBox4.Text = Numberplus(Os_number);
            conn.Close();
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


                    // 将库位号添加到 comboBox2 的项中  
                    comboBox2.Items.Add(dt.Rows[i]["库位号"].ToString());





                }
            }
            conn.Close();
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
    }
}

