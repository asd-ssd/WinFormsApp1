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
using WinFormsApp1.销售管理.销售订单管理.收款单;

namespace WinFormsApp1.销售管理
{

    public partial class ExamineForm : UserControl
    {

        public Examine2nd examine2Nd;
        public ExamineForm()
        {
            InitializeComponent();
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
                string strda = "select * from 订单";
                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strda, conn);
                da.Fill(dt);
                conn.Close();
                //dataGridView1.AutoGenerateColumns = true;//自动创建列
                //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                exdataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }


        private void ecreat_Click(object sender, EventArgs e)
        {
            examine2Nd = new Examine2nd();
            examine2Nd.Show();   //将窗体一进行显示

        }

        private void ExamineForm_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }
    }
}
