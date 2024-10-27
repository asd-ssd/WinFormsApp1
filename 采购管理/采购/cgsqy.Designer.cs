namespace WinFormsApp1.采购管理.采购
{
    partial class cgsqy
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
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button6 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(474, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 92);
            button1.TabIndex = 42;
            button1.Text = "修改";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(356, 3);
            button4.Name = "button4";
            button4.Size = new Size(112, 92);
            button4.TabIndex = 41;
            button4.Text = "保存";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(238, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 92);
            button2.TabIndex = 39;
            button2.Text = "查询";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(120, 3);
            button6.Name = "button6";
            button6.Size = new Size(112, 92);
            button6.TabIndex = 38;
            button6.Text = "删除";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(2, 3);
            button5.Name = "button5";
            button5.Size = new Size(112, 92);
            button5.TabIndex = 37;
            button5.Text = "采购申请";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1222, 547);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 43;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // button3
            // 
            button3.Location = new Point(592, 3);
            button3.Name = "button3";
            button3.Size = new Size(112, 92);
            button3.TabIndex = 44;
            button3.Text = "刷新";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.Location = new Point(710, 3);
            button7.Name = "button7";
            button7.Size = new Size(112, 92);
            button7.TabIndex = 45;
            button7.Text = "采购计划";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // cgsqy
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button5);
            Name = "cgsqy";
            Size = new Size(1226, 716);
            Load += cgsqy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button button2;
        private Button button6;
        private Button button5;
        public DataGridView dataGridView1;
        private Button button3;
        private Button button7;
    }
}
