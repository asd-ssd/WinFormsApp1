using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    public class Permission
    {
        public Permission() { }
        [SugarColumn(ColumnName = "PermissionId", IsPrimaryKey = true, IsIdentity = true)]
        public int PermissionId { get; set; }
        [SugarColumn(ColumnName = "角色编号")]
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public int ViewPermission { get; set; }   // 0 或 1，表示是否具有查看权限
        public int CreatePermission { get; set; } // 0 或 1，表示是否具有创建权限
        public int DeletePermission { get; set; } // 0 或 1，表示是否具有删除权限
        public int EditPermission { get; set; }   // 0 或 1，表示是否具有编辑权限

        public Permission(int roleId, int moduleId, int viewPermission, int createPermission, int deletePermission, int editPermission)
        {
            RoleId = roleId;
            ModuleId = moduleId;
            ViewPermission = viewPermission;
            CreatePermission = createPermission;
            DeletePermission = deletePermission;
            EditPermission = editPermission;
        }
        public bool HasPermission(string permission)
        {
            return permission switch
            {
                "View" => ViewPermission == 1,
                "Create" => CreatePermission == 1,
                "Delete" => DeletePermission == 1,
                "Edit" => EditPermission == 1,
                _ => false,
            };
        }
    }

}
