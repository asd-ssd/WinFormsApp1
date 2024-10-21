namespace WinFormsApp1.系统管理工作界面
{
    partial class syswhplat
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {

            TreeNode treeNode1 = new TreeNode("角色1");
            TreeNode treeNode2 = new TreeNode("角色组", new TreeNode[] { treeNode1 });
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            treeView1 = new TreeView();
            tableLayoutPanel3 = new TableLayoutPanel();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox3 = new CheckedListBox();
            checkedListBox4 = new CheckedListBox();
            checkedListBox5 = new CheckedListBox();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);

            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 830F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 229F));
            tableLayoutPanel2.Size = new Size(1688, 1136);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.10107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.89893F));
            tableLayoutPanel1.Controls.Add(treeView1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1682, 824);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.AllowDrop = true;
            treeView1.CheckBoxes = true;
            treeView1.Dock = DockStyle.Fill;
            treeView1.HotTracking = true;
            treeView1.Location = new Point(3, 3);
            treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "角色1";
            treeNode2.Name = "节点0";
            treeNode2.Text = "角色组";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode2 });
            treeView1.Size = new Size(248, 818);
            treeView1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(checkedListBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(checkedListBox2, 1, 1);
            tableLayoutPanel3.Controls.Add(checkedListBox3, 2, 1);
            tableLayoutPanel3.Controls.Add(checkedListBox4, 3, 1);
            tableLayoutPanel3.Controls.Add(checkedListBox5, 4, 1);
            tableLayoutPanel3.Location = new Point(257, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6899614F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 88.3100357F));
            tableLayoutPanel3.Size = new Size(1193, 489);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.Font = new Font("Microsoft YaHei UI", 15F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "查看", "增加", "删除", "修改" });
            checkedListBox1.Location = new Point(3, 60);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.RightToLeft = RightToLeft.No;
            checkedListBox1.Size = new Size(232, 426);
            checkedListBox1.TabIndex = 1;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BorderStyle = BorderStyle.None;
            checkedListBox2.Dock = DockStyle.Fill;
            checkedListBox2.Font = new Font("Microsoft YaHei UI", 15F);
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "查看", "增加", "删除", "修改" });
            checkedListBox2.Location = new Point(241, 60);
            checkedListBox2.MultiColumn = true;
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.RightToLeft = RightToLeft.No;
            checkedListBox2.Size = new Size(232, 426);
            checkedListBox2.TabIndex = 2;
            // 
            // checkedListBox3
            // 
            checkedListBox3.BorderStyle = BorderStyle.None;
            checkedListBox3.Dock = DockStyle.Fill;
            checkedListBox3.Font = new Font("Microsoft YaHei UI", 15F);
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "查看", "增加", "删除", "修改" });
            checkedListBox3.Location = new Point(479, 60);
            checkedListBox3.MultiColumn = true;
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.RightToLeft = RightToLeft.No;
            checkedListBox3.Size = new Size(232, 426);
            checkedListBox3.TabIndex = 3;
            // 
            // checkedListBox4
            // 
            checkedListBox4.BorderStyle = BorderStyle.None;
            checkedListBox4.Dock = DockStyle.Fill;
            checkedListBox4.Font = new Font("Microsoft YaHei UI", 15F);
            checkedListBox4.FormattingEnabled = true;
            checkedListBox4.Items.AddRange(new object[] { "查看", "增加", "删除", "修改" });
            checkedListBox4.Location = new Point(717, 60);
            checkedListBox4.MultiColumn = true;
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.RightToLeft = RightToLeft.No;
            checkedListBox4.Size = new Size(232, 426);
            checkedListBox4.TabIndex = 4;
            // 
            // checkedListBox5
            // 
            checkedListBox5.BorderStyle = BorderStyle.None;
            checkedListBox5.Dock = DockStyle.Fill;
            checkedListBox5.Font = new Font("Microsoft YaHei UI", 15F);
            checkedListBox5.FormattingEnabled = true;
            checkedListBox5.Items.AddRange(new object[] { "查看", "增加", "删除", "修改" });
            checkedListBox5.Location = new Point(955, 60);
            checkedListBox5.MultiColumn = true;
            checkedListBox5.Name = "checkedListBox5";
            checkedListBox5.RightToLeft = RightToLeft.No;
            checkedListBox5.Size = new Size(235, 426);
            checkedListBox5.TabIndex = 5;
            // 
            // syswhplat
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "syswhplat";
            Size = new Size(1688, 1136);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TreeView treeView1;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private CheckedListBox checkedListBox4;
        private CheckedListBox checkedListBox5;
    }
}
