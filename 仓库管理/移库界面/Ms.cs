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

namespace WinFormsApp1.仓库管理.移库界面
{
    public partial class Ms : UserControl
    {
        private readonly PermissionService _permissionService;
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
