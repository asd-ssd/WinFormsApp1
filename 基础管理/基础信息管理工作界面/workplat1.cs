using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.工作界面
{
    public partial class workplat1 : UserControl
    {
        public TaskRepository taskRepository;
        public workplat1()
        {
            InitializeComponent();
            taskRepository = new TaskRepository();
            LoadTasks();
            dataGridViewTasks.SelectionChanged += dgvTasks_SelectionChanged;
        }

        private void LoadTasks()
        {
            List<TaskItem> tasks = taskRepository.GetAllTasks();
            dataGridViewTasks.DataSource = tasks;
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
    }
}
