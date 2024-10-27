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
using WinFormsApp1.仓库管理.入库界面;

namespace WinFormsApp1.仓库管理.初始查询界面
{
    public partial class warehouse_initial_item : Form
    {
        private int n;
        private string[] strcomm;
        private string warehouse_select_item_name;
        private string warehouse_select_item_number;
        public TextBox warehouse_select_item_textBox1 = warehouse_initial_add.warehouse_initial_add1.textBox1;//绑定is_add的入库人格
        public TextBox warehouse_select_item_textBox2 = warehouse_initial_add.warehouse_initial_add1.textBox5;
        public warehouse_initial_item()
        {
            InitializeComponent();
            GetDataGridView();
        }
             
            private SqlConnection connection()
            {
                string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=lwx;Password=luowenxin";
                SqlConnection conn = new SqlConnection(strconn);
                return conn;
            }
            private void GetDataGridView()
            {
                try
                {
                    string strda = "select * from BOM表";
                    SqlConnection conn = connection();
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(strda, conn);
                    da.Fill(dt);
                    conn.Close();
                    //dataGridView1.AutoGenerateColumns = true;//自动创建列
                    //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message.ToString());
                }
            }
            private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }
            private void button7_Click(object sender, EventArgs e)
            {
                string selectsql = "select * from BOM表 where 1=1";
                /*if (textBox1.Text != "")
                {
                    selectsql += "and 物料名称 like'%" + textBox1.Text + "%'";
                }*/
                if (textBox2.Text != "")
                {
                    selectsql += "and 物料编码 like'%" + textBox2.Text + "%'";
                }


                SqlConnection conn = connection();
                conn.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(selectsql, conn);
                da.Fill(dt1);
                conn.Close();
                dataGridView1.DataSource = dt1;
                MessageBox.Show("查询成功！");

            }

            private void button1_Click(object sender, EventArgs e)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    //获取要选中行的ID值
                    warehouse_select_item_number = row.Cells["物料编码"].Value.ToString();
                    warehouse_select_item_name = row.Cells["物料名称"].Value.ToString();

                }
                warehouse_select_item_textBox1.Text = warehouse_select_item_name;
                warehouse_select_item_textBox2.Text = warehouse_select_item_number;
                this.Close();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            warehouse_select_item_number = dataGridView1.Rows[e.RowIndex].Cells["物料编码"].Value.ToString();
            warehouse_select_item_number = dataGridView1.Rows[e.RowIndex].Cells["物料名称"].Value.ToString();

        }
    }
    }



