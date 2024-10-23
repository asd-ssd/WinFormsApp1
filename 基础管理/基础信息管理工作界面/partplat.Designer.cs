namespace WinFormsApp1.基础信息管理工作界面
{
    partial class partplat
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            treeView1 = new TreeView();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 830F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 229F));
            tableLayoutPanel2.Size = new Size(1688, 1136);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1682, 71);
            panel1.TabIndex = 2;
            // 
            // button7
            // 
            button7.Location = new Point(870, 18);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 6;
            button7.Text = "取消";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(702, 18);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 5;
            button6.Text = "修改完成";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(459, 3);
            button5.Name = "button5";
            button5.Size = new Size(108, 65);
            button5.TabIndex = 4;
            button5.Text = "删除";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(345, 3);
            button4.Name = "button4";
            button4.Size = new Size(108, 65);
            button4.TabIndex = 3;
            button4.Text = "修改";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(231, 3);
            button3.Name = "button3";
            button3.Size = new Size(108, 65);
            button3.TabIndex = 2;
            button3.Text = "查询";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 3);
            button2.Name = "button2";
            button2.Size = new Size(108, 65);
            button2.TabIndex = 1;
            button2.Text = "新增";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(108, 65);
            button1.TabIndex = 0;
            button1.Text = "刷新";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.8787155F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.1212845F));
            tableLayoutPanel1.Controls.Add(treeView1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1682, 824);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(3, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(362, 818);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(371, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1308, 818);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // partplat
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "partplat";
            Size = new Size(1688, 1136);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }



        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button7;
        private Button button6;
        public DataGridView dataGridView1;
        public TreeView treeView1;
    }
}
