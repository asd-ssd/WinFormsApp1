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
using WinFormsApp1.计划管理.完成;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace WinFormsApp1.计划管理.三级
{

    public partial class 车间作业 : UserControl
    {
        public static 车间作业 chejian1;
        public 工序排程 gong1;
        public 领料 ling1;
        public 车间完成 chew;
        public 车间作业()
        {
            InitializeComponent();
            chejian1 = this;
        }
        public string Item_number;
        public string Item_am;
        public string Start;
        public string MRP_number;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        string[] strcomm = new string[100];
        int n = 0;
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from MRP where 1=1 and 物料来源 = '生产'";

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

        private void 车间作业_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Item_number = row.Cells["物料编号"].Value.ToString();
                Item_am = row.Cells["需求量"].Value.ToString();
                Start = row.Cells["开始日期"].Value.ToString();
                MRP_number = row.Cells["MRP编号"].Value.ToString();
            }
            gong1 = new 工序排程();
            gong1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetDataGridView();
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
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["MRP编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值

            strcomm[n] = $"UPDATE MRP SET {strcolumn} = '{value}' WHERE MRP编号 = '{strrow}'";
            n++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["MRP编号"].Value.ToString();
                    string delesql = "DELETE FROM MRP WHERE MRP编号 = @MRP编号";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@MRP编号", id);
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
            string selectsql = "select * from MRP where 1=1";
            string start1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            //取开始时间的0点，大于等于开始日期的0点；
            string end1 = dateTimePicker2.Value.AddDays(1).Date.ToString("yyyy-MM-dd");
            //取结束时间第二天的0点，小于（没有等于）结束第二天的0点；
            var paras = new Dictionary<string, string> { { "start1", start1 }, { "end1", end1 } };
            if (checkBox1.Checked)
            {
                selectsql += "and 状态 ='%" + "未完成" + "%'";
            }
            if (checkBox2.Checked)
            {
                selectsql += "and 状态 ='%" + "已完成" + "%'";
            }

            if (checkBox3.Checked)
            {
                selectsql += "and 开始日期 >= @start1 AND 开始日期 <@end1";
            }
            if (checkBox4.Checked)
            {
                selectsql += "and 物料编号 like'%" + textBox1.Text + "%'";
            }
            if (checkBox5.Checked)
            {
                selectsql += "and 主计划编号 like'%" + textBox3.Text + "%'";
            }
            if (checkBox6.Checked)
            {
                selectsql += "and MRP编号 like'%" + textBox2.Text + "%'";
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
            button6.Visible = true;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button6.Visible = false;
                button7.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Item_number = row.Cells["物料编号"].Value.ToString();
                Item_am = row.Cells["需求量"].Value.ToString();
                Start = row.Cells["开始日期"].Value.ToString();
                MRP_number = row.Cells["MRP编号"].Value.ToString();
            }
            ling1 = new 领料();
            ling1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Item_number = row.Cells["物料编号"].Value.ToString();
                Item_am = row.Cells["需求量"].Value.ToString();
                Start = row.Cells["开始日期"].Value.ToString();
                MRP_number = row.Cells["MRP编号"].Value.ToString();
            }
            chew = new 车间完成();
            chew.Show();
        }
    }
}
