namespace WinFormsApp1.销售管理.收发货管理.发货
{
    partial class Delievery
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
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.Location = new Point(69, 42);
            button4.Name = "button4";
            button4.Size = new Size(141, 45);
            button4.TabIndex = 3;
            button4.Text = "查询订单";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1154, 699);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.GradientInactiveCaption;
            button7.Location = new Point(228, 42);
            button7.Name = "button7";
            button7.Size = new Size(141, 45);
            button7.TabIndex = 7;
            button7.Text = "刷新";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Delievery
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Name = "Delievery";
            Size = new Size(1688, 1136);
            Load += Delievery_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        public DataGridView dataGridView1;
        private Button button7;
    }
}
