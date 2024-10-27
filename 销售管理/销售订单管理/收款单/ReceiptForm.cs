using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using WinFormsApp1.销售管理.销售订单管理.收款单;
using WinFormsApp1.销售管理.销售订单管理.销售订单;

namespace WinFormsApp1.销售管理
{
    public partial class ReceiptForm : UserControl
    {
        private readonly PermissionService _permissionService;
        public Receipt2nd receipt2;
        public static ReceiptForm receiptForm;
        public ReceiptSearch receiptSearch;
        public ReceiptForm()
        {
            InitializeComponent();
            this.rcreat.Tag = "Create";
            this.rdelete.Tag = "Delete";
            this.redit.Tag = "Edit";
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 3); // 1是模块ID
            permissionManager.ApplyPermissions(this);
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
                string strda = "select * from 收款单";
                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strda, conn);
                da.Fill(dt);
                conn.Close();
                //dataGridView1.AutoGenerateColumns = true;//自动创建列
                //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                rfdataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        private void rcreat_Click(object sender, EventArgs e)
        {
            receipt2 = new Receipt2nd();
            receipt2.Show();   //将窗体一进行显示

        }

        private void redit_Click(object sender, EventArgs e)
        {
            rfdataGridView1.ReadOnly = false;//整个表格只读
            redit2.Visible = true;
            rcancel.Visible = true;

        }
        string[] strcomm = new string[100];
        int n = 0;
        private IEnumerable<object> paras;
        private object dt;

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = rfdataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = rfdataGridView1.Rows[e.RowIndex].Cells["收款单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = rfdataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = strcomm[n] = $"UPDATE 收款单 SET {strcolumn} = '{value}' WHERE 收款单编号 = '{strrow}'";
            n++;
        }

        private void rdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定删除该数据?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = rfdataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["收款单编号"].Value.ToString();
                    string delesql = "DELETE FROM 收款单 WHERE 收款单编号 = @收款单编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@收款单编号", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    rfdataGridView1.Rows.Remove(row);
                }
            }
            SysLogService.AddSysLog(new SysLog("删除收款单数据", "触发", LogTye.操作记录, login.login1.userid));

        }

        private void rsearch_Click(object sender, EventArgs e)
        {
            receiptSearch = new ReceiptSearch();
            receiptSearch.Show();   //将窗体一进行显示
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            receiptForm = this;
        }

        private void redit2_Click(object sender, EventArgs e)
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
                redit2.Visible = false;
                rcancel.Visible = false;
            }
            SysLogService.AddSysLog(new SysLog("修改收款单数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void rcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                redit2.Visible = false;
                rcancel.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }
    }
}
