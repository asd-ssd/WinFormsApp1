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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(69, 42);
            button1.Name = "button1";
            button1.Size = new Size(141, 45);
            button1.TabIndex = 0;
            button1.Text = "新建";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(216, 42);
            button2.Name = "button2";
            button2.Size = new Size(141, 45);
            button2.TabIndex = 1;
            button2.Text = "修改";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(363, 42);
            button3.Name = "button3";
            button3.Size = new Size(141, 45);
            button3.TabIndex = 2;
            button3.Text = "删除";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(510, 42);
            button4.Name = "button4";
            button4.Size = new Size(141, 45);
            button4.TabIndex = 3;
            button4.Text = "查询";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(657, 42);
            button5.Name = "button5";
            button5.Size = new Size(141, 45);
            button5.TabIndex = 4;
            button5.Text = "确认修改";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(804, 42);
            button6.Name = "button6";
            button6.Size = new Size(141, 45);
            button6.TabIndex = 5;
            button6.Text = "取消修改";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1530, 934);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // Delievery
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Delievery";
            Size = new Size(1688, 1136);
            Load += Delievery_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        public DataGridView dataGridView1;
    }
}
