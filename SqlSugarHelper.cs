using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public  class SqlSugarHelper
    {
        //连接字符串
        public static string ConnectionString = string.Empty;
        //数据库类型
        public static DbType DBType = DbType.SqlServer;
        public static SqlSugarClient SqlSugarClient
        {
            get
            {
                return new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531",//必填, 数据库连接字符串 
                    DbType = DbType.SqlServer ,//选择数据库 sql server
                    IsAutoCloseConnection = true,//设置为true无需使用using或者Close操作，自动关闭连接，不需要手动关闭数据链接
                    InitKeyType = InitKeyType.Attribute //默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息
                });
            }

        }
    }
}
