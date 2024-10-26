using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1.仓库管理.库存盘点界面
{
    public partial class count_push_new : Form
    {
        private readonly PermissionService _permissionService;
        public count_push_new()
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
    }
}
