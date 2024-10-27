using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinFormsApp1.仓库管理.入库界面;
using WinFormsApp1.工作界面;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class PublishTaskForm : Form
    {
        private DictionaryService _dictionaryService;
        public TaskRepository taskRepository;
        public workplat1 workplat11;
        public static PublishTaskForm PublishTaskForm1;
        public Selectemp selectemp1;
        public TaskItem NewTask { get; private set; }
        public string InitiatorName;
        public PublishTaskForm()
        {
            InitializeComponent();
            PublishTaskForm1 = this;

            _dictionaryService = new DictionaryService();
            workplat11 = new workplat1();
            taskRepository = new TaskRepository();
            LoadTypes();
            LoadTopicItems();
        }
        private void LoadTypes()
        {
            var items = _dictionaryService.GetItemsByCategoryName("任务类型");
            textBoxType.DataSource = items;
            textBoxType.DisplayMember = "ItemName";
            textBoxType.ValueMember = "ItemId";
            textBoxType.SelectedIndex = -1; // 使ComboBox不显示任何选择的值
        }

        private void LoadTopicItems()
        {
            var items = _dictionaryService.GetItemsByCategoryName("任务主题");
            textBoxSubject.DataSource = items;
            textBoxSubject.DisplayMember = "ItemName";
            textBoxSubject.ValueMember = "ItemId";
            textBoxSubject.SelectedIndex = -1; // 使ComboBox不显示任何选择的值
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {

            // 创建新的任务对象
            NewTask = new TaskItem
            {
                TaskType = textBoxType.Text,
                TaskStatus = "未完成",
                TaskSubject = textBoxSubject.Text,
                TaskContent = textBoxContent.Text,
                Executor = textBoxExecutor.Text,
                Initiator = ConfigurationManager.AppSettings["员工姓名"],
                InitiationTime = DateTime.Now,
                ExecutionTime = DateTime.Parse(dateExecutionTime.Text),
                CompletionTime = null,
                Deadline = DateTime.Parse(dateTimeDedline.Text),
            };
            taskRepository.AddTask(NewTask);
            workplat11.LoadTasks();
            SysLogService.AddSysLog(new SysLog("发布新任务", "触发", LogTye.操作记录, login.login1.userid));
            // 关闭表单
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private SqlConnection connection()

        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectemp1 = new Selectemp();
            selectemp1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
