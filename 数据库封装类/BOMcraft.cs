using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    public class BOMcraft
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)] // 设置主键
        public int ID { get; set; }
        [SugarColumn(ColumnName = "物料编码")]
        public string BOMId { get; set; }

        [SugarColumn(ColumnName = "工序")]
        public int CraftId { get; set; }
    }
}
