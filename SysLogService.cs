using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace WinFormsApp1
{
    public class SysLogService
    {

        /// <summary>
        /// 插入一条记录
        /// </summary>
        /// <param name="log">日志记录对象</param>
        /// <returns>是否成功</returns>
        public static bool AddSysLog(SysLog log)
        {
            return SqlSugarHelper.SqlSugarClient.Insertable(log).ExecuteCommand() == 1;
        }
        /// <summary>
        /// 获取所有日志记录。
        /// </summary>
        /// <returns>日志记录列表。</returns>
        public static DataTable GetAllSysLogsAsDataTable()
        {
            try
            {
                using (var db = SqlSugarHelper.SqlSugarClient)
                {
                    // 执行 SQL 查询，获取所有日志记录
                    var dataTable = db.Ado.GetDataTable("SELECT * FROM SysLog ORDER BY 操作时间 DESC");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["日志类型"] != DBNull.Value)
                        {
                            int logTypeValue = Convert.ToInt32(row["日志类型"]);
                            switch (logTypeValue)
                            {
                                case 0:
                                    row["日志类型"] = "日志信息";
                                    break;
                                case 1:
                                    row["日志类型"] = "报警信息";
                                    break;
                                case 2:
                                    row["日志类型"] = "操作记录";
                                    break;
                            }
                        }
                    }
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                // 记录错误日志，方便排查问题
                return new DataTable();
            }
        }
        /// <summary>
        /// 查询日志信息
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="logtype">日志类型</param>
        /// <param name="logAlarmState">报警状态</param>
        /// <returns></returns>
        public static List<SysLog> GetSysLogByCondiiton(string start, string end, string logtype, string logAlarmState)
        {
            //根据时间查询
            var query = SqlSugarHelper.SqlSugarClient.Queryable<SysLog>().Where(c => SqlFunc.Between(c.LogTime, start, end));

            //日志类型
            if (logtype.Length > 0)
            {
                query.Where(c => c.LogType == (LogTye)Enum.Parse(typeof(LogTye), logtype));
            }

            //报警状态
            if (logAlarmState.Length > 0)
            {
                query.Where(c => c.LogAlarmState == logAlarmState);
            }

            return query.ToList();
        }
   
    
    }
}
