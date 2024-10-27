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
using WinFormsApp1.销售管理;
using WinFormsApp1.销售管理.销售订单管理.销售订单;

namespace WinFormsApp1
{
    public partial class orderform : UserControl
    {


        public Order2nd order2Nd;
        public static orderform Orderform;
        public OrderSearch orderSearch;

        public orderform()
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
                string strda = "select * from 订单";
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



        private void orderform_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            Orderform = this;
        }

        private void ocreat_Click(object sender, EventArgs e)
        {
            order2Nd = new Order2nd();
            order2Nd.Show();   //将窗体一进行显示

        }

        private void oedit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;//整个表格只读
            button1.Visible = true;
            button2.Visible = true;

        }
        string[] strcomm = new string[100];
        int n = 0;
        private IEnumerable<object> paras;
        private object dt;

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = strcomm[n] = $"UPDATE 订单 SET {strcolumn} = '{value}' WHERE 订单编号 = '{strrow}'";
            n++;


            

        }
        

        private void odelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定删除该数据?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["订单编号"].Value.ToString();
                    string delesql = "DELETE FROM 订单 WHERE 订单编号 = @订单编号";
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
            SysLogService.AddSysLog(new SysLog("删除订单数据", "触发", LogTye.操作记录, login.login1.userid));

        }

        private void osearch_Click(object sender, EventArgs e)
        {
            orderSearch = new OrderSearch();
            orderSearch.Show();   //将窗体一进行显示
        }

        private void button1_Click(object sender, EventArgs e)
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
                button1.Visible = false;
                button2.Visible = false;
            }
            SysLogService.AddSysLog(new SysLog("修改订单数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        
}
}
