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

namespace WinFormsApp1.计划管理.三级功能
{
    public partial class 下达派工单 : Form
    {
        public 下达派工单()
        {
            InitializeComponent();
        }
        private void 下达派工单_Load(object sender, EventArgs e)
        {
            string sql = "select * from 工艺路线表";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=sa;Password=978123thy");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
