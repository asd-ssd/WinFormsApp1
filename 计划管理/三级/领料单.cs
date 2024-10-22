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

namespace WinFormsApp1.计划管理.三级
{
    public partial class 领料单 : UserControl
    {
        public 领料单()
        {
            InitializeComponent();
        }
        private void 领料单_Load(object sender, EventArgs e)
        {
            string sql = "select * from Issue";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, "Data Source=DESKTOP-DC8DD5P;Initial Catalog=计划管理;Persist Security Info=True;User ID=sa;Password=978123thy");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns.Clear();
        }

            private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
