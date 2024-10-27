using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    public class Role
    {
        public Role()
        {

        }

        [SugarColumn(ColumnName = "角色编号", IsPrimaryKey = true, IsIdentity = true)]
        public int RoleId { get; set; }
        [SugarColumn(ColumnName = "角色名")]
        public string RoleName { get; set; }

        [SugarColumn(ColumnName = "角色组")]
        public string RoleGroup { get; set; }
        public Role(string roleName, string roleGroup)
        {

            RoleName = roleName;
            RoleGroup = roleGroup;
        }
    }

}
