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

using WinFormsApp1.销售管理.收发货管理.退货;
using WinFormsApp1.销售管理.销售订单管理.收款单;

namespace WinFormsApp1.销售管理
{
    public partial class Receipt2nd : Form
    {
        public DataGridView rfdataGridView1 = ReceiptForm.receiptForm.rfdataGridView1;
        public Receipt2nd()
        {
            InitializeComponent();
        }

        private void r2date_Click(object sender, EventArgs e)
        {

        }

        private void r2button1_Click(object sender, EventArgs e)
        {

        }

        private void r2button2_Click(object sender, EventArgs e)
        {

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
        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 收款单(收款单编号,收款日期,客户,收款人,收款金额) values('" + textBox1.Text + "','" + dateTimePicker1.Value + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void r2save_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("添加成功！");
            this.Close();
        }

        private void r2number_Click(object sender, EventArgs e)
        {

        }

        private void Receipt2nd_Load(object sender, EventArgs e)
        {

        }
    }
}
