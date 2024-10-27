namespace WinFormsApp1.销售管理
{
    partial class ReturnForm
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
            srsearch = new Button();
            srdelete = new Button();
            sredit = new Button();
            srcreat = new Button();
            dataGridView1 = new DataGridView();
            sredit2 = new Button();
            srcancel = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // srsearch
            // 
            srsearch.BackColor = SystemColors.GradientInactiveCaption;
            srsearch.Location = new Point(482, 52);
            srsearch.Name = "srsearch";
            srsearch.Size = new Size(138, 40);
            srsearch.TabIndex = 70;
            srsearch.Text = "查询";
            srsearch.UseVisualStyleBackColor = false;
            srsearch.Click += srsearch_Click;
            // 
            // srdelete
            // 
            srdelete.BackColor = SystemColors.GradientInactiveCaption;
            srdelete.Location = new Point(338, 52);
            srdelete.Name = "srdelete";
            srdelete.Size = new Size(138, 40);
            srdelete.TabIndex = 69;
            srdelete.Text = "删除";
            srdelete.UseVisualStyleBackColor = false;
            srdelete.Click += srdelete_Click;
            // 
            // sredit
            // 
            sredit.BackColor = SystemColors.GradientInactiveCaption;
            sredit.Location = new Point(194, 52);
            sredit.Name = "sredit";
            sredit.Size = new Size(138, 40);
            sredit.TabIndex = 68;
            sredit.Text = "修改";
            sredit.UseVisualStyleBackColor = false;
            sredit.Click += sredit_Click;
            // 
            // srcreat
            // 
            srcreat.BackColor = SystemColors.GradientInactiveCaption;
            srcreat.Location = new Point(50, 52);
            srcreat.Name = "srcreat";
            srcreat.Size = new Size(138, 40);
            srcreat.TabIndex = 67;
            srcreat.Text = "新建";
            srcreat.UseVisualStyleBackColor = false;
            srcreat.Click += srcreat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1170, 745);
            dataGridView1.TabIndex = 73;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // sredit2
            // 
            sredit2.BackColor = SystemColors.GradientInactiveCaption;
            sredit2.Location = new Point(50, 109);
            sredit2.Name = "sredit2";
            sredit2.Size = new Size(138, 40);
            sredit2.TabIndex = 74;
            sredit2.Text = "修改完成";
            sredit2.UseVisualStyleBackColor = false;
            sredit2.Visible = false;
            sredit2.Click += sredit2_Click;
            // 
            // srcancel
            // 
            srcancel.BackColor = SystemColors.GradientInactiveCaption;
            srcancel.Location = new Point(194, 109);
            srcancel.Name = "srcancel";
            srcancel.Size = new Size(138, 40);
            srcancel.TabIndex = 75;
            srcancel.Text = "取消修改";
            srcancel.UseVisualStyleBackColor = false;
            srcancel.Visible = false;
            srcancel.Click += srcancel_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(626, 52);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 76;
            button1.Text = "刷新";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(srcancel);
            Controls.Add(sredit2);
            Controls.Add(dataGridView1);
            Controls.Add(srsearch);
            Controls.Add(srdelete);
            Controls.Add(sredit);
            Controls.Add(srcreat);
            Name = "ReturnForm";
            Size = new Size(1688, 1136);
            Load += ReturnForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button srsearch;
        private Button srdelete;
        private Button sredit;
        private Button srcreat;
        private Button sredit2;
        private Button srcancel;
        public DataGridView dataGridView1;
        private Button button1;
    }
}
