namespace WinFormsApp1.采购管理
{
    partial class thsq
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
            button3 = new Button();
            button2 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(357, 3);
            button4.Name = "button4";
            button4.Size = new Size(112, 92);
            button4.TabIndex = 41;
            button4.Text = "保存";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(239, 3);
            button3.Name = "button3";
            button3.Size = new Size(112, 92);
            button3.TabIndex = 40;
            button3.Text = "关闭";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(121, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 92);
            button2.TabIndex = 39;
            button2.Text = "查询";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(112, 92);
            button6.TabIndex = 37;
            button6.Text = "退货";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1222, 530);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 42;
            // 
            // thsq
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button6);
            Name = "thsq";
            Size = new Size(1222, 720);
            Load += thsq_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
        private DataGridView dataGridView1;
    }
}
