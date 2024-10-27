using System;
using System.Windows.Forms;
using WinFormsApp1.工作界面;

namespace WinFormsApp1
{
    public partial class workplatform : UserControl
    {
        private TaskRepository taskRepository;
        private workplat1 workPlat1Instance;

        public workplatform(workplat1 workplatInstance)
        {
            InitializeComponent();
            taskRepository = new TaskRepository();
            workPlat1Instance = workplatInstance;
        }

        private DataGridView DataGridViewTasks => workPlat1Instance.dataGridViewTasks;

        // 查询
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startdate = dateTimePicker1.Value;
            DateTime enddate = dateTimePicker3.Value;
            List < TaskItem> tasks= taskRepository.GetTaskbydate(startdate, enddate);
            DataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void allbutton_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void uncompeletebutton_Click(object sender, EventArgs e)
        {
            LoadIncompleteTasks();
        }



        private void mypublishbutton_Click(object sender, EventArgs e)
        {
            LoadInTasks();
        }

        private void myedbutton_Click(object sender, EventArgs e)
        {
            LoadExTasks();
        }

        private void SetDataGridViewColumnHeaders()
        {
            // 设置 DataGridView 的列标题为中文
            DataGridViewTasks.Columns["TaskId"].HeaderText = "任务ID";
            DataGridViewTasks.Columns["TaskType"].HeaderText = "类型";
            DataGridViewTasks.Columns["TaskStatus"].HeaderText = "状态";
            DataGridViewTasks.Columns["TaskSubject"].HeaderText = "主题";
            DataGridViewTasks.Columns["TaskContent"].HeaderText = "内容";
            DataGridViewTasks.Columns["Executor"].HeaderText = "执行人";
            DataGridViewTasks.Columns["Initiator"].HeaderText = "发起人";
            DataGridViewTasks.Columns["InitiationTime"].HeaderText = "发起时间";
            DataGridViewTasks.Columns["ExecutionTime"].HeaderText = "执行时间";
            DataGridViewTasks.Columns["Deadline"].HeaderText = "执行期限";
            DataGridViewTasks.Columns["CompletionTime"].HeaderText = "完成时间";
            DataGridViewTasks.Columns["Action"].HeaderText = "操作";
            DataGridViewTasks.Columns["ResponseContent"].HeaderText = "回复内容";
            // 隐藏任务ID列
            DataGridViewTasks.Columns["TaskId"].Visible = false;
        }

        private void LoadTasks()
        {
            DataGridViewTasks.DataSource = null;
            List<TaskItem> tasks = taskRepository.GetNowEmpTasks();
            DataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void LoadIncompleteTasks()
        {
            DataGridViewTasks.DataSource = null;
            List<TaskItem> tasks = taskRepository.GetIncompleteTasks();
            DataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void LoadCompletedTasks()
        {
            DataGridViewTasks.DataSource = null;
            List<TaskItem> tasks = taskRepository.GetCompletedTasks();
            DataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void LoadExTasks()
        {
            DataGridViewTasks.DataSource = null;
            List<TaskItem> tasks = taskRepository.GetEXecutorEmpTakks();
            DataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void LoadInTasks()
        {
            DataGridViewTasks.DataSource = null;
            List<TaskItem> tasks = taskRepository.GetInitiatorEmpTakks();
            DataGridViewTasks.DataSource = tasks;
            SetDataGridViewColumnHeaders();
        }

        private void compeletebutton_Click_1(object sender, EventArgs e)
        {
            LoadCompletedTasks();
        }
    }
}
