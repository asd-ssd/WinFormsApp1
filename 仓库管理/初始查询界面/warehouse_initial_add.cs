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
using WinFormsApp1.仓库管理.出库界面;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.仓库管理.初始查询界面
{
    
    public partial class warehouse_initial_add : Form
    {
        public DataGridView dataGridView1 = warehouse_initial.warehouse_initial1.dataGridView1;
        public static warehouse_initial_add warehouse_initial_add1;
        public static warehouse_initial_item warehouse_item1;
        public warehouse_initial_add()
        {
            InitializeComponent();
            warehouse_initial_add1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            //addDataGridView1();
            GetDataGridView();
            this.Close();
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 库存管理表";
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
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=lwx;Password=luowenxin";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "INSERT INTO 库存管理表 (库位号, 库位容量,所属库房, 库房容量,物料编码,物料名称,物料分类,盘点周期,最后盘点日期,库位库存量) VALUES ('" + textBox4.Text.Trim() + "','" + textBox16.Text.Trim() + "','" + comboBox2.Text.Trim() + "','" + textBox7.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd")+ "','" + textBox15.Text.Trim() + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            SysLogService.AddSysLog(new SysLog("新增库存管理表数据", "触发", LogTye.操作记录, login.login1.userid));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            warehouse_item1 = new warehouse_initial_item();
            warehouse_item1.Show();
        }
    }
}
