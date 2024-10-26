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
using WinFormsApp1.计划管理.三级;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.Forth
{
    public partial class MRP生成 : Form
    {
        public MRP生成()
        {
            InitializeComponent();
        }
        string MPS = 生产计划及MRP.shengchan1.MPS_number;
        string Item = 生产计划及MRP.shengchan1.Item_number;
        int Kucun = 0;
        string MPS_Am = 生产计划及MRP.shengchan1.MPS_am;
        string MPS_End = 生产计划及MRP.shengchan1.MPS_end;
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
                string name = "MRP";
                string strda = "select * from MRP where 主计划编号 ='" + MPS + "'";
                string strdacte = "WITH CTE(物料编码, 物料名称, 父项编码, 单位用量, 层次号, 需求量, 物料来源, 提前期) " +
                    "AS (SELECT Distinct 物料编码, 物料名称, 父项编码, 单位用量, 层次号, 单位用量*" + MPS_Am + ", 物料来源, 提前期 " +
                    "FROM BOM表 WHERE 物料编码 = '" + Item + "' " +
                    "UNION ALL " +
                    "SELECT P.物料编码, P.物料名称, P.父项编码, P.单位用量, P.层次号, P.单位用量*" + MPS_Am + ", P.物料来源, P.提前期 " +
                    "FROM BOM表 AS P INNER JOIN CTE AS C ON C.物料编码 = P.父项编码 WHERE LEN(P.父项编码) > 0  ) SELECT * FROM CTE";
                //string str = "select * from CTE";
                string strdato = "with kucun(物料编号,库存) as (select 物料编码,sum(库位库存量) from 库存管理表 group by 物料编码) select * from kucun";

                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strdacte, conn);
                da.Fill(dt);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(strdato, conn);
                da1.Fill(dt1);
                dt = UniteDataTable(dt, dt1, name);
                /*SqlDataAdapter da2 = new SqlDataAdapter(strdajin, conn);
                da2.Fill(dt);*/
                dt.Columns.Add("主计划编号", Type.GetType("System.String"));
                dt.Columns.Add("开始日期", Type.GetType("System.String"));
                dt.Columns.Add("最迟需求日期", Type.GetType("System.String"));
                List<DataRow> rowsToDelete = new List<DataRow>();
                foreach (DataRow row in dt.Rows)
                {
                    
                    // 检查 MPS 是否为 null 或空字符串，如果是，提供默认值
                    if (!string.IsNullOrEmpty(MPS))
                    {
                        row["主计划编号"] = MPS;
                    }
                    else
                    {
                        row["主计划编号"] = "0001"; // 或者可以跳过该行的赋值
                    }

                    // 设置开始日期为当前日期
                    row["开始日期"] = DateTime.Now.ToString("yyyy-MM-dd");

                    // 检查 MPS_End 是否为 null 或空字符串，并且是有效的日期格式
                    if (!string.IsNullOrEmpty(MPS_End) && DateTime.TryParse(MPS_End, out DateTime enddate))
                    {
                        int leadTime = row["提前期"] != DBNull.Value ? Convert.ToInt32(row["提前期"]) : 0;
                        DateTime latestDemandDate = enddate.AddDays(-leadTime);
                        row["最迟需求日期"] = latestDemandDate.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        // 如果 MPS_End 无效，提供一个默认值或者处理逻辑
                        row["最迟需求日期"] = "无有效日期";
                    }
                    
                    // 检查行中是否有列"a"和"b"的数据*/
                    if (row["需求量"] != DBNull.Value && row["库存"] != DBNull.Value)
                    {
                        // 执行减法操作
                        int result = Convert.ToInt32(row["需求量"]) - Convert.ToInt32(row["库存"]);
                        if (result >= 0)
                            // 将结果存储在列"a"中
                            row["需求量"] = Convert.ToString(result);
                        else
                            row["需求量"] = Convert.ToString(0);
                    }
                    if (row.IsNull("物料编码") )
                    {
                        rowsToDelete.Add(row);
                    }
                }
                foreach (DataRow row in rowsToDelete)
                {
                    row.Delete();
                }

                dt.AcceptChanges();
                dt.Columns.Remove("物料编号");
                dt.Columns.Remove("库存");
                dt.Columns[8].SetOrdinal(0);
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
        private DataTable UniteDataTable(DataTable DataTable1, DataTable DataTable2, string DTName)
        {
            //克隆DataTable1的结构
            DataTable newDataTable = DataTable1.Clone();
            for (int i = 0; i < DataTable2.Columns.Count; i++)
            {
                //再向新表中加入DataTable2的列结构
                newDataTable.Columns.Add(DataTable2.Columns[i].ColumnName);
            }
            object[] obj = new object[newDataTable.Columns.Count];
            //添加DataTable1的数据
            for (int i = 0; i < DataTable1.Rows.Count; i++)
            {
                DataTable1.Rows[i].ItemArray.CopyTo(obj, 0);
                newDataTable.Rows.Add(obj);
            }

            if (DataTable1.Rows.Count >= DataTable2.Rows.Count)
            {
                for (int i = 0; i < DataTable2.Rows.Count; i++)
                {
                    for (int j = 0; j < DataTable2.Columns.Count; j++)
                    {
                        newDataTable.Rows[i][j + DataTable1.Columns.Count] = DataTable2.Rows[i][j].ToString();
                    }
                }
            }
            else
            {
                DataRow dr3;
                //向新表中添加多出的几行
                for (int i = 0; i < DataTable2.Rows.Count - DataTable1.Rows.Count; i++)
                {
                    dr3 = newDataTable.NewRow();
                    newDataTable.Rows.Add(dr3);
                }
                for (int i = 0; i < DataTable2.Rows.Count; i++)
                {
                    for (int j = 0; j < DataTable2.Columns.Count; j++)
                    {
                        newDataTable.Rows[i][j + DataTable1.Columns.Count] = DataTable2.Rows[i][j].ToString();
                    }
                }
            }
            newDataTable.TableName = DTName; //设置DT的名字 
            return newDataTable;
        }
        private void MRP_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // 假设你已经有了一个填充了数据的DataTable dt
                DataTable MRP = dataGridView1.DataSource as DataTable;
                MRP.Columns.Add("MRP编号", Type.GetType("System.Int32"));
                MRP.Columns.Add("状态", Type.GetType("System.String"));
                MRP.Columns.Remove("父项编码");
                MRP.Columns.Remove("单位用量");
                MRP.Columns.Remove("层次号");
                // 创建SQL连接
                SqlConnection conn = connection();
                {
                    conn.Open();
                    // 使用SqlBulkCopy批量插入数据
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                        bulkCopy.DestinationTableName = "MRP"; // 目标表名

                        // 可以配置批量复制的其他选项，例如列映射、批量大小等
                        bulkCopy.ColumnMappings.Add("MRP编号", "MRP编号");
                        bulkCopy.ColumnMappings.Add("状态", "状态");
                        bulkCopy.ColumnMappings.Add("主计划编号", "主计划编号");
                        bulkCopy.ColumnMappings.Add("物料编码", "物料编号");
                        bulkCopy.ColumnMappings.Add("物料名称", "物料名称");
                        bulkCopy.ColumnMappings.Add("需求量", "需求量");
                        bulkCopy.ColumnMappings.Add("物料来源", "物料来源");
                        bulkCopy.ColumnMappings.Add("开始日期", "开始日期");
                        bulkCopy.ColumnMappings.Add("最迟需求日期", "最迟需求日期");

                        // 执行批量复制
                        bulkCopy.WriteToServer(MRP);
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
