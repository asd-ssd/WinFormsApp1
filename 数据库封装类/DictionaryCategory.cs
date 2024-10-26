using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    public class DictionaryCategory
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
