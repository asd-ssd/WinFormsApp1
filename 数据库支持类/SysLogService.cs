using System;
using System.Collections.Generic;
using System.Data;
using SqlSugar;
using WinFormsApp1.数据库封装类;

namespace WinFormsApp1.数据库支持类
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
        public static List<SysLog> GetAllSysLogs()
        {
            try
            {
                using (var db = SqlSugarHelper.SqlSugarClient)
                {
                    // 执行 SQL 查询，获取所有日志记录
                    var logs = db.Queryable<SysLog>().OrderBy(c => c.LogTime, OrderByType.Desc).ToList();

                    return logs;
                }
            }   
            catch (Exception ex)
            {
                // 记录错误日志，方便排查问题
                return new List<SysLog>(); // 返回一个空的列表以避免错误
            }
        }

        private static void ConvertLogTypes(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["日志类型"] != DBNull.Value)
                {
                    int logTypeValue = Convert.ToInt32(row["日志类型"]);
                    row["日志类型"] = logTypeValue switch
                    {
                        0 => "日志信息",
                        1 => "报警信息",
                        2 => "操作记录",
                        _ => row["日志类型"] // 未知类型保持原样
                    };
                }
            }
        }

        /// <summary>
        /// 查询日志信息
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="logtype">日志类型</param>
        /// <param name="logAlarmState">报警状态</param>
        /// <returns>符合条件的日志列表</returns>
        public static List<SysLog> GetSysLogByCondiiton(string start, string end, string logtype, string logAlarmState)
        {
            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(end))
                throw new ArgumentException("开始时间和结束时间不能为空");

            var query = SqlSugarHelper.SqlSugarClient.Queryable<SysLog>()
                .Where(c => SqlFunc.Between(c.LogTime, start, end));

            // 日志类型
            if (!string.IsNullOrEmpty(logtype))
            {
                // 使用枚举直接比较
                if (Enum.TryParse<LogTye>(logtype, out var logTypeEnum))
                {
                    query.Where(c => c.LogType == logTypeEnum);
                }
                else
                {
                    throw new ArgumentException("无效的日志类型");
                }
            }

            // 报警状态
            if (!string.IsNullOrEmpty(logAlarmState))
            {
                query.Where(c => c.LogAlarmState == logAlarmState);
            }

            return query.ToList();
        }
    }
}
