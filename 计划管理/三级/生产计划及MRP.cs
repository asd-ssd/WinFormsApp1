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
    public partial class 生产计划及MRP : UserControl
    {
        public 生产计划及MRP()
        {
            InitializeComponent();
        }
        private void 生产计划及MRP_Load(object sender, EventArgs e)
        {
            SqlConnection sc1;
            string connstr1 = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=计划管理;Integrated Security=True";
            DataTable dt = new DataTable();
            using (sc1 = new SqlConnection(connstr1))
            {
                sc1.Open();
                string sql = "select * from MRP";
                SqlDataAdapter sdr = new SqlDataAdapter(sql, sc1);
                sdr.Fill(dt);
            }
            this.dataGridView1.DataSource = dt;
        }
    }
}
