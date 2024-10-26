namespace WinFormsApp1.销售管理
{
    partial class ExamineForm
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
            ecreat = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // ecreat
            // 
            ecreat.BackColor = SystemColors.GradientInactiveCaption;
            ecreat.Location = new Point(50, 29);
            ecreat.Name = "ecreat";
            ecreat.Size = new Size(124, 40);
            ecreat.TabIndex = 1;
            ecreat.Text = "审核订单";
            ecreat.UseVisualStyleBackColor = false;
            ecreat.Click += ecreat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(886, 243);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += exdataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.Location = new Point(180, 29);
            button4.Name = "button4";
            button4.Size = new Size(124, 40);
            button4.TabIndex = 8;
            button4.Text = "刷新";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(50, 423);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(886, 246);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 92);
            label1.Name = "label1";
            label1.Size = new Size(118, 24);
            label1.TabIndex = 10;
            label1.Text = "审核通过列表";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 384);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 11;
            label2.Text = "审核不通过列表";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(191, 92);
            button1.Name = "button1";
            button1.Size = new Size(113, 32);
            button1.TabIndex = 12;
            button1.Text = "删除";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 380);
            button2.Name = "button2";
            button2.Size = new Size(113, 32);
            button2.TabIndex = 13;
            button2.Text = "删除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ExamineForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(ecreat);
            Name = "ExamineForm";
            Size = new Size(1688, 1136);
            Load += ExamineForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ecreat;
        private Button button4;
        public DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        public DataGridView dataGridView2;
    }
}
