using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.系统管理工作界面;

namespace WinFormsApp1.系统管理设置界面
{
    public partial class sysset : Form
    {
        public sysset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roleName = txtRoleName.Text.Trim();
            string roleGroup = txtRoleGroup.Text.Trim();

            if (string.IsNullOrEmpty(roleName) || string.IsNullOrEmpty(roleGroup))
            {
                MessageBox.Show("请填写角色名和角色组");
                return;
            }

            try
            {
                // 创建新角色对象
                var newRole = new Role
                {
                    RoleName = roleName,
                    RoleGroup = roleGroup
                };

                // 将新角色插入到数据库，并获取新角色的ID
                int newRoleId = SqlSugarHelper.SqlSugarClient.Insertable(newRole).ExecuteReturnIdentity();

                // 获取所有模块ID（根据实际模块数量调整）
                var moduleIds = new List<int> { 1, 2, 3, 4, 5, 6 };

                // 初始化新角色的权限记录，将所有权限置为零
                foreach (var moduleId in moduleIds)
                {
                    var newPermission = new Permission
                    {
                        RoleId = newRoleId,
                        ModuleId = moduleId,
                        ViewPermission = 0,
                        CreatePermission = 0,
                        DeletePermission = 0,
                        EditPermission = 0
                    };

                    // 将新权限记录插入到权限表
                    SqlSugarHelper.SqlSugarClient.Insertable(newPermission).ExecuteCommand();
                }

                // 重新加载角色到 TreeView
                syswhplat.syswhplat1.LoadRoles();

                MessageBox.Show("新角色已添加，并已初始化所有权限为零，请设置权限后点击保存");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加角色时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
