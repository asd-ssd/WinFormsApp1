using System;
using System.Configuration;
using System.Windows.Forms;

namespace WinFormsApp1.数据库支持类
{
    public class PermissionManager
    {
        private readonly PermissionService _permissionService;
        private readonly int _currentUserRoleId;
        private readonly int _moduleId;

        public PermissionManager(PermissionService permissionService, int moduleId)
        {
            _permissionService = permissionService;
            _currentUserRoleId = GetCurrentUserRoleId(); // 在这里获取当前用户角色ID
            _moduleId = moduleId;
        }

        // 获取当前用户角色ID，从配置文件中读取
        private int GetCurrentUserRoleId()
        {
            // 从配置文件中获取角色编号
            var roleIdString = ConfigurationManager.AppSettings["角色编号"];

            if (int.TryParse(roleIdString, out int roleId))
            {
                return roleId; // 返回解析后的角色ID
            }

            // 如果角色ID未找到或无法解析，则返回一个默认值或抛出异常
            throw new InvalidOperationException("角色编号未设置或格式不正确。");
        }

        // 检查并设置控件的可用性
        public void ApplyPermissions(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                // 检查控件的权限
                if (control.Tag != null && control.Tag is string permission)
                {
                    SetControlEnabled(control, permission);
                }
                // 递归检查子控件
                if (control.HasChildren)
                {
                    ApplyPermissions(control);
                }
            }
        }


        public void ApplyOnly(Control control)
        {
            // 检查控件的权限
            if (control.Tag != null && control.Tag is string permission)
            {
                SetControlEnabled(control, permission);
            }

        }
        // 设置控件的可用性
        private void SetControlEnabled(Control control, string permission)
        {
            bool hasPermission = _permissionService.HasPermission(_currentUserRoleId, _moduleId, permission);

            if (!hasPermission)
            {
                control.Tag = permission; // Store permission in Tag for later use
                control.MouseDown += PermissionDeniedMouseHandler;
                control.PreviewKeyDown += PermissionDeniedKeyHandler;
            }
            else
            {
                control.MouseDown -= PermissionDeniedMouseHandler;
                control.PreviewKeyDown -= PermissionDeniedKeyHandler;
                control.Enabled = true;
            }
        }

        private void PermissionDeniedMouseHandler(object sender, MouseEventArgs e)
        {
            ShowPermissionDeniedMessage();
        }

        private void PermissionDeniedKeyHandler(object sender, PreviewKeyDownEventArgs e)
        {
            ShowPermissionDeniedMessage();
        }

        private void ShowPermissionDeniedMessage()
        {
            MessageBox.Show("您没有执行此操作的权限。", "权限拒绝", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
