using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SqlSugar;
using WinFormsApp1.数据库封装类;

namespace WinFormsApp1.数据库支持类
{
    public class PermissionService
    {
        private readonly SqlSugarHelper _dbHelper;

        public PermissionService(SqlSugarHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        /// <summary>
        /// 获取所有角色
        /// </summary>
        public List<Role> GetAllRoles()
        {
            var roles = SqlSugarHelper.SqlSugarClient.Queryable<Role>().ToList();
            return roles;
        }

        /// <summary>
        /// 获取所有模块
        /// </summary>
        public List<Module> GetAllModules()
        {
            var modules = SqlSugarHelper.SqlSugarClient.Queryable<Module>().ToList();
            return modules;
        }

        /// <summary>
        /// 获取指定角色在指定模块中的权限
        /// </summary>
        public Permission GetPermission(int roleId, int moduleId)
        {
            var sql = @"
                SELECT PermissionId, 角色编号, ModuleId, ViewPermission, CreatePermission, DeletePermission, EditPermission 
                FROM Permission 
                WHERE 角色编号 = @RoleId AND ModuleId = @ModuleId AND 角色编号 IS NOT NULL AND ModuleId IS NOT NULL";

            var permissionRecord = SqlSugarHelper.SqlSugarClient.Ado.SqlQuerySingle<Permission>(sql, new
            {
                RoleId = roleId,
                ModuleId = moduleId
            });

            if (permissionRecord == null)
            {
                MessageBox.Show($"未找到角色ID {roleId} 和模块ID {moduleId} 对应的权限记录。");
                return null;
            }

            return permissionRecord;
        }

        /// <summary>
        /// 检查角色在模块中是否具有指定权限
        /// </summary>
        public bool HasPermission(int roleId, int moduleId, string permission)
        {
            var permissionRecord = GetPermission(roleId, moduleId);
            return permissionRecord?.HasPermission(permission) ?? false;
        }

        /// <summary>
        /// 为角色添加或更新权限到指定模块
        /// </summary>
        public void AddOrUpdatePermission(int roleId, int moduleId, int viewPermission, int createPermission, int deletePermission, int editPermission)
        {
            var existingPermission = GetPermission(roleId, moduleId);

            if (existingPermission == null)
            {
                // 添加新的权限记录
                var permission = new Permission(roleId, moduleId, viewPermission, createPermission, deletePermission, editPermission);
                SqlSugarHelper.SqlSugarClient.Insertable(permission).ExecuteCommand();
            }
            else
            {
                // 更新现有的权限记录
                existingPermission.ViewPermission = viewPermission;
                existingPermission.CreatePermission = createPermission;
                existingPermission.DeletePermission = deletePermission;
                existingPermission.EditPermission = editPermission;

                SqlSugarHelper.SqlSugarClient.Updateable(existingPermission).ExecuteCommand();
            }
        }

        /// <summary>
        /// 删除角色在指定模块中的权限
        /// </summary>
        public void RemovePermission(int roleId, int moduleId)
        {
            SqlSugarHelper.SqlSugarClient.Deleteable<Permission>()
                .Where(p => p.RoleId == roleId && p.ModuleId == moduleId)
                .ExecuteCommand();
        }
    }
}

