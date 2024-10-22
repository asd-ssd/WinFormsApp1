using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp1.基础信息管理设置界面;

namespace WinFormsApp1.工作界面
{
    public partial class BOMplat : UserControl
    {
        public static BOMplat BOMplat1;
        public BOMset BOMset1;
        public BOMres BOMres1;
        public BOMplat()
        {
            InitializeComponent();
            BOMplat1 = this;
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from BOM表";
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
        private void BOMplat_Load(object sender, EventArgs e)
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
            BOMset1 = new BOMset();
            BOMset1.ShowDialog();
        }
        //查询
        private void button3_Click(object sender, EventArgs e)
        {
            BOMres1 = new BOMres();
            BOMres1.ShowDialog();
        }
        //删除
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["物料编码"].Value.ToString();
                    string delesql = "DELETE FROM BOM表 WHERE 物料编码 = @物料编码";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@物料编码", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
        //修改
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;//整个表格只读
            button6.Visible = true;
            button7.Visible = true;
        }
        string[] strcomm = new string[100];
        int n = 0;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["物料编码"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = "update BOM表 set " + strcolumn + "='" + value + "'where 物料编码 = " + strrow;
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
                dataGridView1.ReadOnly = true;//整个表格只读
                strcomm= new string[100];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button6.Visible = false;
                button7.Visible = false;
                dataGridView1.ReadOnly = true;//整个表格只读
                strcomm = new string[100];
            }
        }
    }
}
