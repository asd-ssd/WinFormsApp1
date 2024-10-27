using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [SugarTable("TaskItems")]
    public class TaskItem
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int TaskId { get; set; }
        public string TaskType { get; set; }
        public string TaskStatus { get; set; }
        public string TaskSubject { get; set; }
        public string TaskContent { get; set; }
        public string Executor { get; set; }
        public string Initiator { get; set; }
        public DateTime InitiationTime { get; set; }
        public DateTime ExecutionTime { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? CompletionTime { get; set; }
        public string Action { get; set; }
        public string ResponseContent { get; set; }
    }

}
