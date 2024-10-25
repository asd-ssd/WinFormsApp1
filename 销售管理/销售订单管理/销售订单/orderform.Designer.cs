namespace WinFormsApp1
{
    partial class orderform
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
            odelete = new Button();
            oedit = new Button();
            ocreat = new Button();
            osearch = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // odelete
            // 
            odelete.BackColor = SystemColors.GradientInactiveCaption;
            odelete.Location = new Point(308, 30);
            odelete.Name = "odelete";
            odelete.Size = new Size(123, 40);
            odelete.TabIndex = 7;
            odelete.Text = "删除";
            odelete.UseVisualStyleBackColor = false;
            odelete.Click += odelete_Click;
            // 
            // oedit
            // 
            oedit.BackColor = SystemColors.GradientInactiveCaption;
            oedit.Location = new Point(179, 30);
            oedit.Name = "oedit";
            oedit.Size = new Size(123, 40);
            oedit.TabIndex = 6;
            oedit.Text = "修改";
            oedit.UseVisualStyleBackColor = false;
            oedit.Click += oedit_Click;
            // 
            // ocreat
            // 
            ocreat.BackColor = SystemColors.GradientInactiveCaption;
            ocreat.Location = new Point(50, 30);
            ocreat.Name = "ocreat";
            ocreat.Size = new Size(123, 40);
            ocreat.TabIndex = 5;
            ocreat.Text = "新建";
            ocreat.UseVisualStyleBackColor = false;
            ocreat.Click += ocreat_Click;
            // 
            // osearch
            // 
            osearch.BackColor = SystemColors.GradientInactiveCaption;
            osearch.Location = new Point(437, 30);
            osearch.Name = "osearch";
            osearch.Size = new Size(123, 40);
            osearch.TabIndex = 62;
            osearch.Text = "查询";
            osearch.UseVisualStyleBackColor = false;
            osearch.Click += osearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1550, 900);
            dataGridView1.TabIndex = 78;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(566, 30);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 79;
            button1.Text = "确认修改";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Location = new Point(695, 30);
            button2.Name = "button2";
            button2.Size = new Size(123, 40);
            button2.TabIndex = 80;
            button2.Text = "取消修改";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Location = new Point(50, 89);
            button3.Name = "button3";
            button3.Size = new Size(123, 40);
            button3.TabIndex = 81;
            button3.Text = "刷新";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // orderform
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(osearch);
            Controls.Add(odelete);
            Controls.Add(oedit);
            Controls.Add(ocreat);
            Name = "orderform";
            Size = new Size(1688, 1136);
            Load += orderform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button odelete;
        private Button oedit;
        private Button ocreat;
        private Button osearch;
        private Button button1;
        private Button button2;
        public DataGridView dataGridView1;
        private Button button3;
    }
}
