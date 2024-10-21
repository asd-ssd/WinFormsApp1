using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1.工作界面
{
    public partial class BOMplat : UserControl
    {
        public BOMplat()
        {
            InitializeComponent();
        }
        
private void BOMplat_Load(object sender, EventArgs e)
        {
            SqlConnection sc;
            DataSet dss = new DataSet();
            string connstr = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
            DataTable dt = new DataTable();
            using (sc = new SqlConnection(connstr))
            {
                sc.Open();
                string sql = "select * from BOM表";
                SqlDataAdapter sdr = new SqlDataAdapter(sql, sc);
                sdr.Fill(dt);
            }
            this.dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
