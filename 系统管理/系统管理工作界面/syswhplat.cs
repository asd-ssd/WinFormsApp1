using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using WinFormsApp1.系统管理设置界面;

namespace WinFormsApp1.系统管理工作界面
{
    public partial class syswhplat : UserControl
    {
        private PermissionService _permissionService;
        public sysset sysset1;
        private int _selectedRoleId;
        public static syswhplat syswhplat1;
        public userroleset userroleset1;
        public syswhplat()
        {
            InitializeComponent();
            syswhplat1 = this;
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            LoadRoles();
            // 绑定角色列表的选择事件
            roleTreeView.NodeMouseDoubleClick += RoleTreeView_NodeMouseDoubleClick;
            this.button4.Tag = "Create";
            this.button3.Tag = "Edit";
            this.button2.Tag = "Edit";
            this.button5.Tag = "Delete";
            var permissionManager = new PermissionManager(_permissionService, moduleId: 6); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }

        // 当用户选择角色时调用此方法
        private void RoleTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selectedRoleName = e.Node.Text;
            var role = _permissionService.GetAllRoles().FirstOrDefault(r => r.RoleName == selectedRoleName);
            if (role != null)
            {
                _selectedRoleId = role.RoleId;
                LoadPermissionsForRole(_selectedRoleId);
            }
        }
        private void LoadPermissionsForRole(int roleId)
        {
            // 假设 moduleId 对应每个模块
            var moduleIds = new List<int> { 1, 2, 3, 4, 5, 6 }; // 根据实际模块数量调整
            foreach (var moduleId in moduleIds)
            {
                var permissions = _permissionService.GetPermission(roleId, moduleId);

                // 根据权限设置复选框状态，假设模块对应的复选框命名规则为 chkView_Module1, chkCreate_Module1 等
                CheckBox chkView = tableLayoutPanel3.Controls.Find($"chkView_Module{moduleId}", true).FirstOrDefault() as CheckBox;
                CheckBox chkCreate = tableLayoutPanel3.Controls.Find($"chkCreate_Module{moduleId}", true).FirstOrDefault() as CheckBox;
                CheckBox chkDelete = tableLayoutPanel3.Controls.Find($"chkDelete_Module{moduleId}", true).FirstOrDefault() as CheckBox;
                CheckBox chkEdit = tableLayoutPanel3.Controls.Find($"chkEdit_Module{moduleId}", true).FirstOrDefault() as CheckBox;

                if (chkView != null)
                    chkView.Checked = permissions.ViewPermission == 1;
                if (chkCreate != null)
                    chkCreate.Checked = permissions.CreatePermission == 1;
                if (chkDelete != null)
                    chkDelete.Checked = permissions.DeletePermission == 1;
                if (chkEdit != null)
                    chkEdit.Checked = permissions.EditPermission == 1;
            }
        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_selectedRoleId <= 0)
            {
                MessageBox.Show("请选择一个角色进行修改");
                return;
            }
            else if (MessageBox.Show("确实要修改吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var moduleIds = new List<int> { 1, 2, 3, 4, 5, 6 }; // 根据实际模块数量调整

                    foreach (var moduleId in moduleIds)
                    {
                        // 查找复选框
                        CheckBox chkView = tableLayoutPanel3.Controls.Find($"chkView_Module{moduleId}", true).FirstOrDefault() as CheckBox;
                        CheckBox chkCreate = tableLayoutPanel3.Controls.Find($"chkCreate_Module{moduleId}", true).FirstOrDefault() as CheckBox;
                        CheckBox chkDelete = tableLayoutPanel3.Controls.Find($"chkDelete_Module{moduleId}", true).FirstOrDefault() as CheckBox;
                        CheckBox chkEdit = tableLayoutPanel3.Controls.Find($"chkEdit_Module{moduleId}", true).FirstOrDefault() as CheckBox;

                        // 获取复选框的状态并转换为权限值
                        int viewPermission = chkView != null && chkView.Checked ? 1 : 0;
                        int createPermission = chkCreate != null && chkCreate.Checked ? 1 : 0;
                        int deletePermission = chkDelete != null && chkDelete.Checked ? 1 : 0;
                        int editPermission = chkEdit != null && chkEdit.Checked ? 1 : 0;

                        // 更新到数据库
                        _permissionService.AddOrUpdatePermission(
                            _selectedRoleId,
                            moduleId,
                            viewPermission,
                            createPermission,
                            deletePermission,
                            editPermission
                        );
                    }

                    MessageBox.Show("权限已更新");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"更新权限时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void LoadRoles()
        {
            var roles = _permissionService.GetAllRoles();
            PopulateTreeView(roles);
        }
        private void PopulateTreeView(List<Role> roles)
        {
            // 清空现有的 TreeView 节点
            roleTreeView.Nodes.Clear();

            // 使用角色组进行分组
            var groupedRoles = roles.GroupBy(r => r.RoleGroup);

            // 遍历每个角色组
            foreach (var roleGroup in groupedRoles)
            {
                // 创建角色组节点
                TreeNode groupNode = new TreeNode(roleGroup.Key)
                {
                    Name = roleGroup.Key // 节点名称为角色组名
                };

                // 遍历角色组中的角色
                foreach (var role in roleGroup)
                {
                    // 创建角色节点
                    TreeNode roleNode = new TreeNode(role.RoleName)
                    {
                        Name = role.RoleId.ToString(), // 使用角色编号作为节点名称
                        Tag = role // 将角色对象存储在 Tag 中，方便后续操作
                    };

                    // 将角色节点添加到角色组节点
                    groupNode.Nodes.Add(roleNode);
                }

                // 将角色组节点添加到 TreeView 中
                roleTreeView.Nodes.Add(groupNode);
            }

            // 展开所有节点
            roleTreeView.ExpandAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sysset1 = new sysset();
            sysset1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userroleset1 = new userroleset();
            userroleset1.ShowDialog();
        }
    }
}
