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
using WinFormsApp1.采购管理.订单;

namespace WinFormsApp1.采购管理
{
    public partial class ddcx : UserControl
    {
        private readonly PermissionService _permissionService;
        public ddcxy ddcxy1;
        public ddxg ddxg1;

        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=zyx;Persist Security Info=True;User ID=zyx;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
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
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        public ddcx()
        {
            InitializeComponent();
            
            this.button3.Tag = "Delete";
            
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 4); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ddxg1 = new ddxg();
            ddxg1.Show();   //将窗体一进行显示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ddcxy1 = new ddcxy();
            ddcxy1.Show();   //将窗体一进行显示
        }

        private void ddcx_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }
    }
}
