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
using WinFormsApp1.基础信息管理设置界面;
using WinFormsApp1.工作界面;

namespace WinFormsApp1.基础信息管理工作界面
{
    public partial class empplat : UserControl
    {
        public static empplat empplat1;
        public empres empres1;
        public emplset emplset1;
        public empplat()
        {
            InitializeComponent();
            empplat1 = this;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private  void GetDataGridView()
        {
            try
            {
                string strda = "select * from 员工信息表";
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
        private void empplat_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }
        //刷新
        private void button1_Click_1(object sender, EventArgs e)
        {
            GetDataGridView();
        }
        //新增
        private void button2_Click(object sender, EventArgs e)
        {
            emplset1 = new emplset();
            emplset1.ShowDialog();
        }
        //查询
        private void button3_Click(object sender, EventArgs e)
        {
            empres1 = new empres();
            empres1.ShowDialog();
        }
        //删除
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView2.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["员工编号"].Value.ToString();
                    string delesql = "DELETE FROM 员工信息表 WHERE 员工编号 = @员工编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@员工编号", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView2.Rows.Remove(row);
                }
            }
        }
        //修改
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = false;//整个表格只读
            button6.Visible = true;
            button7.Visible = true;
        }
        string[] strcomm = new string[100];
        int n = 0;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView2.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView2.Rows[e.RowIndex].Cells["员工编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView2.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = "update 员工信息表 set " + strcolumn + "='" + value + "'where 员工编号 = " + strrow;
            n++;
        }

        private void button6_Click(object sender, EventArgs e)
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

                button6.Visible = false;
                button7.Visible = false;
                dataGridView2.ReadOnly = true;//整个表格只读
                strcomm = new string[100];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button6.Visible = false;
                button7.Visible = false;
                dataGridView2.ReadOnly = true;//整个表格只读
                strcomm = new string[100];
            }
        }
    }
}
