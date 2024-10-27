using SqlSugar;
using System.Collections.Generic;
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

    public List<TaskItem> GetAllTasks()
    {
        return db.Queryable<TaskItem>().ToList();
    }
}
