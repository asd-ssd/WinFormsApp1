namespace WinFormsApp1
{
    partial class clientform
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
            ccreat = new Button();
            cedit = new Button();
            cdelete = new Button();
            dataGridView1 = new DataGridView();
            csearch = new Button();
            ccancel = new Button();
            cedit2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ccreat
            // 
            ccreat.BackColor = SystemColors.GradientInactiveCaption;
            ccreat.Location = new Point(50, 30);
            ccreat.Name = "ccreat";
            ccreat.Size = new Size(145, 40);
            ccreat.TabIndex = 0;
            ccreat.Text = "新建";
            ccreat.UseVisualStyleBackColor = false;
            ccreat.Click += ccreat_Click;
            // 
            // cedit
            // 
            cedit.BackColor = SystemColors.GradientInactiveCaption;
            cedit.Location = new Point(201, 30);
            cedit.Name = "cedit";
            cedit.Size = new Size(145, 40);
            cedit.TabIndex = 1;
            cedit.Text = "修改";
            cedit.UseVisualStyleBackColor = false;
            cedit.Click += cedit_Click;
            // 
            // cdelete
            // 
            cdelete.BackColor = SystemColors.GradientInactiveCaption;
            cdelete.Location = new Point(352, 30);
            cdelete.Name = "cdelete";
            cdelete.Size = new Size(145, 40);
            cdelete.TabIndex = 2;
            cdelete.Text = "删除";
            cdelete.UseVisualStyleBackColor = false;
            cdelete.Click += cdelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1550, 892);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // csearch
            // 
            csearch.BackColor = SystemColors.GradientInactiveCaption;
            csearch.Location = new Point(505, 30);
            csearch.Name = "csearch";
            csearch.Size = new Size(145, 40);
            csearch.TabIndex = 5;
            csearch.Text = "查询";
            csearch.UseVisualStyleBackColor = false;
            csearch.Click += csearch_Click;
            // 
            // ccancel
            // 
            ccancel.BackColor = SystemColors.GradientInactiveCaption;
            ccancel.Location = new Point(201, 102);
            ccancel.Name = "ccancel";
            ccancel.Size = new Size(145, 40);
            ccancel.TabIndex = 6;
            ccancel.Text = "取消修改";
            ccancel.UseVisualStyleBackColor = false;
            ccancel.Click += ccancel_Click;
            // 
            // cedit2
            // 
            cedit2.BackColor = SystemColors.GradientInactiveCaption;
            cedit2.Location = new Point(50, 102);
            cedit2.Name = "cedit2";
            cedit2.Size = new Size(145, 40);
            cedit2.TabIndex = 7;
            cedit2.Text = "修改完成";
            cedit2.UseVisualStyleBackColor = false;
            cedit2.Click += cedit2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(656, 30);
            button1.Name = "button1";
            button1.Size = new Size(145, 40);
            button1.TabIndex = 8;
            button1.Text = "刷新";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // clientform
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(cedit2);
            Controls.Add(ccancel);
            Controls.Add(csearch);
            Controls.Add(dataGridView1);
            Controls.Add(cdelete);
            Controls.Add(cedit);
            Controls.Add(ccreat);
            Name = "clientform";
            Size = new Size(1688, 1136);
            Load += clientform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ccreat;
        private Button cedit;
        private Button cdelete;
        private Button csearch;
        private Button ccancel;
        private Button cedit2;
        public DataGridView dataGridView1;
        private Button button1;
    }
}
