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
using WinFormsApp1.基础信息管理设置界面;
using WinFormsApp1.基础管理.基础信息管理工作界面;
using WinFormsApp1.工作界面;

namespace WinFormsApp1.基础信息管理工作界面
{
    public partial class partplat : UserControl
    {
        public static partplat partplat1;
        public partset partset1;
        public parttree parttree1;
        public partplat()
        {
            InitializeComponent();
            GetTreeView();
            partplat1 = this;

        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }

        private void GetTreeView()
        {
            string strda = "select * from 部门信息表";
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            InitModuleTree(dt);
            
        }
        //绑定TrreView
        private void InitModuleTree(DataTable dt)
        {
            //清空treeview上所有节点
            this.treeView1.Nodes.Clear();
            int[] gen = new int[dt.Rows.Count]; //用于存储父节点Tag
            int[] zi = new int[dt.Rows.Count];  //用于存储子节点Tag
            for (int i = 0; i < gen.Length; i++)
            {
                string zhi = dt.Rows[i]["部门层级"].ToString();//获取节点Tag值   eg：1-2
                if (zhi.Length > 1)   //表示是子节点   eg：1-2
                {
                    gen[i] = int.Parse(zhi.Substring(0, zhi.IndexOf('-')));
                    zi[i] = int.Parse(zhi.Substring(zhi.IndexOf('-') + 1));
                }
                else    //表示是根节点   eg：2
                {
                    //将所有父节点加到treeview上
                    zi[i] = int.Parse(zhi);
                    TreeNode nodeParent = new TreeNode();
                    nodeParent.Tag = (zi[i]).ToString();
                    nodeParent.Text = dt.Rows[i][1].ToString();
                    treeView1.Nodes.Add(nodeParent);
                }
            }
            bindChildNote(dt, gen, zi);
        }
        //绑定子节点
        private void bindChildNote(DataTable dt, int[] gen, int[] zi)
        {
            for (int i = 0; i < gen.Length; i++)
            {
                if (gen[i] != 0 && zi[i] != 0)        //便利所有节点，找到所有子节点
                {
                    TreeNode childNode = new TreeNode();
                    foreach (TreeNode item in treeView1.Nodes)   //便历treeview上所有父节点
                    {
                        if (item.Tag.ToString() == gen[i].ToString())  //找到当前子节点的父节点
                        {
                            childNode.Tag = zi[i].ToString();
                            childNode.Text = dt.Rows[i][1].ToString();
                            item.Nodes.Add(childNode);
                        }
                    }
                }
            }
            treeView1.ExpandAll();      //展开整棵树
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }
        //刷新
        private void button1_Click(object sender, EventArgs e)
        {
            GetTreeView();
        }
        //新增
        private void button2_Click(object sender, EventArgs e)
        {
            partset1 = new partset();
            partset1.ShowDialog();
        }
        //查询
        private void button3_Click(object sender, EventArgs e)
        {
            parttree1 = new parttree();
            parttree1.ShowDialog();
        }
        //修改
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;//整个表格只读
            button6.Visible = true;
            button7.Visible = true;
        }
        string[] strcomm = new string[100];
        int n = 0;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString();//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells["部门名称"].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            strcomm[n] = $"UPDATE 部门信息表 SET {strcolumn} = '{value}' WHERE 部门名称 = '{strrow}'";
            n++;
        }
        //删除
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除该行吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    //获取要删除行的ID值
                    string id = row.Cells["部门名称"].Value.ToString();
                    string delesql = "DELETE FROM 部门信息表 WHERE 部门名称 = @部门名称";
                    using (SqlConnection conn = connection())
                    {
                        using (SqlCommand comm = new SqlCommand(delesql, conn))
                        {
                            comm.Parameters.AddWithValue("@部门名称", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    dataGridView1.Rows.Remove(row);
                }
                GetTreeView();
            }
        }
        //修改完成
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要修改数据吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection conn = connection();
                for (int i = 0; i < n; i++)
                {
                    using (SqlCommand comm = new SqlCommand(strcomm[i], conn))
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                GetTreeView();
                n = 0;
                button6.Visible = false;
                button7.Visible = false;
                dataGridView1.ReadOnly = true;//整个表格只读
                strcomm = new string[100];
            }
        }
        //取消
        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                n = 0;
                button6.Visible = false;
                button7.Visible = false;
                dataGridView1.ReadOnly = true;//整个表格只读
                strcomm = new string[100];
            }
        }
    }
}
