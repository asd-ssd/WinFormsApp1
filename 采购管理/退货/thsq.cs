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
using WinFormsApp1.采购管理.退货;

namespace WinFormsApp1.采购管理
{
    public partial class thsq : UserControl
    {
        private readonly PermissionService _permissionService;
        public thsq1 thsq11;
        public thcxy thcxy1;

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
                string strda = "select * from 退货表";
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
        public thsq()
        {
            InitializeComponent();
            this.button6.Tag = "Create";
          //  this.button6.Tag = "Delete";
           // this.button1.Tag = "Edit";
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 4); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void thsq_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thsq11 = new thsq1();
            thsq11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thcxy1 = new thcxy();
            thcxy1.Show();
        }
    }
}
