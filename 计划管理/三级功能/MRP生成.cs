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
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
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
                string strda = "select * from MRP where 主计划编号 = @MPS";
                string strdacte = "WITH CTE(物料编码, 物料名称, 父项编码, 单位用量, 层次号, 需求量, 物料来源, 提前期) " +
                    "AS (SELECT Distinct 物料编码, 物料名称, 父项编码, 单位用量, 层次号, 单位用量 * @MPS_Am, 物料来源, 提前期 " +
                    "FROM BOM表 WHERE 物料编码 = @Item " +
                    "UNION ALL " +
                    "SELECT P.物料编码, P.物料名称, P.父项编码, P.单位用量, P.层次号, P.单位用量 * @MPS_Am, P.物料来源, P.提前期 " +
                    "FROM BOM表 AS P INNER JOIN CTE AS C ON C.物料编码 = P.父项编码 WHERE LEN(P.父项编码) > 0) SELECT * FROM CTE";
                string strdato = "WITH kucun(物料编号, 库存) AS (SELECT 物料编码, SUM(库位库存量) FROM 库存管理表 GROUP BY 物料编码) SELECT * FROM kucun";

                using (SqlConnection conn = connection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(strdacte, conn))
                    {
                        cmd.Parameters.AddWithValue("@MPS_Am", MPS_Am);
                        cmd.Parameters.AddWithValue("@Item", Item);

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        using (SqlCommand cmd1 = new SqlCommand(strdato, conn))
                        {
                            DataTable dt1 = new DataTable();
                            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                            da1.Fill(dt1);

                            dt = UniteDataTable(dt, dt1, name);
                        }

                        dt.Columns.Add("主计划编号", typeof(string));
                        dt.Columns.Add("开始日期", typeof(string));
                        dt.Columns.Add("最迟需求日期", typeof(string));

                        List<DataRow> rowsToDelete = new List<DataRow>();

                        foreach (DataRow row in dt.Rows)
                        {
                            if (!string.IsNullOrEmpty(MPS))
                            {
                                row["主计划编号"] = MPS;
                            }
                            else
                            {
                                row["主计划编号"] = "0001";
                            }

                            row["开始日期"] = DateTime.Now.ToString("yyyy-MM-dd");

                            if (!string.IsNullOrEmpty(MPS_End) && DateTime.TryParse(MPS_End, out DateTime enddate))
                            {
                                int leadTime = row["提前期"] != DBNull.Value ? Convert.ToInt32(row["提前期"]) : 0;
                                DateTime latestDemandDate = enddate.AddDays(-leadTime);
                                row["最迟需求日期"] = latestDemandDate.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                row["最迟需求日期"] = "无有效日期";
                            }

                            if (row["需求量"] != "" && row["库存"] != "")
                            {
                                string demandStr = row["需求量"].ToString();
                                string stockStr = row["库存"].ToString();

                                // 确保字符串可以转换为整数
                                if (int.TryParse(demandStr, out int demand) && int.TryParse(stockStr, out int stock))
                                {
                                    int result = demand - stock;
                                    row["需求量"] = result >= 0 ? result.ToString() : "0";
                                }
                                else
                                {
                                    MessageBox.Show($"无法转换需求量或库存为整数。需求量: {demandStr}, 库存: {stockStr}", "转换错误");
                                    row["需求量"] = "0";
                                }
                            }

                            if (row.IsNull("物料编码"))
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

                        dataGridView1.DataSource = dt;
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                SysLogService.AddSysLog(new SysLog("新增MRP数据", "触发", LogTye.操作记录, login.login1.userid));
                MessageBox.Show("已成功添加！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }
    }
}
