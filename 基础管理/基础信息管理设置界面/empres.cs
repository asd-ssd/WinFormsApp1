using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.基础信息管理工作界面;
using WinFormsApp1.数据库支持类;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class empres : Form
    {
        private DictionaryService _dictionaryService;
        public DataGridView dataGridView1 = empplat.empplat1.dataGridView2;
        public empres()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from 员工信息表 where 1=1";
            if (textBox1.Text.Trim() != "")
            {
                selectsql += "and 员工编号 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text.Trim() != "")
            {
                selectsql += "and 员工姓名 like'%" + textBox2.Text + "%'";
            }
            if (comboBox2.Text.Trim() != "")
            {
                selectsql += "and 性别 like'%" + comboBox2.Text + "%'";
            }
            if (textBox4.Text.Trim() != "")
            {
                selectsql += "and 部门 like'%" + textBox4.Text + "%'";
            }
            if (textBox5.Text.Trim() != "")
            {
                selectsql += "and 职务 like'%" + textBox5.Text + "%'";
            }
            if (comboBox1.Text.Trim() != "")
            {
                selectsql += "and 状态 like'%" + comboBox1.Text + "%'";
            }
            if (textBox7.Text.Trim() != "")
            {
                selectsql += "and 联系方式 like'%" + textBox7.Text + "%'";
            }
            if (textBox8.Text.Trim() != "")
            {
                selectsql += "and 身份证号 like'%" + textBox8.Text + "%'";
            }
            if (textBox9.Text.Trim() != "")
            {
                selectsql += "and 籍贯 like'%" + textBox9.Text + "%'";
            }
            if (textBox10.Text.Trim() != "")
            {
                selectsql += "and 民族 like'%" + textBox10.Text + "%'";
            }
            if (comboBox3.Text.Trim() != "")
            {
                selectsql += "and 政治面貌 like'%" + comboBox3.Text + "%'";
            }
            if (comboBox4.Text.Trim() != "")
            {
                selectsql += "and 婚姻情况 like'%" + comboBox4.Text + "%'";
            }
            if (textBox13.Text.Trim() != "")
            {
                selectsql += "and 家庭住址 like'%" + textBox13.Text + "%'";
            }
            if (textBox14.Text.Trim() != "")
            {
                selectsql += "and 家庭电话 like'%" + textBox14.Text + "%'";
            }
            string start1 = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            //取开始时间的0点，大于等于开始日期的0点；
            string end1 = dateTimePicker3.Value.AddDays(1).Date.ToString("yyyy-MM-dd");
            //取结束时间第二天的0点，小于（没有等于）结束第二天的0点；
            string start2 = dateTimePicker4.Value.Date.ToString("yyyy-MM-dd");
            
            string end2 = dateTimePicker1.Value.AddDays(1).Date.ToString("yyyy-MM-dd");
            var paras = new Dictionary<string, string> { { "start1", start1 }, { "end1", end1 }, { "start2", start2 }, { "end2", end2 } };
            if (checkBox1.Checked)
            {
              
                selectsql += "and 入职日期 >= @start1 AND 入职日期 <@end1";
                

            }
            if (checkBox2.Checked)
            {
                selectsql += "and 离职日期 >= @start2 AND 离职日期 <@end2";
            }
            if (textBox15.Text.Trim() != "")
            {
                selectsql += "and 职称 like'%" + textBox15.Text + "%'";
            }
            if (textBox16.Text.Trim() != "")
            {
                selectsql += "and 受教育程度 like'%" + textBox16.Text + "%'";
            }
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            foreach (var par in paras)
            {
                //设置sqlCommand的参数
                da.SelectCommand.Parameters.AddWithValue(par.Key, par.Value);
            }
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            MessageBox.Show("查询成功！");
            this.Close();
        }

        private void empres_Load(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前查询未完成，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "离职")
            {
                label3.Visible = true;
                label4.Visible = true;
                checkBox2.Visible = true;
                dateTimePicker4.Visible = true;
                dateTimePicker1.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                checkBox2.Visible = false;
                dateTimePicker4.Visible = false;
                dateTimePicker1.Visible = false;
            }
        }
    }
}
