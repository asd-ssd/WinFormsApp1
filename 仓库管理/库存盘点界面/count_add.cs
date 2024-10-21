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

namespace WinFormsApp1.仓库管理.库存盘点界面
{
    public partial class count_add : Form
    {
        public count_add()
        {
            InitializeComponent();
        }

        private void count_add_Load(object sender, EventArgs e)
        {
            SqlConnection sc1;
            string connstr1 = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=lwx;Integrated Security=True";
            DataTable dt = new DataTable();
            using (sc1 = new SqlConnection(connstr1))
            {
                sc1.Open();
                string sql = "select * from 库存盘点表";
                SqlDataAdapter sdr = new SqlDataAdapter(sql, sc1);
                sdr.Fill(dt);
            }
            this.dataGridView1.DataSource = dt;
        }
    }
}
