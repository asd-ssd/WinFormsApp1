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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.仓库管理.入库界面
{
    public partial class Is : UserControl
    {
        private readonly PermissionService _permissionService;
        public Is_add Is_add1;
        private string Date_start, Date_end;
        int Date_start1, Date_end1;
        public static Is is1;
    
        public Is()
        {
            InitializeComponent();
            is1 = this;
            this.button1.Tag = "Create";
            this.button3.Tag = "Delete";
            this.button2.Tag = "Edit";
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 5); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }

        private void Is_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }
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
                string strda = "select * from 入库单表";
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
        private void button4_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Is_add1 = new Is_add();
            Is_add1.Show();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 入库单表 where 1=1";
            /*if (textBox1.Text != "")

            {
                selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
            }*/
            if (textBox2.Text != "")
            {
                selectsql += "and 物料编码 like'%" + textBox2.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 入库单编号 like'%" + textBox3.Text + "%'";
            }
            if (Date_start1 != 0 || Date_end1 != 0)
            {
                selectsql += "select * from 入库单表 where 入库时间 in（" + Date_start + "," + Date_end + "）";
            }

            SqlConnection conn = connection();
            conn.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt1);
            conn.Close();
            dataGridView1.DataSource = dt1;
            MessageBox.Show("查询成功！");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // 假设已经有一个名为dateTimePicker1的DateTimePicker控件  
            DateTime selectedDate = dateTimePicker1.Value;
            Date_start = selectedDate.ToString("yyyy-MM-dd");
            Date_start1 = 1;
            MessageBox.Show("选中的日期和时间是：" + Date_start);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // 假设已经有一个名为dateTimePicker1的DateTimePicker控件  
            DateTime selectedDate = dateTimePicker2.Value;
            Date_end = selectedDate.ToString("yyyy-MM-dd");
            Date_end1 = 0;
            MessageBox.Show("选中的日期和时间是：" + Date_end);
        }
        int n = 0;
        string[] strcomm = new string[100];
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            //string strrow = dataGridView1.Rows[e.RowIndex].Cells["入库单编号"].Value.ToString();//获取焦点触发行的第一个值
            //string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值

            //strcomm[n] = "update 入库单表 set " + strcolumn + "='" + value + "'where 入库单编号 = " + strrow;

            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["入库单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = $"UPDATE 入库单表 SET {strcolumn}='{value}' WHERE 入库单编号 ='{strrow}'";
            n++;
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
                GetDataGridView();
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;//整个表格只读
            button12.Visible = true;
            button13.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["入库单编号"].Value.ToString();
                    string delesql = "DELETE FROM 入库单表 WHERE 入库单编号 = @入库单编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@入库单编号", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}
        /* private void button7_Click(object sender, EventArgs e)
{
String str1 = textBox3.Text;
String str2 = "SELECT NAME,SEX FROM PERSON WHERE P#='" + str1 + "'";

dataGridView1.DataSource = d1;   //将查询结果放入到dataGridView；



}
public DataTable SelectData()
{
DataTable dataTable = new DataTable();

string query = "SELECT * FROM YourTableName";
using (SqlCommand command = new SqlCommand(query, connection))
{
   using (SqlDataAdapter adapter = new SqlDataAdapter(command))
   {
       connection.Open();
       adapter.Fill(dataTable);
   }
}

return dataTable;
}*/

