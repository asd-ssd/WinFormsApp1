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

namespace WinFormsApp1.计划管理.三级功能
{
    public partial class 工序排程 : Form
    {
        public 工序排程()
        {
            InitializeComponent();
        }
        string Item_number = 车间作业.chejian1.Item_number;
        string Item_Am = 车间作业.chejian1.Item_am;
        string Start = 车间作业.chejian1.Start;
        string MRP_number = 车间作业.chejian1.MRP_number;
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            //try
            //{

                string strda = "select * from 工艺路线表 INNER JOIN BOMcraft ON  BOMcraft.工序 = 工艺路线表.工序  WHERE BOMcraft.物料编码 ='" + 车间作业.chejian1.Item_number + "'";
                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strda, conn);
                da.Fill(dt);
                conn.Close();
                double totaljia = dt.AsEnumerable().Sum(row => Convert.ToDouble(row["加工时间"]));
                double Item_am = Convert.ToDouble(Item_Am);
                double total = Item_am * totaljia;
                int leadTime = Convert.ToInt32(total) / 24;
                DateTime.TryParse(Start, out DateTime startdate);
                DateTime enddate = startdate.AddDays(leadTime);
                dt.Columns.Add("MRP编号", Type.GetType("System.String"));
                dt.Columns.Add("加工数量", Type.GetType("System.String"));
                dt.Columns.Add("计划开始时间", Type.GetType("System.String"));
                dt.Columns.Add("计划结束时间", Type.GetType("System.String"));
                foreach (DataRow row in dt.Rows)
                {
                    row["MRP编号"] = MRP_number;
                    row["加工数量"] = Item_Am;
                    row["计划开始时间"] = Start;
                    row["计划结束时间"] = enddate.ToString("yyyy-MM-dd");
                }
                dt.Columns["物料编码"].SetOrdinal(0);
                dt.Columns["MRP编号"].SetOrdinal(0);
                dt.Columns.Remove("ID");
                dt.Columns.Remove("工序1");
                dt.Columns.Remove("外协费");
                dt.Columns.Remove("准备时间");
                dt.Columns.Remove("机器台时");
                dt.Columns.Remove("排队时间（天）");
                dt.Columns.Remove("传送时间（天）");
                dt.Columns.Remove("准备工人数");
                dt.Columns.Remove("加工工人数");
                //dataGridView1.AutoGenerateColumns = true;//自动创建列
                //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                dataGridView1.DataSource = dt;
           // }
            //catch (Exception ee)
            //{
                //MessageBox.Show(ee.Message.ToString());
          //  }
        }
        private void 工序排程_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // 假设你已经有了一个填充了数据的DataTable dt
                DataTable Workorder = dataGridView1.DataSource as DataTable;
                if(!Workorder.Columns.Contains("派工单编号"))
        {
                    Workorder.Columns.Add("派工单编号", Type.GetType("System.Int32"));
                }

                // 创建SQL连接
                SqlConnection conn = connection();
                {
                    conn.Open();
                    // 使用SqlBulkCopy批量插入数据
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                        bulkCopy.DestinationTableName = "Workorder"; // 目标表名

                        // 可以配置批量复制的其他选项，例如列映射、批量大小等
                        bulkCopy.ColumnMappings.Add("派工单编号", "派工单编号");
                        bulkCopy.ColumnMappings.Add("MRP编号", "MRP编号");
                        bulkCopy.ColumnMappings.Add("物料编码", "物料编号");
                        bulkCopy.ColumnMappings.Add("工序", "工序");
                        bulkCopy.ColumnMappings.Add("工序名称", "工序名称");
                        bulkCopy.ColumnMappings.Add("工作中心编号", "工作中心编号");
                        bulkCopy.ColumnMappings.Add("工作中心名称", "工作中心名称");
                        bulkCopy.ColumnMappings.Add("加工时间", "加工时间");
                        bulkCopy.ColumnMappings.Add("加工数量", "加工数量");
                        bulkCopy.ColumnMappings.Add("计划开始时间", "计划开始时间");
                        bulkCopy.ColumnMappings.Add("计划结束时间", "计划结束时间");

                        // 执行批量复制
                        bulkCopy.WriteToServer(Workorder);
                    }
                }
                SysLogService.AddSysLog(new SysLog("新增派工单数据", "触发", LogTye.操作记录, login.login1.userid));
                MessageBox.Show("已成功添加！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }
    }
}
