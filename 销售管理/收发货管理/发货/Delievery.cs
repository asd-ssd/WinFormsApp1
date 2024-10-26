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
using WinFormsApp1.数据库支持类;
using WinFormsApp1.销售管理.客户管理;

namespace WinFormsApp1.销售管理.收发货管理.发货
{
    public partial class Delievery : UserControl
    {
        private readonly PermissionService _permissionService;
        public De2 de2;
        public De3 de3;
        public static Delievery delievery;
        public Delievery()
        {
            InitializeComponent();
            this.button1.Tag = "Create";
            this.button3.Tag = "Delete";
            this.button2.Tag = "Edit";
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 3); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=xlh;Persist Security Info=True;User ID=xlh;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 发货单";
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

        private void Delievery_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            delievery = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;//整个表格只读
            button5.Visible = true;
            button6.Visible = true;
        }
        string[] strcomm = new string[100];
        int n = 0;
        private IEnumerable<object> paras;
        private object dt;

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["出库单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = strcomm[n] = $"UPDATE 发货单 SET {strcolumn} = '{value}' WHERE 出库单编号 = '{strrow}'";
            n++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定删除该数据?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["发货单编号"].Value.ToString();
                    string delesql = "DELETE FROM 发货单 WHERE 发货单编号 = @发货单编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@发货单编号", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
                button5.Visible = false;
                button6.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button5.Visible = false;
                button6.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            de2 = new De2();
            de2.Show();   //将窗体一进行显示
        }

        private void button4_Click(object sender, EventArgs e)
        {
            de3 = new De3();
            de3.Show();   //将窗体一进行显示
        }
    }
}
