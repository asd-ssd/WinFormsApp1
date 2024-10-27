using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    [SugarTable("用户信息表")] // 指定 User 类对应的数据库表名为 "用户信息表"
    public class User
    {
        [SugarColumn(ColumnName = "用户名", IsPrimaryKey = true)]
        public string UserName { get; set; }

        [SugarColumn(ColumnName = "密码")]
        public string Password { get; set; }

        [SugarColumn(ColumnName = "密码盐")]
        public string PasswordSalt { get; set; }

        [SugarColumn(ColumnName = "员工编号")]
        public string EmployeeId { get; set; }

        [SugarColumn(ColumnName = "创建时间")]
        public DateTime CreatedAt { get; set; }

        [SugarColumn(ColumnName = "备注")]
        public string Remark { get; set; }

        public User() { }

        public User(string userName, string password, string passwordSalt, string employeeid, DateTime createdAt, string remark)
        {
            UserName = userName;
            Password = password;
            PasswordSalt = passwordSalt;
            EmployeeId = employeeid;
            CreatedAt = createdAt;
            Remark = remark;
        }
    }
}
