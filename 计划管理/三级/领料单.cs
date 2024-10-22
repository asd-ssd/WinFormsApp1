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
            SqlConnection sc1;
            string connstr1 = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=计划管理;Persist Security Info=True;User ID=sa;Password=978123thy";
            DataTable dt = new DataTable();
            using (sc1 = new SqlConnection(connstr1))
            {
                sc1.Open();
                string sql = "select * from Issue";
                SqlDataAdapter sdr = new SqlDataAdapter(sql, sc1);
                sdr.Fill(dt);
            }
            this.dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
