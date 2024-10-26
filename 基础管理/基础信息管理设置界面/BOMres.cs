using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.工作界面;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1
{
    public partial class BOMres : Form
    {
        private DictionaryService _dictionaryService;
        public DataGridView dataGridView1 = BOMplat.BOMplat1.dataGridView1;
        public BOMres()
        {
            InitializeComponent();
            _dictionaryService = new DictionaryService();
            LoadTypeItems();
            LoadDWItems();
            LoadOriginItems();
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
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectsql = "select * from BOM表 where 1=1";
            if (textBox1.Text != "")
            {
                selectsql += "and 层次号 like'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                selectsql += "and 父项编码 like'%" + textBox2.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                selectsql += "and 物料编码 like'%" + textBox3.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                selectsql += "and 物料名称 like'%" + textBox4.Text + "%'";
            }
            if (comboBox2.Text != "")
            {
                selectsql += "and 物料分类 like'%" + comboBox2.Text + "%'";
            }
            if (textBox6.Text != "")
            {
                selectsql += "and 安全库存量 like'%" + textBox6.Text + "%'";
            }
            if (textBox7.Text != "")
            {
                selectsql += "and 提前期 like'%" + textBox7.Text + "%'";
            }
            if (comboBox3.Text != "")
            {
                selectsql += "and 计量单位 like'%" + comboBox3.Text + "%'";
            }
            if (textBox9.Text != "")
            {
                selectsql += "and 单位用量 like'%" + textBox9.Text + "%'";
            }
            if (textBox10.Text != "")
            {
                selectsql += "and 材料费用 like'%" + textBox10.Text + "%'";
            }
            if (textBox11.Text != "")
            {
                selectsql += "and 人工费用 like'%" + textBox11.Text + "%'";
            }
            if (textBox12.Text != "")
            {
                selectsql += "and 制造费用 like'%" + textBox12.Text + "%'";
            }
            if (textBox13.Text != "")
            {
                selectsql += "and 单价 like'%" + textBox13.Text + "%'";
            }
            if (textBox14.Text != "")
            {
                selectsql += "and 小计 like'%" + textBox14.Text + "%'";
            }
            if (comboBox1.Text != "")
            {
                selectsql += "and 物料来源 like'%" + comboBox1.Text + "%'";
            }
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            MessageBox.Show("查询成功！");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前查询未完成，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BOMres_Load(object sender, EventArgs e)
        {

        }
    }
}
