using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    public class SysLog
    {
        public SysLog()
        {

        }
        public SysLog(string logInfo, string logAlarmState, LogTye logType, string user)
        {
            LogTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            LogInfo = logInfo;
            LogAlarmState = logAlarmState;
            LogType = logType;
            User = user;
        }

        [SugarColumn(ColumnName = "日志编号", IsPrimaryKey = true, IsIdentity = true)] // 将 LogID 属性映射到数据库表的 "日志编号" 列，作为主键并自增
        public int LogID { get; set; }
        [SugarColumn(ColumnName = "操作时间")] // 将 LogTime 属性映射到数据库表的 Log_Time 列
        public string LogTime { get; set; }

        [SugarColumn(ColumnName = "日志内容")] // 将 LogInfo 属性映射到数据库表的 Log_Info 列
        public string LogInfo { get; set; }
        [SugarColumn(ColumnName = "报警状态")] // 将 LogType 属性映射到 Log_Type 列
        public string LogAlarmState { get; set; }
        [SugarColumn(ColumnName = "日志类型")] // 将 LogAlarmState 属性映射到 Log_Alarm_State 列
        public LogTye LogType { get; set; }
        [SugarColumn(ColumnName = "执行人")] // 将 User 属性映射到 User_Name 列
        public string User { get; set; }

    }

    /// <summary>
    /// 日志类型
    /// </summary>
    public enum LogTye
    {
        日志信息,
        报警信息,
        操作记录
    }
}
