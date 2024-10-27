using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.数据库支持类;
using WinFormsApp1.销售管理.客户管理;

namespace WinFormsApp1.销售管理.收发货管理.发货
{
    public partial class Delievery : UserControl
    {
        private readonly PermissionService _permissionService;
        public De3 de3;
        public static Delievery delievery;
        public Delievery()
        {
            InitializeComponent();
            var dbHelper = new SqlSugarHelper();
            _permissionService = new PermissionService(dbHelper);
            var permissionManager = new PermissionManager(_permissionService, moduleId: 3); // 1是模块ID
            permissionManager.ApplyPermissions(this);
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=xlh;Password=123456";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void GetDataGridView()
        {
            try
            {
                string strda = "select * from 出库单表";
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

        private void Delievery_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            delievery = this;
        }

        
        string[] strcomm = new string[100];
        int n = 0;
        private IEnumerable<object> paras;
        private object dt;

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["出库单编号"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = strcomm[n] = $"UPDATE 出库单表 SET {strcolumn} = '{value}' WHERE 出库单编号 = '{strrow}'";
            n++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            de3 = new De3();
            de3.Show();   //将窗体一进行显示
        }
        private void button7_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }
    }
}
