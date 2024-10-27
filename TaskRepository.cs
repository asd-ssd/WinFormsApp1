using SqlSugar;
using System.Collections.Generic;
using System.Configuration;
using WinFormsApp1;

public class TaskRepository
{
    private SqlSugarClient db;

    public TaskRepository()
    {
        db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531",
            DbType = DbType.SqlServer,
            IsAutoCloseConnection = true
        });
    }
    public string currentUser = ConfigurationManager.AppSettings["员工姓名"];
    public List<TaskItem> GetAllTasks()
    {
        return db.Queryable<TaskItem>().ToList();
    }
    public void AddTask(TaskItem task)
    {
        db.Insertable(task).ExecuteCommand();
    }
    public void UpdateTask(TaskItem task)
    {
        db.Updateable(task).ExecuteCommand();
    }
    public List<TaskItem> GetNowEmpTasks()
    {
        return db.Queryable<TaskItem>()
                .Where(t => t.Executor == currentUser || t.Initiator == currentUser)
                .ToList();
    }
    public List<TaskItem> GetInitiatorEmpTakks()
    {
        return db.Queryable<TaskItem>()
                .Where(t => t.Initiator == currentUser)
                .ToList();
    }
    public List<TaskItem> GetEXecutorEmpTakks()
    {
        return db.Queryable<TaskItem>()
                .Where(t => t.Executor == currentUser)
                .ToList();
    }
    public List<TaskItem> GetIncompleteTasks()
    {
        var tasks = db.Queryable<TaskItem>()
                  .Where(t => t.TaskStatus == "未完成" && (t.Executor == currentUser || t.Initiator == currentUser))
                  .ToList();
        return tasks;
    }

    public List<TaskItem> GetCompletedTasks()
    {
        var tasks = db.Queryable<TaskItem>()
                 .Where(t => t.TaskStatus == "已完成" && (t.Executor == currentUser || t.Initiator == currentUser))
                 .ToList();
        return tasks;
    }

    public List<TaskItem> GetTaskbydate(DateTime startDate,DateTime endDate)
    {
        var tasks = db.Queryable<TaskItem>()
                 .Where(t => t.InitiationTime>=startDate &&t.InitiationTime<=endDate && (t.Executor == currentUser || t.Initiator == currentUser))
                 .ToList();
        return tasks;
    }
    public void DeleteTask(int taskId)
    {
        db.Deleteable<TaskItem>().In(taskId).ExecuteCommand();
    }

}
