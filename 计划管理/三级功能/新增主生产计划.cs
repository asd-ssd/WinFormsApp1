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
using WinFormsApp1.工作界面;
using WinFormsApp1.计划管理.三级;

namespace WinFormsApp1.Forth
{
    public partial class 新增主生产计划 : Form
    {
        public DataGridView dataGridView1=生产计划及MRP.shengchan1.dataGridView1;
        public 新增主生产计划()
        {
            InitializeComponent();
        }

        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=sa;Password=978123thy";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
