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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            roleTreeView = new TreeView();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            panel8 = new Panel();
            chkDelete_Module6 = new CheckBox();
            chkCreate_Module6 = new CheckBox();
            chkEdit_Module6 = new CheckBox();
            chkView_Module6 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            chkDelete_Module4 = new CheckBox();
            chkCreate_Module4 = new CheckBox();
            chkEdit_Module4 = new CheckBox();
            chkView_Module4 = new CheckBox();
            panel2 = new Panel();
            chkDelete_Module1 = new CheckBox();
            chkCreate_Module1 = new CheckBox();
            chkEdit_Module1 = new CheckBox();
            chkView_Module1 = new CheckBox();
            panel3 = new Panel();
            chkDelete_Module2 = new CheckBox();
            chkCreate_Module2 = new CheckBox();
            chkEdit_Module2 = new CheckBox();
            chkView_Module2 = new CheckBox();
            panel4 = new Panel();
            chkDelete_Module3 = new CheckBox();
            chkCreate_Module3 = new CheckBox();
            chkEdit_Module3 = new CheckBox();
            chkView_Module3 = new CheckBox();
            panel6 = new Panel();
            chkDelete_Module5 = new CheckBox();
            chkCreate_Module5 = new CheckBox();
            chkEdit_Module5 = new CheckBox();
            chkView_Module5 = new CheckBox();
            label1 = new Label();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 989F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.Size = new Size(1688, 1136);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // panel1
            // 
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
            // button4
            // 
            button4.Location = new Point(117, 3);
            button4.Name = "button4";
            button4.Size = new Size(121, 68);
            button4.TabIndex = 3;
            button4.Text = "添加";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(374, 3);
            button3.Name = "button3";
            button3.Size = new Size(121, 65);
            button3.TabIndex = 2;
            button3.Text = "角色赋予";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 3);
            button2.Name = "button2";
            button2.Size = new Size(124, 65);
            button2.TabIndex = 1;
            button2.Text = "保存";
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
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.10107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.89893F));
            tableLayoutPanel1.Controls.Add(roleTreeView, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1682, 983);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // roleTreeView
            // 
            roleTreeView.AllowDrop = true;
            roleTreeView.Dock = DockStyle.Fill;
            roleTreeView.HotTracking = true;
            roleTreeView.Location = new Point(3, 3);
            roleTreeView.Name = "roleTreeView";
            roleTreeView.Size = new Size(248, 977);
            roleTreeView.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.Controls.Add(label6, 5, 0);
            tableLayoutPanel3.Controls.Add(panel8, 5, 1);
            tableLayoutPanel3.Controls.Add(label5, 4, 0);
            tableLayoutPanel3.Controls.Add(label4, 3, 0);
            tableLayoutPanel3.Controls.Add(label3, 2, 0);
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(panel5, 3, 1);
            tableLayoutPanel3.Controls.Add(panel2, 0, 1);
            tableLayoutPanel3.Controls.Add(panel3, 1, 1);
            tableLayoutPanel3.Controls.Add(panel4, 2, 1);
            tableLayoutPanel3.Controls.Add(panel6, 4, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Location = new Point(257, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 22.014925F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 77.98508F));
            tableLayoutPanel3.Size = new Size(1422, 268);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft YaHei UI", 12F);
            label6.Location = new Point(1188, 0);
            label6.Name = "label6";
            label6.Size = new Size(231, 59);
            label6.TabIndex = 11;
            label6.Text = "系统管理";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(chkDelete_Module6);
            panel8.Controls.Add(chkCreate_Module6);
            panel8.Controls.Add(chkEdit_Module6);
            panel8.Controls.Add(chkView_Module6);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1188, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(231, 203);
            panel8.TabIndex = 10;
            // 
            // chkDelete_Module6
            // 
            chkDelete_Module6.AutoSize = true;
            chkDelete_Module6.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkDelete_Module6.Location = new Point(55, 151);
            chkDelete_Module6.Name = "chkDelete_Module6";
            chkDelete_Module6.Size = new Size(99, 41);
            chkDelete_Module6.TabIndex = 7;
            chkDelete_Module6.Text = "删除";
            chkDelete_Module6.UseVisualStyleBackColor = true;
            // 
            // chkCreate_Module6
            // 
            chkCreate_Module6.AutoSize = true;
            chkCreate_Module6.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkCreate_Module6.Location = new Point(55, 57);
            chkCreate_Module6.Name = "chkCreate_Module6";
            chkCreate_Module6.Size = new Size(99, 41);
            chkCreate_Module6.TabIndex = 6;
            chkCreate_Module6.Text = "增加";
            chkCreate_Module6.UseVisualStyleBackColor = true;
            // 
            // chkEdit_Module6
            // 
            chkEdit_Module6.AutoSize = true;
            chkEdit_Module6.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkEdit_Module6.Location = new Point(55, 104);
            chkEdit_Module6.Name = "chkEdit_Module6";
            chkEdit_Module6.Size = new Size(99, 41);
            chkEdit_Module6.TabIndex = 5;
            chkEdit_Module6.Text = "修改";
            chkEdit_Module6.UseVisualStyleBackColor = true;
            // 
            // chkView_Module6
            // 
            chkView_Module6.AutoSize = true;
            chkView_Module6.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkView_Module6.Location = new Point(55, 10);
            chkView_Module6.Name = "chkView_Module6";
            chkView_Module6.Size = new Size(99, 41);
            chkView_Module6.TabIndex = 4;
            chkView_Module6.Text = "查看";
            chkView_Module6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft YaHei UI", 12F);
            label5.Location = new Point(951, 0);
            label5.Name = "label5";
            label5.Size = new Size(231, 59);
            label5.TabIndex = 8;
            label5.Text = "仓库管理";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft YaHei UI", 12F);
            label4.Location = new Point(714, 0);
            label4.Name = "label4";
            label4.Size = new Size(231, 59);
            label4.TabIndex = 7;
            label4.Text = "采购管理";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft YaHei UI", 12F);
            label3.Location = new Point(477, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 59);
            label3.TabIndex = 6;
            label3.Text = "销售管理";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft YaHei UI", 12F);
            label2.Location = new Point(240, 0);
            label2.Name = "label2";
            label2.Size = new Size(231, 59);
            label2.TabIndex = 5;
            label2.Text = "计划管理";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(chkDelete_Module4);
            panel5.Controls.Add(chkCreate_Module4);
            panel5.Controls.Add(chkEdit_Module4);
            panel5.Controls.Add(chkView_Module4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(714, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 203);
            panel5.TabIndex = 1;
            // 
            // chkDelete_Module4
            // 
            chkDelete_Module4.AutoSize = true;
            chkDelete_Module4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkDelete_Module4.Location = new Point(55, 151);
            chkDelete_Module4.Name = "chkDelete_Module4";
            chkDelete_Module4.Size = new Size(99, 41);
            chkDelete_Module4.TabIndex = 7;
            chkDelete_Module4.Text = "删除";
            chkDelete_Module4.UseVisualStyleBackColor = true;
            // 
            // chkCreate_Module4
            // 
            chkCreate_Module4.AutoSize = true;
            chkCreate_Module4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkCreate_Module4.Location = new Point(55, 57);
            chkCreate_Module4.Name = "chkCreate_Module4";
            chkCreate_Module4.Size = new Size(99, 41);
            chkCreate_Module4.TabIndex = 6;
            chkCreate_Module4.Text = "增加";
            chkCreate_Module4.UseVisualStyleBackColor = true;
            // 
            // chkEdit_Module4
            // 
            chkEdit_Module4.AutoSize = true;
            chkEdit_Module4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkEdit_Module4.Location = new Point(55, 104);
            chkEdit_Module4.Name = "chkEdit_Module4";
            chkEdit_Module4.Size = new Size(99, 41);
            chkEdit_Module4.TabIndex = 5;
            chkEdit_Module4.Text = "修改";
            chkEdit_Module4.UseVisualStyleBackColor = true;
            // 
            // chkView_Module4
            // 
            chkView_Module4.AutoSize = true;
            chkView_Module4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkView_Module4.Location = new Point(55, 10);
            chkView_Module4.Name = "chkView_Module4";
            chkView_Module4.Size = new Size(99, 41);
            chkView_Module4.TabIndex = 4;
            chkView_Module4.Text = "查看";
            chkView_Module4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(chkDelete_Module1);
            panel2.Controls.Add(chkCreate_Module1);
            panel2.Controls.Add(chkEdit_Module1);
            panel2.Controls.Add(chkView_Module1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 203);
            panel2.TabIndex = 0;
            // 
            // chkDelete_Module1
            // 
            chkDelete_Module1.AutoSize = true;
            chkDelete_Module1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkDelete_Module1.Location = new Point(47, 151);
            chkDelete_Module1.Name = "chkDelete_Module1";
            chkDelete_Module1.Size = new Size(99, 41);
            chkDelete_Module1.TabIndex = 3;
            chkDelete_Module1.Text = "删除";
            chkDelete_Module1.UseVisualStyleBackColor = true;
            chkDelete_Module1.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // chkCreate_Module1
            // 
            chkCreate_Module1.AutoSize = true;
            chkCreate_Module1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkCreate_Module1.Location = new Point(47, 57);
            chkCreate_Module1.Name = "chkCreate_Module1";
            chkCreate_Module1.Size = new Size(99, 41);
            chkCreate_Module1.TabIndex = 2;
            chkCreate_Module1.Text = "增加";
            chkCreate_Module1.UseVisualStyleBackColor = true;
            chkCreate_Module1.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chkEdit_Module1
            // 
            chkEdit_Module1.AutoSize = true;
            chkEdit_Module1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkEdit_Module1.Location = new Point(47, 104);
            chkEdit_Module1.Name = "chkEdit_Module1";
            chkEdit_Module1.Size = new Size(99, 41);
            chkEdit_Module1.TabIndex = 1;
            chkEdit_Module1.Text = "修改";
            chkEdit_Module1.UseVisualStyleBackColor = true;
            // 
            // chkView_Module1
            // 
            chkView_Module1.AutoSize = true;
            chkView_Module1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkView_Module1.Location = new Point(47, 10);
            chkView_Module1.Name = "chkView_Module1";
            chkView_Module1.Size = new Size(99, 41);
            chkView_Module1.TabIndex = 0;
            chkView_Module1.Text = "查看";
            chkView_Module1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(chkDelete_Module2);
            panel3.Controls.Add(chkCreate_Module2);
            panel3.Controls.Add(chkEdit_Module2);
            panel3.Controls.Add(chkView_Module2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(240, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 203);
            panel3.TabIndex = 1;
            // 
            // chkDelete_Module2
            // 
            chkDelete_Module2.AutoSize = true;
            chkDelete_Module2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkDelete_Module2.Location = new Point(55, 151);
            chkDelete_Module2.Name = "chkDelete_Module2";
            chkDelete_Module2.Size = new Size(99, 41);
            chkDelete_Module2.TabIndex = 7;
            chkDelete_Module2.Text = "删除";
            chkDelete_Module2.UseVisualStyleBackColor = true;
            // 
            // chkCreate_Module2
            // 
            chkCreate_Module2.AutoSize = true;
            chkCreate_Module2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkCreate_Module2.Location = new Point(55, 57);
            chkCreate_Module2.Name = "chkCreate_Module2";
            chkCreate_Module2.Size = new Size(99, 41);
            chkCreate_Module2.TabIndex = 6;
            chkCreate_Module2.Text = "增加";
            chkCreate_Module2.UseVisualStyleBackColor = true;
            // 
            // chkEdit_Module2
            // 
            chkEdit_Module2.AutoSize = true;
            chkEdit_Module2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkEdit_Module2.Location = new Point(55, 104);
            chkEdit_Module2.Name = "chkEdit_Module2";
            chkEdit_Module2.Size = new Size(99, 41);
            chkEdit_Module2.TabIndex = 5;
            chkEdit_Module2.Text = "修改";
            chkEdit_Module2.UseVisualStyleBackColor = true;
            // 
            // chkView_Module2
            // 
            chkView_Module2.AutoSize = true;
            chkView_Module2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkView_Module2.Location = new Point(55, 10);
            chkView_Module2.Name = "chkView_Module2";
            chkView_Module2.Size = new Size(99, 41);
            chkView_Module2.TabIndex = 4;
            chkView_Module2.Text = "查看";
            chkView_Module2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(chkDelete_Module3);
            panel4.Controls.Add(chkCreate_Module3);
            panel4.Controls.Add(chkEdit_Module3);
            panel4.Controls.Add(chkView_Module3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(477, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 203);
            panel4.TabIndex = 2;
            // 
            // chkDelete_Module3
            // 
            chkDelete_Module3.AutoSize = true;
            chkDelete_Module3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkDelete_Module3.Location = new Point(55, 151);
            chkDelete_Module3.Name = "chkDelete_Module3";
            chkDelete_Module3.Size = new Size(99, 41);
            chkDelete_Module3.TabIndex = 7;
            chkDelete_Module3.Text = "删除";
            chkDelete_Module3.UseVisualStyleBackColor = true;
            // 
            // chkCreate_Module3
            // 
            chkCreate_Module3.AutoSize = true;
            chkCreate_Module3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkCreate_Module3.Location = new Point(55, 57);
            chkCreate_Module3.Name = "chkCreate_Module3";
            chkCreate_Module3.Size = new Size(99, 41);
            chkCreate_Module3.TabIndex = 6;
            chkCreate_Module3.Text = "增加";
            chkCreate_Module3.UseVisualStyleBackColor = true;
            // 
            // chkEdit_Module3
            // 
            chkEdit_Module3.AutoSize = true;
            chkEdit_Module3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkEdit_Module3.Location = new Point(55, 104);
            chkEdit_Module3.Name = "chkEdit_Module3";
            chkEdit_Module3.Size = new Size(99, 41);
            chkEdit_Module3.TabIndex = 5;
            chkEdit_Module3.Text = "修改";
            chkEdit_Module3.UseVisualStyleBackColor = true;
            // 
            // chkView_Module3
            // 
            chkView_Module3.AutoSize = true;
            chkView_Module3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkView_Module3.Location = new Point(55, 10);
            chkView_Module3.Name = "chkView_Module3";
            chkView_Module3.Size = new Size(99, 41);
            chkView_Module3.TabIndex = 4;
            chkView_Module3.Text = "查看";
            chkView_Module3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(chkDelete_Module5);
            panel6.Controls.Add(chkCreate_Module5);
            panel6.Controls.Add(chkEdit_Module5);
            panel6.Controls.Add(chkView_Module5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(951, 62);
            panel6.Name = "panel6";
            panel6.Size = new Size(231, 203);
            panel6.TabIndex = 3;
            // 
            // chkDelete_Module5
            // 
            chkDelete_Module5.AutoSize = true;
            chkDelete_Module5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkDelete_Module5.Location = new Point(55, 151);
            chkDelete_Module5.Name = "chkDelete_Module5";
            chkDelete_Module5.Size = new Size(99, 41);
            chkDelete_Module5.TabIndex = 7;
            chkDelete_Module5.Text = "删除";
            chkDelete_Module5.UseVisualStyleBackColor = true;
            // 
            // chkCreate_Module5
            // 
            chkCreate_Module5.AutoSize = true;
            chkCreate_Module5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkCreate_Module5.Location = new Point(55, 57);
            chkCreate_Module5.Name = "chkCreate_Module5";
            chkCreate_Module5.Size = new Size(99, 41);
            chkCreate_Module5.TabIndex = 6;
            chkCreate_Module5.Text = "增加";
            chkCreate_Module5.UseVisualStyleBackColor = true;
            // 
            // chkEdit_Module5
            // 
            chkEdit_Module5.AutoSize = true;
            chkEdit_Module5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkEdit_Module5.Location = new Point(55, 104);
            chkEdit_Module5.Name = "chkEdit_Module5";
            chkEdit_Module5.Size = new Size(99, 41);
            chkEdit_Module5.TabIndex = 5;
            chkEdit_Module5.Text = "修改";
            chkEdit_Module5.UseVisualStyleBackColor = true;
            // 
            // chkView_Module5
            // 
            chkView_Module5.AutoSize = true;
            chkView_Module5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            chkView_Module5.Location = new Point(55, 10);
            chkView_Module5.Name = "chkView_Module5";
            chkView_Module5.Size = new Size(99, 41);
            chkView_Module5.TabIndex = 4;
            chkView_Module5.Text = "查看";
            chkView_Module5.UseVisualStyleBackColor = true;
            chkView_Module5.CheckedChanged += checkBox16_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 59);
            label1.TabIndex = 4;
            label1.Text = "基础管理";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // syswhplat
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "syswhplat";
            Size = new Size(1688, 1136);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TreeView roleTreeView;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Button button1;
        private Panel panel5;
        private Panel panel2;
        private CheckBox chkCreate_Module1;
        private CheckBox chkEdit_Module1;
        private CheckBox chkView_Module1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private CheckBox chkDelete_Module1;
        private CheckBox chkDelete_Module4;
        private CheckBox chkCreate_Module4;
        private CheckBox chkEdit_Module4;
        private CheckBox chkView_Module4;
        private CheckBox chkDelete_Module2;
        private CheckBox chkCreate_Module2;
        private CheckBox chkEdit_Module2;
        private CheckBox chkView_Module2;
        private CheckBox chkDelete_Module3;
        private CheckBox chkCreate_Module3;
        private CheckBox chkEdit_Module3;
        private CheckBox chkView_Module3;
        private CheckBox chkDelete_Module5;
        private CheckBox chkCreate_Module5;
        private CheckBox chkEdit_Module5;
        private CheckBox chkView_Module5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Panel panel8;
        private CheckBox chkDelete_Module6;
        private CheckBox chkCreate_Module6;
        private CheckBox chkEdit_Module6;
        private CheckBox chkView_Module6;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
