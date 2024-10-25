namespace WinFormsApp1.仓库管理.初始查询界面
{
    partial class warehouse_initial
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button8 = new Button();
            button4 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button7 = new Button();
            button13 = new Button();
            button12 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1000, 543);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2856607F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2856655F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2856617F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2842379F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button8, 3, 0);
            tableLayoutPanel1.Controls.Add(button4, 4, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(481, 88);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(99, 3);
            button2.Name = "button2";
            button2.Size = new Size(76, 81);
            button2.TabIndex = 1;
            button2.Text = "修改\r\n数据";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(76, 81);
            button1.TabIndex = 0;
            button1.Text = "新增\r\n数据";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(195, 3);
            button3.Name = "button3";
            button3.Size = new Size(76, 81);
            button3.TabIndex = 2;
            button3.Text = "删除";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button8
            // 
            button8.Location = new Point(291, 3);
            button8.Name = "button8";
            button8.Size = new Size(77, 81);
            button8.TabIndex = 6;
            button8.Text = "刷新";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.Location = new Point(387, 3);
            button4.Name = "button4";
            button4.Size = new Size(77, 81);
            button4.TabIndex = 3;
            button4.Text = "导出\r\n打印";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 699);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 18;
            label4.Text = "库位号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 692);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 710);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 16;
            label3.Text = "查询：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 741);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 15;
            label2.Text = "物料编号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(515, 734);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 696);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 13;
            label1.Text = "物料名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(515, 692);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 741);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 20;
            label5.Text = "库房号";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(220, 734);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 19;
            // 
            // button7
            // 
            button7.Location = new Point(795, 713);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 21;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(847, 32);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 46;
            button13.Text = "取消";
            button13.UseVisualStyleBackColor = true;
            button13.Visible = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(705, 32);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 45;
            button12.Text = "保存";
            button12.UseVisualStyleBackColor = true;
            button12.Visible = false;
            button12.Click += button12_Click;
            // 
            // warehouse_initial
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "warehouse_initial";
            Size = new Size(1000, 800);
            Load += warehouse_initial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox4;
        private Button button7;
        private Button button8;
        private Button button13;
        private Button button12;
    }
}
