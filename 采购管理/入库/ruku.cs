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

namespace WinFormsApp1.采购管理.入库
{
    public partial class ruku : UserControl
    {
        private readonly PermissionService _permissionService;
        public cxy cxy1;
        public xjy xjy1;

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
                string strda = "select * from 采购入库表";
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
        public ruku()
        {
            InitializeComponent();
            this.button1.Tag = "Create";
            this.button2.Tag = "Delete";
           // this.button1.Tag = "Edit";
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 4); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }

        private void ruku_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xjy1 = new xjy();
            xjy1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cxy1 = new cxy();
            cxy1.Show();
        }
    }
}
