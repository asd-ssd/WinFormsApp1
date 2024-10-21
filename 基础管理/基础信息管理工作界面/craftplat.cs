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

namespace WinFormsApp1.基础信息管理工作界面
{
    public partial class craftplat : UserControl
    {
        public craftplat()
        {
            InitializeComponent();
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void craftplat_Load(object sender, EventArgs e)
        {
            SqlConnection sc;
            DataSet dss = new DataSet();
            string connstr = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
            DataTable dt = new DataTable();
            using (sc = new SqlConnection(connstr))
            {
                sc.Open();
                string sql = "select * from 工艺路线表";
                SqlDataAdapter sdr = new SqlDataAdapter(sql, sc);
                sdr.Fill(dt);
            }
            this.dataGridView2.DataSource = dt;
        }
    }
}
