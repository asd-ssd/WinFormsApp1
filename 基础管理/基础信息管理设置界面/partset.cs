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
using WinFormsApp1.基础信息管理工作界面;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;

namespace WinFormsApp1.基础信息管理设置界面
{
    public partial class partset : Form
    {
        public DataGridView dataGridView1 = partplat.partplat1.dataGridView1;
        public TreeView treeView1 = partplat.partplat1.treeView1;
        public partset()
        {
            InitializeComponent();
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
        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 部门信息表(上级部门,部门名称,部门位置,部门负责人,负责人联系电话,部门层级) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetTreeView();
            MessageBox.Show("添加成功！");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前数据仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
