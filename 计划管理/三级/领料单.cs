using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.数据库支持类;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1.计划管理.三级
{
    public partial class 领料单 : UserControl
    {
        private readonly PermissionService _permissionService;
        public 领料单()
        {
            InitializeComponent();
            
            this.button3.Tag = "Delete";
            this.button2.Tag = "Edit";
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 2); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        string[] strcomm = new string[100];
        int n = 0;
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from Issue";

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
        private void 领料单_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void buttonex_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            DataTable dt = DgvToDt(dataGridView1);

            SaveFileDialog save = new SaveFileDialog();
            //设置文件类型
            save.Filter = "Excel表格（*.xls）|*.xls|Excel表格（*.xlsx）|*.xlsx";
            //设置默认文件类型显⽰顺序
            save.FilterIndex = 1;
            //保存对话框是否记忆上次打开的记录
            save.RestoreDirectory = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                //string localFilePath = save.FileName.ToString(); //获得⽂件路径
                //string fileNameExt =localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取⽂件名，不带路径

                NPOIExcel.TableToExcel(dt, save.FileName);
                sw.Stop();
                MessageBox.Show("数据导出完成");
            }
        }
        private DataTable DgvToDt(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            //把DataGridView控件数据，转成DataTable
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["领料单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值

            strcomm[n] = $"UPDATE Issue SET {strcolumn} = '{value}' WHERE 领料单编号 = '{strrow}'";
            n++;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要修改数据吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection conn = connection();
                for (int i = 0; i < n; i++)
                {
                    using (SqlCommand comm = new SqlCommand(strcomm[i], conn))
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                GetDataGridView();
                n = 0;
                button8.Visible = false;
                button9.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["领料单编号"].Value.ToString();
                    string delesql = "DELETE FROM Issue WHERE 领料单编号 = @领料单编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@领料单编号", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from Issue where 1=1";
            string start1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            //取开始时间的0点，大于等于开始日期的0点；
            string end1 = dateTimePicker2.Value.AddDays(1).Date.ToString("yyyy-MM-dd");
            //取结束时间第二天的0点，小于（没有等于）结束第二天的0点；
            var paras = new Dictionary<string, string> { { "start1", start1 }, { "end1", end1 } };
            if (checkBox1.Checked)
            {
                selectsql += "and 状态 ='未完成'";
            }
            if (checkBox2.Checked)
            {
                selectsql += "and 状态 ='已完成'";
            }

            if (checkBox3.Checked)
            {
                selectsql += "and 开始日期 >= @start1 AND 开始日期 <@end1";
            }
            if (checkBox4.Checked)
            {
                selectsql += "and 领料单编号 like'%" + textBox1.Text + "%'";
            }
            if (checkBox5.Checked)
            {
                selectsql += "and 派工单编号 like'%" + textBox3.Text + "%'";
            }

            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            MessageBox.Show("查询成功！");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;//整个表格只读
            button8.Visible = true;
            button9.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button8.Visible = false;
                button9.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
