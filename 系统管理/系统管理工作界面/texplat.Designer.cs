namespace WinFormsApp1.系统管理工作界面
{
    partial class texplat
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
            dgv_data = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            button2 = new Button();
            dtp_end = new DateTimePicker();
            dtp_start = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            chk_operationInfo = new CheckBox();
            chk_alarmInfo = new CheckBox();
            chk_logInfo = new CheckBox();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_data
            // 
            dgv_data.BackgroundColor = SystemColors.ControlLight;
            dgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Dock = DockStyle.Fill;
            dgv_data.Location = new Point(3, 140);
            dgv_data.Name = "dgv_data";
            dgv_data.RowHeadersWidth = 62;
            dgv_data.Size = new Size(1682, 993);
            dgv_data.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(dgv_data, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 999F));
            tableLayoutPanel2.Size = new Size(1688, 1136);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dtp_end);
            panel1.Controls.Add(dtp_start);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(chk_operationInfo);
            panel1.Controls.Add(chk_alarmInfo);
            panel1.Controls.Add(chk_logInfo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1682, 131);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(950, 16);
            button2.Name = "button2";
            button2.Size = new Size(107, 70);
            button2.TabIndex = 13;
            button2.Text = "查询今天";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dtp_end
            // 
            dtp_end.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.Location = new Point(521, 32);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(267, 34);
            dtp_end.TabIndex = 12;
            // 
            // dtp_start
            // 
            dtp_start.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.Location = new Point(129, 32);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(267, 34);
            dtp_start.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 35);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 10;
            label3.Text = "结束时间";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 35);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 9;
            label2.Text = "开始时间";
            // 
            // chk_operationInfo
            // 
            chk_operationInfo.AutoSize = true;
            chk_operationInfo.Checked = true;
            chk_operationInfo.CheckState = CheckState.Checked;
            chk_operationInfo.Location = new Point(368, 93);
            chk_operationInfo.Name = "chk_operationInfo";
            chk_operationInfo.Size = new Size(122, 32);
            chk_operationInfo.TabIndex = 8;
            chk_operationInfo.Text = "操作记录";
            chk_operationInfo.UseVisualStyleBackColor = true;
            // 
            // chk_alarmInfo
            // 
            chk_alarmInfo.AutoSize = true;
            chk_alarmInfo.Checked = true;
            chk_alarmInfo.CheckState = CheckState.Checked;
            chk_alarmInfo.Location = new Point(250, 93);
            chk_alarmInfo.Name = "chk_alarmInfo";
            chk_alarmInfo.Size = new Size(122, 32);
            chk_alarmInfo.TabIndex = 7;
            chk_alarmInfo.Text = "报警信息";
            chk_alarmInfo.UseVisualStyleBackColor = true;
            // 
            // chk_logInfo
            // 
            chk_logInfo.AutoSize = true;
            chk_logInfo.Checked = true;
            chk_logInfo.CheckState = CheckState.Checked;
            chk_logInfo.Location = new Point(122, 93);
            chk_logInfo.Name = "chk_logInfo";
            chk_logInfo.Size = new Size(122, 32);
            chk_logInfo.TabIndex = 6;
            chk_logInfo.Text = "日志信息";
            chk_logInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 93);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 5;
            label1.Text = "日志类型：";
            // 
            // button3
            // 
            button3.Location = new Point(804, 16);
            button3.Name = "button3";
            button3.Size = new Size(107, 70);
            button3.TabIndex = 2;
            button3.Text = "查询";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1088, 14);
            button1.Name = "button1";
            button1.Size = new Size(109, 70);
            button1.TabIndex = 0;
            button1.Text = "刷新";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // texplat
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "texplat";
            Size = new Size(1688, 1136);
            Load += texplat_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_data;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button button3;
        private Button button1;
        private CheckBox chk_operationInfo;
        private CheckBox chk_alarmInfo;
        private CheckBox chk_logInfo;
        private Label label1;
        private DateTimePicker dtp_end;
        private DateTimePicker dtp_start;
        private Label label3;
        private Label label2;
        private Button button2;
    }
}
