using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    public class UserRole
    {
        [SugarColumn(ColumnName = "用户编号", IsPrimaryKey = true)]
        public string UserName { get; set; }

        [SugarColumn(ColumnName = "角色编号", IsPrimaryKey = true)]
        public int RoleId { get; set; }
    }
}
