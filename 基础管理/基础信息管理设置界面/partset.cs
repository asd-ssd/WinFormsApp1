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
            initcombobox();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
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
        private void initcombobox()
        {
            string strda = "select * from 部门信息表";
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["部门名称"].ToString() != "")
                {
                    comboBox1.Items.Add(dt.Rows[i]["部门名称"]);
                }
            }
        }

        //绑定TrreView
        private void InitModuleTree(DataTable dt)
        {
            // 清空TreeView上的所有节点
            this.treeView1.Nodes.Clear();

            // 用于存储所有根节点
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string zhi = dt.Rows[i]["部门层级"].ToString(); // 获取节点层级Tag值 例如：1, 1-2, 1-2-3
                if (!zhi.Contains("-")) // 根节点，即只有一层的节点
                {
                    TreeNode rootNode = new TreeNode
                    {
                        Tag = zhi,
                        Text = dt.Rows[i][1].ToString()
                    };
                    treeView1.Nodes.Add(rootNode); // 将根节点添加到TreeView
                }
            }

            // 调用递归绑定子节点
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bindChildNote(dt, dt.Rows[i]["部门层级"].ToString());
            }
        }

        //绑定子节点
        private void bindChildNote(DataTable dt, string parentTag)
        {
            foreach (DataRow row in dt.Rows)
            {
                string zhi = row["部门层级"].ToString(); // 获取当前节点层级Tag值 例如：1-2, 1-2-3

                // 检查当前节点是否是parentTag的直接子节点
                if (IsDirectChild(parentTag, zhi))
                {
                    string[] levels = zhi.Split('-');
                    string currentTag = zhi; // 获取完整层次的Tag
                    TreeNode childNode = new TreeNode
                    {
                        Tag = currentTag, // 设置完整的层级Tag
                        Text = row[1].ToString()
                    };

                    // 查找父节点
                    TreeNode parentNode = FindNodeByTag(treeView1.Nodes, parentTag);
                    if (parentNode != null)
                    {
                        // 检查父节点是否已经包含当前子节点，避免重复添加
                        bool nodeExists = false;
                        foreach (TreeNode existingNode in parentNode.Nodes)
                        {
                            if (existingNode.Tag.ToString() == currentTag)
                            {
                                nodeExists = true;
                                break;
                            }
                        }

                        if (!nodeExists)
                        {
                            parentNode.Nodes.Add(childNode);
                        }
                    }

                    // 递归调用，继续查找这个节点的子节点
                    bindChildNote(dt, zhi);
                }
            }

            treeView1.ExpandAll(); // 展开整棵树
        }

        // 判断是否是直接子节点
        private bool IsDirectChild(string parentTag, string childTag)
        {
            // 判断childTag是否是parentTag的直接子节点，要求childTag比parentTag多一层
            string[] parentLevels = parentTag.Split('-');
            string[] childLevels = childTag.Split('-');

            return childLevels.Length == parentLevels.Length + 1 && childTag.StartsWith(parentTag + "-");
        }



        private TreeNode FindNodeByTag(TreeNodeCollection nodes, string tag)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag.ToString() == tag)
                {
                    return node; // 找到匹配的父节点
                }

                // 递归查找子节点
                TreeNode foundNode = FindNodeByTag(node.Nodes, tag);
                if (foundNode != null)
                {
                    return foundNode;
                }
            }
            return null; // 没有找到
        }


        private void addDataGridView()
        {
            SqlConnection conn = connection();
            conn.Open();
            string strda = "insert into 部门信息表(上级部门,部门名称,部门位置,部门负责人,负责人联系电话,部门层级) values('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlCommand comm = new SqlCommand(strda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addDataGridView();
            GetTreeView();
            SysLogService.AddSysLog(new SysLog("增加部门信息表数据", "触发", LogTye.操作记录, login.login1.userid));

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strda = "select * from 部门信息表";
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);
            int k = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (comboBox1.Text.ToString() == dt.Rows[i]["部门名称"].ToString())
                {
                    textBox6.Text = dt.Rows[i]["部门层级"].ToString() + "-";
                }
                if (comboBox1.Text.ToString() == dt.Rows[i]["上级部门"].ToString())
                {
                    k++;
                }
            }
            textBox6.Text += k.ToString();
        }
    }
}
