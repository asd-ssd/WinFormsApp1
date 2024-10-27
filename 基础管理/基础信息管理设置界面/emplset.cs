using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.基础信息管理工作界面;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.工作界面
{
    public partial class emplset : Form
    {
        private DictionaryService _dictionaryService;
        public static emplset emplset1;
        public DataGridView dataGridView1 = empplat.empplat1.dataGridView2;
        public empplat empplat2;
        public empkypart empkypart1;
        public string empid = "JW24";
        public emplset()
        {
            InitializeComponent();
            emplset1 = this;
            _dictionaryService = new DictionaryService();
            LoadXBItems();
            LoadZZItems();
            LoadHYItems();
        }
        private void LoadHYItems()
        {
            var items = _dictionaryService.GetItemsByCategoryName("婚姻情况");
            comboBox4.DataSource = items;
            comboBox4.DisplayMember = "ItemName";
            comboBox4.ValueMember = "ItemId";
            comboBox4.SelectedIndex = -1; // 使ComboBox不显示任何选择的值
        }

        private void LoadZZItems()
        {
            var items = _dictionaryService.GetItemsByCategoryName("政治面貌");
            comboBox3.DataSource = items;
            comboBox3.DisplayMember = "ItemName";
            comboBox3.ValueMember = "ItemId";
            comboBox3.SelectedIndex = -1; // 使ComboBox不显示任何选择的值
        }

        private void LoadXBItems()
        {
            var items = _dictionaryService.GetItemsByCategoryName("性别");
            comboBox2.DataSource = items;
            comboBox2.DisplayMember = "ItemName";
            comboBox2.ValueMember = "ItemId";
            comboBox2.SelectedIndex = -1; // 使ComboBox不显示任何选择的值
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 员工信息表";
                SqlConnection conn = connection();
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strda, conn);
                da.Fill(dt);
                conn.Close();
                //dataGridView1.AutoGenerateColumns = true;//自动创建列
                //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = null;
            if (comboBox1.Text.Trim() == "离职")
            {
                strda = "insert into 员工信息表(员工编号,员工姓名,性别,部门,职务,状态,联系方式,身份证号,籍贯,民族,政治面貌,婚姻情况,家庭住址,家庭电话,入职日期,离职日期,合同到期时间,职称,受教育程度,备注) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox13.Text + "','" + textBox14.Text + "' ,'" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + dateTimePicker3.Value.Date.ToString("yyyy-MM-dd") + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' ,'" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";

            }
            else
            {
                strda = "insert into 员工信息表(员工编号,员工姓名,性别,部门,职务,状态,联系方式,身份证号,籍贯,民族,政治面貌,婚姻情况,家庭住址,家庭电话,入职日期,合同到期时间,职称,受教育程度,备注) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox13.Text + "','" + textBox14.Text + "' ,'" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' ,'" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
            }

            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void emplset_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "离职")
            {
                label9.Visible = true;
                dateTimePicker3.Visible = true;
            }
            else
            {
                label9.Visible = false;
                dateTimePicker3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            SysLogService.AddSysLog(new SysLog("增加员工信息表数据", "触发", LogTye.操作记录, login.login1.userid));

            MessageBox.Show("添加成功！");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前数据仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            empkypart1 = new empkypart();
            empkypart1.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = AddNewEmp();
        }
        
        public string GetempID(string Empnum)
        {
            string strda = $"SELECT * FROM 部门信息表 WHERE 部门名称 = '{textBox4.Text.Trim()}'"; 
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);
            int index = dt.Rows.Count-1;
            string partid = dt.Rows[index]["部门编号"].ToString();
            string converpartid = splitst(partid);
            return (empid + converpartid+Empnum);
        }
        public  string AddNewEmp()
        {
            string strda = $"SELECT * FROM 员工信息表 WHERE 部门 = '{textBox4.Text.Trim()}'";
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);
            int maxnunber = dt.Rows.Count+1001;
            
            string NowEmpNum = maxnunber.ToString();

            string NewEmp = GetempID(NowEmpNum);
            return NewEmp;
        }
        private string splitst(string partid)
        {
            var parts = partid.Split("-");
            var converparts = new List<string>();
            foreach(var part in parts)
            {
                converparts.Add(part);
            }
            var convercode = string.Join("", converparts).PadRight(3, '0');
            return convercode;
        }
    }
}
