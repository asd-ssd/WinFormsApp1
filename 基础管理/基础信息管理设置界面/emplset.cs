using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.基础信息管理工作界面;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.工作界面
{
    public partial class emplset : Form
    {
        public DataGridView dataGridView1 = empplat.empplat1.dataGridView2;
        public empplat empplat2;
        public emplset()
        {
            InitializeComponent();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
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
                strda = "insert into 员工信息表(员工编号,员工姓名,性别,部门,职务,状态,联系方式,身份证号,籍贯,民族,政治面貌,婚姻情况,家庭住址,家庭电话,入职日期,离职日期,合同到期时间,职称,受教育程度,备注) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "' ,'" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + dateTimePicker3.Value.Date.ToString("yyyy-MM-dd") + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' ,'" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";

            }
            else
            {
                strda = "insert into 员工信息表(员工编号,员工姓名,性别,部门,职务,状态,联系方式,身份证号,籍贯,民族,政治面貌,婚姻情况,家庭住址,家庭电话,入职日期,合同到期时间,职称,受教育程度,备注) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "' ,'" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' ,'" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
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
    }
}
