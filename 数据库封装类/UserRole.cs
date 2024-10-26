using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{

    public class UserRole
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)] // 设置主键
        public int URId { get; set; }
        [SugarColumn(ColumnName = "用户编号")]
        public string UserName { get; set; }

        [SugarColumn(ColumnName = "角色编号")]
        public int RoleId { get; set; }
    }
}
