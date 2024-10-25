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
                SysLogService.AddSysLog(new SysLog("删除部门信息表数据", "触发", LogTye.操作记录, login.login1.userid));

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
                SysLogService.AddSysLog(new SysLog("修改部门信息表数据", "触发", LogTye.操作记录, login.login1.userid));
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

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // 创建一个集合存储所有相关节点（包括子节点、孙节点等）
            List<TreeNode> allNodes = new List<TreeNode>();

            // 获取当前节点及其所有子节点
            GetAllChildNodes(selectedNode, allNodes);

            // 查询这些节点的数据库信息
            QueryNodesInfoFromDatabase(allNodes);
        }
        private void GetAllChildNodes(TreeNode node, List<TreeNode> nodeList)
        {
            // 添加当前节点到列表
            nodeList.Add(node);

            // 递归获取所有子节点
            foreach (TreeNode childNode in node.Nodes)
            {
                GetAllChildNodes(childNode, nodeList);
            }
        }

        private void QueryNodesInfoFromDatabase(List<TreeNode> nodes)
        {
            // 定义数据库连接字符串

            // 定义SQL查询，
            string query = "SELECT * FROM 部门信息表 WHERE 部门层级 like @NodeTag ";

            // 使用ADO.NET查询数据库
            using (SqlConnection connection1 = connection())
            {
                // 创建DataTable来存储所有结果
                DataTable allNodesInfo = new DataTable();

                foreach (TreeNode node in nodes)
                {
                    string nodeTag = node.Tag.ToString();

                    // 使用SqlDataAdapter来执行查询
                    SqlDataAdapter da = new SqlDataAdapter(query, connection1);
                    da.SelectCommand.Parameters.AddWithValue("@NodeTag", nodeTag);

                    try
                    {
                        // 填充DataTable
                        connection1.Open();
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        connection1.Close();

                        // 合并到总的DataTable中
                        allNodesInfo.Merge(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"查询数据库时出错: {ex.Message}");
                    }
                }

                // 将结果绑定到DataGridView
                dataGridView1.DataSource = allNodesInfo;
            }
        
        }

    }
}
