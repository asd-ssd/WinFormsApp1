using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    [SugarTable("BOM表")] // 指定 User 类对应的数据库表名为 "用户信息表"
    public class BOM
    {
        [SugarColumn(ColumnName = "物料编码", IsPrimaryKey = true)]
        public string BOMId { get; set; }

        [SugarColumn(ColumnName = "物料名称")]
        public string BOMName { get; set; }
    }
}
