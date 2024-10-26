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
using WinFormsApp1.Third;
using WinFormsApp1.计划管理.三级;

namespace WinFormsApp1.计划管理.三级功能
{
    public partial class 领料 : Form
    {
        public 领料()
        {
            InitializeComponent();
        }
        string Item_number = 车间作业.chejian1.Item_number;
        string MRP_number = 车间作业.chejian1.MRP_number;
        string Item_Am = 车间作业.chejian1.Item_am;
        string Start = 车间作业.chejian1.Start;
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
                
                string strdacte = "WITH CTE(物料编码, 物料名称, 父项编码, 单位用量, 层次号, 领料数量) " +
                    "AS (SELECT Distinct 物料编码, 物料名称, 父项编码, 单位用量, 层次号, 单位用量*" + Item_Am + " " +
                    "FROM BOM表 WHERE 物料编码 = '" + Item_number + "' " +
                    "UNION ALL " +
                    "SELECT P.物料编码, P.物料名称, P.父项编码, P.单位用量, P.层次号, P.单位用量*" + Item_Am + " " +
                    "FROM BOM表 AS P INNER JOIN CTE AS C ON C.物料编码 = P.父项编码 WHERE LEN(P.父项编码) > 0  ) " +
                    "SELECT * FROM CTE WHERE 物料编码 NOT IN (SELECT 父项编码 FROM BOM表 WHERE 父项编码 IS NOT NULL)";
                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strdacte, conn);
                da.Fill(dt);
                conn.Close();
                dt.Columns.Add("MRP编号", Type.GetType("System.String"));
                dt.Columns.Add("领料日期", Type.GetType("System.String"));
                foreach (DataRow row in dt.Rows)
                {
                    row["MRP编号"] = MRP_number;
                    row["领料日期"] = Start;
                }
                dt.Columns["MRP编号"].SetOrdinal(0);

                dt.Columns.Remove("单位用量");

                //dataGridView1.AutoGenerateColumns = true;//自动创建列
                //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        private void 领料_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 假设你已经有了一个填充了数据的DataTable dt
                DataTable Issue = dataGridView1.DataSource as DataTable;
                if (!Issue.Columns.Contains("领料单编号"))
                {
                    Issue.Columns.Add("领料单编号", Type.GetType("System.Int32"));
                }

                // 创建SQL连接
                SqlConnection conn = connection();
                {
                    conn.Open();
                    // 使用SqlBulkCopy批量插入数据
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                        bulkCopy.DestinationTableName = "Issue"; // 目标表名

                        // 可以配置批量复制的其他选项，例如列映射、批量大小等
                        bulkCopy.ColumnMappings.Add("领料单编号", "领料单编号");
                        bulkCopy.ColumnMappings.Add("MRP编号", "MRP编号");
                        bulkCopy.ColumnMappings.Add("物料编码", "物料编号");
                        bulkCopy.ColumnMappings.Add("物料名称", "物料名称");
                        bulkCopy.ColumnMappings.Add("领料数量", "领料数量");
                        bulkCopy.ColumnMappings.Add("领料日期", "领料日期");


                        // 执行批量复制
                        bulkCopy.WriteToServer(Issue);
                    }
                }

                MessageBox.Show("已成功添加！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }
    }
}
