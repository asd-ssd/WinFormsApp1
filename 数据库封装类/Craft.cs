using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    [SugarTable("工艺路线表")] // 指定 User 类对应的数据库表名为 "用户信息表"
    public class Craft
    {
        [SugarColumn(ColumnName = "工序", IsPrimaryKey = true)]
        public int CraftId { get; set; }

        [SugarColumn(ColumnName = "工序名称")]
        public string CraftName { get; set; }
    }
}
