using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class userroleset : Form
    {
        public userroleset()
        {
            InitializeComponent();
            LoadUsers();
            LoadRoles();
        }
        private void LoadUsers()
        {
            // 查询所有用户并绑定到 ListBox
            var users = SqlSugarHelper.SqlSugarClient.Queryable<User>().ToList();
            lstUsers.DataSource = users;
            lstUsers.DisplayMember = "UserName";
            lstUsers.ValueMember = "UserName"; // 用户名作为唯一标识
        }

        private void LoadRoles()
        {
            // 查询所有角色并绑定到 CheckedListBox
            var roles = SqlSugarHelper.SqlSugarClient.Queryable<Role>().ToList();
            clbRoles.DataSource = roles;
            clbRoles.DisplayMember = "RoleName";
            clbRoles.ValueMember = "RoleId"; // 角色编号作为唯一标识
                                             // 绑定 ListBox 的选择事件
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
        }
        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 清除所有已选中的角色
            for (int i = 0; i < clbRoles.Items.Count; i++)
            {
                clbRoles.SetItemChecked(i, false);
            }

            // 获取选中的用户
            var selectedUser = lstUsers.SelectedItem as User;
            if (selectedUser == null)
            {
                return;
            }

            // 查询该用户已有的角色
            var userRoles = SqlSugarHelper.SqlSugarClient.Queryable<UserRole>()
                .Where(ur => ur.UserName == selectedUser.UserName)
                .ToList();

            // 根据查询结果，勾选用户已拥有的角色
            foreach (var userRole in userRoles)
            {
                // 找到对应角色在 CheckedListBox 中的位置，并选中该项
                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    var role = clbRoles.Items[i] as Role;
                    if (role != null && role.RoleId == userRole.RoleId)
                    {
                        clbRoles.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择至少一个用户");
                return;
            }

            if (clbRoles.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择至少一个角色");
                return;
            }

            try
            {
                // 遍历所有选中的用户
                foreach (var selectedUser in lstUsers.SelectedItems)
                {
                    var userName = (selectedUser as User).UserName;

                    // 遍历所有选中的角色
                    foreach (var checkedRole in clbRoles.CheckedItems)
                    {
                        var roleId = (checkedRole as Role).RoleId;

                        // 检查该用户是否已经具有该角色
                        var existingUserRole = SqlSugarHelper.SqlSugarClient.Queryable<UserRole>()
                            .Where(ur => ur.UserName == userName && ur.RoleId == roleId)
                            .First();

                        if (existingUserRole != null)
                        {
                            // 如果已经存在，执行更新操作（可以根据需要调整字段更新逻辑）
                            existingUserRole.RoleId = roleId;
                            SqlSugarHelper.SqlSugarClient.Updateable(existingUserRole).ExecuteCommand();
                            MessageBox.Show($"用户 {userName} 的角色 {checkedRole} 已更新");
                        }
                        else
                        {
                            // 如果不存在，执行添加操作
                            var newUserRole = new UserRole
                            {
                                UserName = userName,
                                RoleId = roleId
                            };
                            SqlSugarHelper.SqlSugarClient.Insertable(newUserRole).ExecuteCommand();
                            MessageBox.Show($"用户 {userName} 已被赋予新角色 {checkedRole}");
                        }
                    }
                }

                MessageBox.Show("角色已成功赋予或更新给选定用户");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"操作时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
