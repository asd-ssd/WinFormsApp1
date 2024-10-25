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
using WinFormsApp1.计划管理.三级功能;

namespace WinFormsApp1.计划管理.三级
{
    public partial class 派工单 : UserControl
    {
        public static 派工单 paigong1;
        public 领料 ling1;
        public 派工单()
        {
            InitializeComponent();
            paigong1 = this;
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=sa;Password=978123thy";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        string[] strcomm = new string[100];
        int n = 0;
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from Workorder";

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
        private void 派工单_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ling1 = new 领料();
            ling1.Show();
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
                    string id = row.Cells["派工单编号"].Value.ToString();
                    string delesql = "DELETE FROM BOM表 WHERE 派工单编号 = @派工单编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@派工单编号", id);
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
            string selectsql = "select * from Workorder where 1=1";
            if (checkBox1.Checked == true)
            {
                selectsql += "and 状态 like'%" + "未完成" + "%'";
            }
            if (checkBox2.Checked == true)
            {
                selectsql += "and 状态 like'%" + "已完成" + "%'";
            }

            if (checkBox3.Checked == true)
            {
                selectsql += "and where 计划开始日期 between'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'" + "and'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'" + "%'";
            }
            if (checkBox4.Checked == true)
            {
                selectsql += "and MRP编号 like'%" + textBox1.Text + "%'";
            }
            if (checkBox5.Checked == true)
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
    }
}
