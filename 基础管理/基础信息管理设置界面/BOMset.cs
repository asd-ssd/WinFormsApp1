using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.工作界面;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1.基础信息管理设置界面
{
    public partial class BOMset : Form
    {
        private DictionaryService _dictionaryService;
        public DataGridView dataGridView1 = BOMplat.BOMplat1.dataGridView1;
        public static BOMset BOMset1;
        public selectBomparent selectBomparent1;
        public string bomx = "DZ";
        public BOMset()
        {
            InitializeComponent();
            _dictionaryService = new DictionaryService();
            LoadTypeItems();
            LoadDWItems();
            LoadOriginItems();
            BOMset1 = this;
            textBox3.Text = AddNewBom();
        }

        private void LoadOriginItems()
        {
            var items = _dictionaryService.GetItemsByCategoryName("物料来源");
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "ItemName";
            comboBox1.ValueMember = "ItemId";
            comboBox1.SelectedIndex = -1; // 使ComboBox不显示任何选择的值
        }

        private void LoadDWItems()
        {
            var items = _dictionaryService.GetItemsByCategoryName("计量单位");
            comboBox3.DataSource = items;
            comboBox3.DisplayMember = "ItemName";
            comboBox3.ValueMember = "ItemId";
            comboBox3.SelectedIndex = -1; // 使ComboBox不显示任何选择的值
        }

        private void LoadTypeItems()
        {
            var items = _dictionaryService.GetItemsByCategoryName("物料分类");
            comboBox2.DataSource = items;
            comboBox2.DisplayMember = "ItemName";
            comboBox2.ValueMember = "ItemId";
            comboBox2.SelectedIndex = -1; // 使ComboBox不显示任何选择的值
        }

        public string AddNewBom()
        {
            string strda = $"SELECT * FROM BOM表";
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);
            int index = dt.Rows.Count + 10000;
            string newid = index.ToString();
            return (bomx + newid);
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
                string strda = "select * from BOM表";
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
            float x = 0;
            float y = 0;
            float z = 0;
            if(textBox10.Text.Trim()!="")
            {
                x = float.Parse(textBox10.Text.Trim());
            }
            if (textBox11.Text.Trim() != "")
            {
                y = float.Parse(textBox11.Text.Trim());
            }
            if (textBox12.Text.Trim() != "")
            {
                z = float.Parse(textBox12.Text.Trim());
            }
            float sum =  x+ y + z ;
            string strda = "insert into BOM表(层次号,父项编码,物料编码,物料名称,物料分类,安全库存量,提前期,计量单位,单位用量,材料费用,人工费用,制造费用,单价,物料来源,小计) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox3.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + comboBox1.Text + "','" + sum.ToString() + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void BOMset_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetDataGridView();
            MessageBox.Show("添加成功！");
            SysLogService.AddSysLog(new SysLog("新增BOM表数据", "触发", LogTye.操作记录, login.login1.userid));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前数据仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectBomparent1 = new selectBomparent();
            selectBomparent1.ShowDialog();
        }
    }
}
