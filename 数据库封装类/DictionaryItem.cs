using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    public class DictionaryItem
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string ItemName { get; set; }
        public string ItemValue { get; set; }
        public string Description { get; set; }
    }

}
