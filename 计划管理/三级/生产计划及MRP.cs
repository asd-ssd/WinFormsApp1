using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Forth;
using WinFormsApp1.计划管理.完成;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.计划管理.三级
{
    public partial class 生产计划及MRP : UserControl
    {
        public static 生产计划及MRP shengchan1;
        public MRP生成 MRP1;
        public 新增主生产计划 zhu1;
        public MPS完成 MPSw;

        public 生产计划及MRP()
        {
            InitializeComponent();
            shengchan1 = this;
        }
        public string MPS_number = null;
        public string MRP_number = null;
        public string Item_number = null;
        public string MPS_am = null;
        public string MPS_end = null;
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        int which = 0;
        string[] strcomm = new string[100];
        int n = 0;

        public void GetDataGridView()
        {
            try
            {
                string strda = "select * from MPS";
                if (which == 0)
                {
                    strda = "select * from MPS";
                }
                else if (which == 1)
                {
                    MPS_number = null;
                    strda = "select * from MRP";
                }
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
        private void 生产计划及MRP_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (which == 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    MPS_number = row.Cells["主计划编号"].Value.ToString();
                    Item_number = row.Cells["物料编号"].Value.ToString();
                    MPS_am = row.Cells["计划数量"].Value.ToString();
                    MPS_end = row.Cells["计划完成日期"].Value.ToString();
                }
                if (MPS_number != null)
                {
                    MRP1 = new MRP生成();
                    MRP1.Show();
                }
                else
                {
                    MessageBox.Show("未选中！");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zhu1 = new 新增主生产计划();
            zhu1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    if (which == 0)
                    {
                        string id = row.Cells["主计划编号"].Value.ToString();
                        string delesql = "DELETE FROM MPS WHERE 主计划编号 = @主计划编号";
                        using (SqlConnection conn = connection())
                        {
                            using (SqlCommand comm = new SqlCommand(delesql, conn))
                            {
                                comm.Parameters.AddWithValue("@主计划编号", id);
                                conn.Open();
                                comm.ExecuteNonQuery();
                            }
                        }
                    }
                    else if (which == 1)
                    {
                        string id = row.Cells["MRP编号"].Value.ToString();
                        string delesql = "DELETE FROM MRP WHERE MRP编号 = @MRP编号";
                        using (SqlConnection conn = connection())
                        {
                            using (SqlCommand comm = new SqlCommand(delesql, conn))
                            {
                                comm.Parameters.AddWithValue("@MRP编号", id);
                                conn.Open();
                                comm.ExecuteNonQuery();
                            }
                        }
                    }

                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
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
                button10.Visible = false;
                button9.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            which = 0;
            GetDataGridView();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            dataGridView1.DataSource = null;
            which = 1;
            GetDataGridView();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题            
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            if (which == 0)
            {
                string strrow = dataGridView1.Rows[e.RowIndex].Cells["主计划编号"].Value.ToString();//获取焦点触发行的第一个值
                strcomm[n] = $"UPDATE MPS SET {strcolumn} = '{value}' WHERE 主计划编号 = '{strrow}'";
            }
            else if (which == 1)
            {
                string strrow = dataGridView1.Rows[e.RowIndex].Cells["MRP编号"].Value.ToString();//获取焦点触发行的第一个值
                strcomm[n] = $"UPDATE MRP SET {strcolumn} = '{value}' WHERE MRP编号 = '{strrow}'";
            }

            n++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from MPS where 1=1";
            if (which == 1)
            {
                selectsql = "select * from MRP where 1=1";
            }

            if (checkBox1.Checked)
            {
                selectsql += "and 状态 ='%" + "未完成" + "%'";
            }
            if (checkBox2.Checked)
            {
                selectsql += "and 状态 ='%" + "已完成" + "%'";
            }
            if (checkBox6.Checked)
            {
                selectsql += "and 物料编码 like'%" + textBox3.Text + "%'";
            }
            if (checkBox7.Checked)
            {
                selectsql += "and 物料名称 like'%" + textBox3.Text + "%'";
            }
            if (checkBox3.Checked)
            {
                selectsql += "and where 计划开始日期 between'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'" + "and'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
            }
            if (checkBox4.Checked)
            {
                selectsql += "and 物料编号 like'%" + textBox1.Text + "%'";
            }
            if (checkBox5.Checked)
            {
                selectsql += "and 主计划编号 like'%" + textBox3.Text + "%'";
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
            button10.Visible = true;
            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button10.Visible = false;
                button9.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                MPS_number = row.Cells["主计划编号"].Value.ToString();
            }
            MPSw = new MPS完成();
            MPSw.Show();
        }

        private void button12_Click(object sender, EventArgs e)
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

    }
}
