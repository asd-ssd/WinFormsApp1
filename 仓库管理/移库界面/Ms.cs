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
using WinFormsApp1.数据库支持类;
using WinFormsApp1.仓库管理.移库界面;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WinFormsApp1.数据库封装类;

namespace WinFormsApp1.仓库管理.移库界面
{
    public partial class Ms : UserControl
    {
        private readonly PermissionService _permissionService;
        public Ms_add Ms_add1;
        public static Ms Ms1;
        public Ms()
        {
            InitializeComponent();
            this.button1.Tag = "Create";
            this.button3.Tag = "Delete";
            this.button2.Tag = "Edit";
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 5); // 1是模块ID
            permissionManager.ApplyPermissions(this);
            Ms1 = this;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
        }


        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=lwx;Password=luowenxin";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 移库单表";
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
        int n = 0;
        string[] strcomm = new string[100];
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            //string strrow = dataGridView1.Rows[e.RowIndex].Cells["移库单编号"].Value.ToString();//获取焦点触发行的第一个值
            //string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值

            //strcomm[n] = "update 移库单表 set " + strcolumn + "='" + value + "'where 移库单编号 = " + strrow;

            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["移库单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = $"UPDATE 移库单表 SET {strcolumn}='{value}' WHERE 移库单编号 ='{strrow}'";
            n++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ms_add1 = new Ms_add();
            Ms_add1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;//整个表格只读
            button12.Visible = true;
            button13.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["移库单编号"].Value.ToString();
                    string delesql = "DELETE FROM 移库单表 WHERE 移库单编号 = @移库单编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@移库单编号", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView1.Rows.Remove(row);
                }
                SysLogService.AddSysLog(new SysLog("删除移库单表数据", "触发", LogTye.操作记录, login.login1.userid));
            }
        }

        private void button12_Click(object sender, EventArgs e)
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
                button12.Visible = false;
                button13.Visible = false;
                dataGridView1.ReadOnly = true;//整个表格只读
                SysLogService.AddSysLog(new SysLog("修改移库单表数据", "触发", LogTye.操作记录, login.login1.userid));
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button12.Visible = false;
                button13.Visible = false;
                dataGridView1.ReadOnly = true;//整个表格只读
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 移库单表 where 1=1";
            if (textBox1.Text != "")

            {
                selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 物料编码 like'%" + textBox2.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 移库单编号 like'%" + textBox3.Text + "%'";
            }

            string start1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            //取开始时间的0点，大于等于开始日期的0点；
            string end1 = dateTimePicker2.Value.AddDays(1).Date.ToString("yyyy-MM-dd");
            //取结束时间第二天的0点，小于（没有等于）结束第二天的0点；

            var paras = new Dictionary<string, string> { { "start1", start1 }, { "end1", end1 } };
            if (checkBox1.Checked)
            {

                selectsql += "and 移库日期 >= @start1 AND 移库日期 <@end1";


            }
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            foreach (var par in paras)
            {
                //设置sqlCommand的参数
                da.SelectCommand.Parameters.AddWithValue(par.Key, par.Value);
            }
            da.Fill(dt1);
            conn.Close();
            dataGridView1.DataSource = dt1;

        }

        private void Ms_Load(object sender, EventArgs e)
        {
            SqlConnection sc1;

            string connstr1 = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=lwx;Password=luowenxin";

            DataTable dt = new DataTable();
            using (sc1 = new SqlConnection(connstr1))
            {
                sc1.Open();
                string sql = "select * from 移库单表";
                SqlDataAdapter sdr = new SqlDataAdapter(sql, sc1);
                sdr.Fill(dt);
            }
            this.dataGridView1.DataSource = dt;
        }
    }
}
