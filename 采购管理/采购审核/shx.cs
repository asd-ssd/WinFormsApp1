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
using WinFormsApp1.采购管理.采购;


namespace WinFormsApp1.采购管理.采购审核
{
    public partial class shx : UserControl
    {

        public shcx shcx1;
        public cgshy cgshy1;
        public static shx shx1;
        public shx()
        {
            InitializeComponent();
            shx1 = this;
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }


        private void GetDataGridView2()
        {
            try
            {
                string strda = "select * from 审核表";
                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strda, conn);
                da.Fill(dt);
                conn.Close();
                //dataGridView1.AutoGenerateColumns = true;//自动创建列
                //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                dataGridView2.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 驳回表";
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
        private void shx_Load(object sender, EventArgs e)
        {

            GetDataGridView2();
            GetDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shcx1 = new shcx();
            shcx1.Show();   //将窗体一进行显示
        }

        //private void button1_Click(object sender, EventArgs e)
        // {
        //    dataGridView2.ReadOnly = false;//整个表格只读
        //    button4.Visible = true;

        //}
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView2.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView2.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView2.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = "update 审核表 set " + strcolumn + "='" + value + "'where 订单编号 = " + strrow;
            n++;
        }
        string[] strcomm = new string[100];
        int n = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要保存数据吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

                GetDataGridView2();
                GetDataGridView();
                n = 0;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cgshy1 = new cgshy();
            cgshy1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetDataGridView();
            GetDataGridView2();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView2.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["订单编号"].Value.ToString();
                    string delesql = "DELETE FROM 审核表 WHERE 订单编号 = @订单编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@订单编号", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView2.Rows.Remove(row);
                }
                SysLogService.AddSysLog(new SysLog("删除审核表数据", "触发", LogTye.操作记录, login.login1.userid));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["订单编号"].Value.ToString();
                    string delesql = "DELETE FROM 驳回表 WHERE 订单编号 = @订单编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@订单编号", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView1.Rows.Remove(row);
                }
            }
            SysLogService.AddSysLog(new SysLog("删除驳回表数据", "触发", LogTye.操作记录, login.login1.userid));
        }
    }
}

