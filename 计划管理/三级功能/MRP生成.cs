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
        string MPS_Am= 生产计划及MRP.shengchan1.MPS_am;
        string MPS_End = 生产计划及MRP.shengchan1.MPS_end;
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=sa;Password=978123thy";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        private void GetDataGridView()
        {
            try
            {
                string name = "物料需求";
                string strda = "select * from MRP where 主计划编号 ='" + MPS + "'";
                string strdacte = "WITH CTE(物料编码, 物料名称, 父项编码, 单位用量, 层次号, 需求量, 物料来源, 提前期) " +
                    "AS (SELECT Distinct 物料编码, 物料名称, 父项编码, 单位用量, 层次号, 单位用量*"+MPS_Am+", 物料来源, 提前期 " +
                    "FROM BOM表 WHERE 物料编码 = '"+Item+"' " +
                    "UNION ALL " +
                    "SELECT P.物料编码, P.物料名称, P.父项编码, P.单位用量, P.层次号, P.单位用量*"+MPS_Am+", P.物料来源, P.提前期 " +
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
                foreach (DataRow row in dt.Rows)
                {
                    // 检查 MPS 是否为 null 或空字符串，如果是，提供默认值
                    if (!string.IsNullOrEmpty(MPS))
                    {
                        row["主计划编号"] = MPS;
                    }
                    else
                    {
                        row["主计划编号"] = "默认编号"; // 或者可以跳过该行的赋值
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
                }
                dt.Columns.Remove("物料编号");
                dt.Columns.Remove("库存");
                
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int amount = 0;
            int i = 0;
            try
            {
                string strdas = "select * from BOM表 where 物料编码 ='" + Item + "'";
                string strdal = "select * from 库存管理表 where 物料编码 ='" + Item + "'";
                string strdacte = "WITH CTE(物料编码, 物料名称, 父项编码, 单位用量, 层次号, 需求量, 物料来源)\r\nAS\r\n(\r\n\tSELECT Distinct 物料编码, 物料名称, 父项编码, 单位用量, 层次号, 单位用量*" + MPS_Am + ", 物料来源\r\n\tFROM BOM表\r\n\tWHERE 物料编码 = '" + Item + "'\r\n\tUNION ALL\r\n\tSELECT P.物料编码, P.物料名称, P.父项编码, P.单位用量, P.层次号, P.单位用量*" + MPS_Am + ", P.物料来源\r\n\tFROM BOM表 AS P\r\n\tINNER JOIN CTE AS C ON C.物料编码 = P.父项编码\r\n\tWHERE LEN(P.父项编码) > 0 \r\n)\r\nSELECT * FROM CTE";
                SqlConnection conns = connection();
                SqlCommand cmd1=new SqlCommand(strdas, conns);
                

            }
            catch (Exception ee)
            { 
                MessageBox.Show(ee.Message.ToString());
            }
        }
        private void addDataGridView()
        {
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
