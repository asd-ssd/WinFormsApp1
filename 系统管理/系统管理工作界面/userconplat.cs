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

namespace WinFormsApp1.系统管理工作界面
{
    public partial class userconplat : UserControl
    {
        public userconplat()
        {
            InitializeComponent();
        }

        private void userconplat_Load(object sender, EventArgs e)
        {
            SqlConnection sc;
            DataSet dss = new DataSet();
            string connstr = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
            DataTable dt = new DataTable();
            using (sc = new SqlConnection(connstr))
            {
                sc.Open();
                string sql = "select * from 用户信息表";
                SqlDataAdapter sdr = new SqlDataAdapter(sql, sc);
                sdr.Fill(dt);
            }
            this.dataGridView2.DataSource = dt;
        }
    }
}
