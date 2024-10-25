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


namespace WinFormsApp1.采购管理.采购审核
{
    public partial class shx : UserControl
    {
       
        public shcx shcx1;
        public static shx shx1;
        public shx()
        {
            InitializeComponent();
            shx1 = this;
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=zyx;Persist Security Info=True;User ID=zyx;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        

        private void GetDataGridView2()
        {
            try
            {
                string strda = "select * from 审核表";
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
        private void shx_Load(object sender, EventArgs e)
        {

            GetDataGridView2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shcx1 = new shcx();
            shcx1.Show();   //将窗体一进行显示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = false;//整个表格只读
            button4.Visible = true;
            
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView2.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView2.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView2.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = "update 审核表 set " + strcolumn + "='" + value + "'where 订单编号 = " + strrow;
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

                GetDataGridView2();
                n = 0;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

