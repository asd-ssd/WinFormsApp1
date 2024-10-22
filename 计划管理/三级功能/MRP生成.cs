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

namespace WinFormsApp1.Forth
{
    public partial class MRP生成 : Form
    {
        public MRP生成()
        {
            InitializeComponent();
        }
        private void MRP_Load(object sender, EventArgs e)
        {
            string sql = "select * from MRP";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, "Data Source=DESKTOP-DC8DD5P;Initial Catalog=计划管理;Persist Security Info=True;User ID=sa;Password=978123thy");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
