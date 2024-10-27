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

namespace WinFormsApp1.采购管理.采购
{
    public partial class cgsqy : UserControl
    {
        private readonly PermissionService _permissionService;
        public cgcxy cgcxy1;
        public sgsqy sgsqy1;
        public static cgsqy cgsqy1;
        public PL PL1;
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 采购表";
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
        public cgsqy()
        {
            InitializeComponent();
            this.button5.Tag = "Create";
            this.button6.Tag = "Delete";
            this.button1.Tag = "Edit";
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 4); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }

        private void cgsqy_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            cgsqy1 = this;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["订单编号"].Value.ToString();
                    string delesql = "DELETE FROM 采购表 WHERE 订单编号 = @订单编号";
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
            SysLogService.AddSysLog(new SysLog("删除采购表数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;//整个表格只读
            button4.Visible = true;

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = "update 采购表 set " + strcolumn + "='" + value + "'where 订单编号 = " + strrow;
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

                GetDataGridView();
                n = 0;

            }
            SysLogService.AddSysLog(new SysLog("修改采购表数据", "触发", LogTye.操作记录, login.login1.userid));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PL1 = new PL();
            sgsqy1 = new sgsqy();
            sgsqy1.Show();   //将窗体一进行显示
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cgcxy1 = new cgcxy();
            cgcxy1.Show();   //将窗体一进行显示
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PL1 = new PL();
            PL1.Show();
        }
    }
}
