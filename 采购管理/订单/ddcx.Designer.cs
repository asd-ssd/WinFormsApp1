namespace WinFormsApp1.采购管理
{
    partial class ddcx
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
            dataGridView1 = new DataGridView();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1685, 1035);
            dataGridView1.TabIndex = 9;
            // 
            // button6
            // 
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(112, 92);
            button6.TabIndex = 24;
            button6.Text = "保存";
            button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(121, 3);
            button3.Name = "button3";
            button3.Size = new Size(112, 92);
            button3.TabIndex = 21;
            button3.Text = "删除";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(357, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 92);
            button2.TabIndex = 20;
            button2.Text = "关闭";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(239, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 92);
            button1.TabIndex = 19;
            button1.Text = "查询";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ddcx
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ddcx";
            Size = new Size(1688, 1136);
            Load += ddcx_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
