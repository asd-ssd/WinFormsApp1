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
using WinFormsApp1.销售管理.收发货管理.发货;
using WinFormsApp1.销售管理.收发货管理.退货;

namespace WinFormsApp1.销售管理
{
    public partial class ReturnForm : UserControl
    {

        public RT3 RT3;
        public RT2 RT2;
        public static ReturnForm returnForm;
        public ReturnForm()
        {
            InitializeComponent();
        }

        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=xlh;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 退货单";
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


        private void srcreat_Click(object sender, EventArgs e)
        {
            RT2 = new RT2();
            RT2.Show();   //将窗体一进行显示
        }



        private void sredit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;//整个表格只读
            sredit2.Visible = true;
            srcancel.Visible = true;
        }
        string[] strcomm = new string[100];
        int n = 0;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["退回编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = strcomm[n] = $"UPDATE 退货单 SET {strcolumn} = '{value}' WHERE 退回编号 = '{strrow}'";
            n++;
        }

        private void srdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定删除该数据?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["退回编号"].Value.ToString();
                    string delesql = "DELETE FROM 退货单 WHERE 退回编号 = @退回编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@退回编号", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView1.Rows.Remove(row);
                }
            }
            SysLogService.AddSysLog(new SysLog("删除退货单数据", "触发", LogTye.操作记录, login.login1.userid));
        }



        private void ReturnForm_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            returnForm = this;
        }

        private void sredit2_Click(object sender, EventArgs e)
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
                sredit2.Visible = false;
                srcancel.Visible = false;
            }
            SysLogService.AddSysLog(new SysLog("修改退货单数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void srcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                sredit2.Visible = false;
                srcancel.Visible = false;
            }
        }

        private void srsearch_Click(object sender, EventArgs e)
        {
            RT3 = new RT3();
            RT3.Show();   //将窗体一进行显示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }
    }
}
