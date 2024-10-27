using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using WinFormsApp1.数据库封装类;


namespace WinFormsApp1.数据库支持类
{
    public class DictionaryService
    {
        public List<DictionaryItem> GetItemsByCategoryName(string categoryName)
        {
            var category = SqlSugarHelper.SqlSugarClient.Queryable<DictionaryCategory>()
                              .Where(c => c.CategoryName == categoryName)
                              .First();

            if (category == null)
            {
                return new List<DictionaryItem>();
            }

            return SqlSugarHelper.SqlSugarClient.Queryable<DictionaryItem>()
                        .Where(item => item.CategoryId == category.CategoryId)
                        .ToList();
        }
    }
}
