using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1.工作界面
{
    public partial class workplat1 : UserControl
    {
        public TaskRepository taskRepository;
        public PublishTaskForm PublishTaskForm1;
        private string currentUserFullName;

        public workplat1()
        {
            InitializeComponent();
            taskRepository = new TaskRepository();
            LoadTasks();
            dataGridViewTasks.SelectionChanged += dgvTasks_SelectionChanged;
        }



        public void LoadTasks()
        {
            List<TaskItem> tasks = taskRepository.GetNowEmpTasks();
            dataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void LoadIncompleteTasks()
        {
            List<TaskItem> tasks = taskRepository.GetIncompleteTasks();
            dataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void LoadCompletedTasks()
        {
            List<TaskItem> tasks = taskRepository.GetCompletedTasks();
            dataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void LoadNowEmpTasks()
        {
            List<TaskItem> tasks = taskRepository.GetNowEmpTasks();
            dataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void SetDataGridViewColumnHeaders()
        {
            // 设置 DataGridView 的列标题为中文
            dataGridViewTasks.Columns["TaskId"].HeaderText = "任务ID";
            dataGridViewTasks.Columns["TaskType"].HeaderText = "类型";
            dataGridViewTasks.Columns["TaskStatus"].HeaderText = "状态";
            dataGridViewTasks.Columns["TaskSubject"].HeaderText = "主题";
            dataGridViewTasks.Columns["TaskContent"].HeaderText = "内容";
            dataGridViewTasks.Columns["Executor"].HeaderText = "执行人";
            dataGridViewTasks.Columns["Initiator"].HeaderText = "发起人";
            dataGridViewTasks.Columns["InitiationTime"].HeaderText = "发起时间";
            dataGridViewTasks.Columns["ExecutionTime"].HeaderText = "执行时间";
            dataGridViewTasks.Columns["Deadline"].HeaderText = "执行期限";
            dataGridViewTasks.Columns["CompletionTime"].HeaderText = "完成时间";
            dataGridViewTasks.Columns["Action"].HeaderText = "操作";
            dataGridViewTasks.Columns["ResponseContent"].HeaderText = "回复内容";
            // 隐藏任务ID列
            dataGridViewTasks.Columns["TaskId"].Visible = false;
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTasks.SelectedRows[0];
                var selectedTask = (TaskItem)selectedRow.DataBoundItem;
                richTextBox1.Text = selectedTask.TaskContent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PublishTaskForm1 = new PublishTaskForm();
            PublishTaskForm1.ShowDialog();
            if (PublishTaskForm1.DialogResult == DialogResult.OK)
            {
                LoadTasks();
            }
        }

        private void compeletebutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTasks.SelectedRows[0];
                var selectedTask = (TaskItem)selectedRow.DataBoundItem;
                selectedTask.TaskStatus = "已完成";
                selectedTask.CompletionTime = DateTime.Now;
                taskRepository.UpdateTask(selectedTask);
                SysLogService.AddSysLog(new SysLog("修改任务状态", "触发", LogTye.操作记录, login.login1.userid));
                LoadTasks();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTasks.SelectedRows[0];
                var selectedTask = (TaskItem)selectedRow.DataBoundItem;

                if (selectedTask.Initiator == currentUserFullName)
                {
                    taskRepository.DeleteTask(selectedTask.TaskId);
                    SysLogService.AddSysLog(new SysLog("删除任务数据", "触发", LogTye.操作记录, login.login1.userid));
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("只有发起人才能删除任务。");
                }
            }
        }

        private void replybutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTasks.SelectedRows[0];
                var selectedTask = (TaskItem)selectedRow.DataBoundItem;

                using (var replyForm = new ReplyForm())
                {
                    if (replyForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedTask.ResponseContent = replyForm.ReplyText;
                        taskRepository.UpdateTask(selectedTask);
                        SysLogService.AddSysLog(new SysLog("任务回复", "触发", LogTye.操作记录, login.login1.userid));
                        LoadTasks();
                    }
                }
            }
        }

        private void allbutton_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void uncompeletebutton_Click(object sender, EventArgs e)
        {
            LoadIncompleteTasks();
        }

        private void compeletebutton_Click_1(object sender, EventArgs e)
        {
            LoadCompletedTasks();
        }

        private void nowEmpTasksButton_Click(object sender, EventArgs e)
        {
            LoadNowEmpTasks();
        }
    }
}
